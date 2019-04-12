using System.EnterpriseServices;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace GaragePro.Services
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            DependenciesResolver.Initialize(GlobalConfiguration.Configuration);
        }
    }
}