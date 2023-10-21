using PhotoRevive.Abstraction;
using PhotoRevive.BusinessLogic;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace PhotoRevive
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // Initialize your DI container and register dependencies
            //var container = new UnityContainer();
            //container.RegisterType<IImageService, ImageService>();

            // Store the container in a static class for global access
            //UnityConfig.Container = container;

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
