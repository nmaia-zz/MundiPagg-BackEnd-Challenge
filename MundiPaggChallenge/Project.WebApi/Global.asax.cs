using Project.WebApi.Mappings;
using System.Web.Http;
using System.Web.Mvc;

namespace Project.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AreaRegistration.RegisterAllAreas();

            AutoMapperConfig.Register();
        }
    }
}
