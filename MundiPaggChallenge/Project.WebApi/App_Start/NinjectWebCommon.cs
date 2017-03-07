[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Project.WebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Project.WebApi.App_Start.NinjectWebCommon), "Stop")]

namespace Project.WebApi.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using System.Web.Http;
    using System.Web.Http.Dependencies;
    using Application.Contracts;
    using Application.Services;
    using Domain.Contracts.Services;
    using Domain.Services;
    using Domain.Contracts.Repositories;
    using Infra.Repository.Repositories;
    using Application.Contracts.ElasticSearch;
    using Application.Services.ElasticSearch;
    using Domain.Contracts.Services.ElasticSearch;
    using Domain.Services.ElasticSearch;
    using Domain.Contracts.ESClientProvider;
    using Infra.Repository.ElasticSearch;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                GlobalConfiguration.Configuration.DependencyResolver = kernel.Get<IDependencyResolver>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            #region ' Application Layer'

            kernel.Bind(typeof(IBaseElasticSearchApplicationService<>)).To(typeof(BaseElasticSearchApplicationService<>));
            kernel.Bind(typeof(IPersonElasticSearchApplicationService)).To(typeof(PersonElasticSearchApplicationService));
            //kernel.Bind(typeof(ILoanApplicationService)).To(typeof(LoanApplicationService));
            //kernel.Bind(typeof(IBookApplicationService)).To(typeof(BookApplicationService));
            //kernel.Bind(typeof(IMediaApplicationService)).To(typeof(MediaApplicationService));

            #endregion

            #region ' Domain Layer '

            kernel.Bind(typeof(IBaseDomainElasticSearchService<>)).To(typeof(BaseDomainElasticSearchService<>));
            kernel.Bind(typeof(IPersonDomainElasticSearchService)).To(typeof(PersonDomainElasticSearchService));
            //kernel.Bind(typeof(ILoanDomainService)).To(typeof(LoanDomainService));
            //kernel.Bind(typeof(IBookDomainService)).To(typeof(BookDomainService));
            //kernel.Bind(typeof(IMediaDomainService)).To(typeof(MediaDomainService));

            #endregion

            #region ' Infra Layer '

            kernel.Bind(typeof(IBaseElasticSearchClientProvider<>)).To(typeof(BaseElasticSearchClientProvider<>));
            kernel.Bind(typeof(IPersonElasticSearchClientProvider)).To(typeof(PersonElasticSearchClientProvider));
            kernel.Bind(typeof(IItemElasticSearchClientProvider)).To(typeof(ItemElasticSearchClientProvider));
            //kernel.Bind(typeof(ILoanRepository)).To(typeof(LoanRepository));
            //kernel.Bind(typeof(IBookRepository)).To(typeof(BookRepository));
            //kernel.Bind(typeof(IMediaRepository)).To(typeof(MediaRepository));

            #endregion
        }        
    }
}
