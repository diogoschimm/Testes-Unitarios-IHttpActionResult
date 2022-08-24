using System.Runtime.CompilerServices;
using System.Web.Http;

namespace WebAppSampleTestApi.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get(string id)
        {
            var data = new { Success = true, Data = id };
            return Ok(data);
        }
    }
}
