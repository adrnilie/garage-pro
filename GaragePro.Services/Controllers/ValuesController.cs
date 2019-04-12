using System.Web.Http;

namespace GaragePro.Services.Controllers
{
    [AllowAnonymous]
    public class ValuesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetValues()
        {
            return Ok(new
            {
                a = 1,
                b = 2
            });
        }
    }
}
