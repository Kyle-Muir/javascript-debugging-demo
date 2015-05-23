using System.Web.Http;

namespace JavaScriptDebuggingDemoWebApi.Controllers
{
    public class EchoController : ApiController
    {
        // GET api/echo
        public string Get()
        {
            return "Echo... echo.... echo";
        }
        // GET api/echo/hello world
        public string Get(string message)
        {
            return message;
        }
    }
}
