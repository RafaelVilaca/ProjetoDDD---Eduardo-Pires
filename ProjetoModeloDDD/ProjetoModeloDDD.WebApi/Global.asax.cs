using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SimpleInjector.Integration.WebApi;

namespace ProjetoModeloDDD.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //DependencyResolver.SetResolver(SimpleInjectorApiContainer.RegisterContainer()); //Se usa apenas quando a controller se herda de Controller, e nao ApiController

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(SimpleInjectorApiContainer.RegisterContainer());

        }
    }
}
