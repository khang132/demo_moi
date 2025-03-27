using System.Web.Http;

namespace APISecurityDemo.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("api/demo")]
        public IHttpActionResult GetMessage()
        {
            return Ok("API Security Demo đang chạy!");
        }
    }
}
