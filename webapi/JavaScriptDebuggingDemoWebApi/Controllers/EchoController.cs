using System.Globalization;
using System.Web.Http;

namespace JavaScriptDebuggingDemoWebApi.Controllers
{
    public class EchoController : ApiController
    {
        // GET api/echo
        public string Get()
        {
            return "Echo";
        }

        // GET api/echo/5
        public string Get(int idToEcho)
        {
            return idToEcho.ToString(CultureInfo.CurrentCulture);
        }
    }
}
