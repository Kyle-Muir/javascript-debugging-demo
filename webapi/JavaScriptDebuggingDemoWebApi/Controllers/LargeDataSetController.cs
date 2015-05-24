using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using JavaScriptDebuggingDemoWebApi.Domain;

namespace JavaScriptDebuggingDemoWebApi.Controllers
{
    public class LargeDataSetController : ApiController
    {
        // GET api/largedataset
        public JsonResult<IEnumerable<ExampleData>> Get()
        {
            return Json(FakeDataCatalogue.ExampleData);
        }
    }
}
