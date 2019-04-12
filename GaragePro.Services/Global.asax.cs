using System.Web.Http;

namespace GaragePro.Services
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Bootstrapper.Run();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
