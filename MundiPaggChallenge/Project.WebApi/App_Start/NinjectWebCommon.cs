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

            kernel.Bind(typeof(IBaseApplicationService<,>)).To(typeof(BaseApplicationService<,>));
            kernel.Bind(typeof(IPersonApplicationService)).To(typeof(PersonApplicationService));
            kernel.Bind(typeof(ILoanApplicationService)).To(typeof(LoanApplicationService));
            kernel.Bind(typeof(IBookApplicationService)).To(typeof(BookApplicationService));
            kernel.Bind(typeof(IMediaApplicationService)).To(typeof(MediaApplicationService));

            #endregion

            #region ' Domain Layer '

            kernel.Bind(typeof(IBaseDomainService<,>)).To(typeof(BaseDomainService<,>));
            kernel.Bind(typeof(IPersonDomainService)).To(typeof(PersonDomainService));
            kernel.Bind(typeof(ILoanDomainService)).To(typeof(LoanDomainService));
            kernel.Bind(typeof(IBookDomainService)).To(typeof(BookDomainService));
            kernel.Bind(typeof(IMediaDomainService)).To(typeof(MediaDomainService));

            #endregion

            #region ' Infra Layer '
            
            kernel.Bind(typeof(IBaseRepository<,>)).To(typeof(BaseRepository<,>));
            kernel.Bind(typeof(IPersonRepository)).To(typeof(PersonRepository));
            kernel.Bind(typeof(ILoanRepository)).To(typeof(LoanRepository));
            kernel.Bind(typeof(IBookRepository)).To(typeof(BookRepository));
            kernel.Bind(typeof(IMediaRepository)).To(typeof(MediaRepository));

            #endregion
        }        
    }
}
