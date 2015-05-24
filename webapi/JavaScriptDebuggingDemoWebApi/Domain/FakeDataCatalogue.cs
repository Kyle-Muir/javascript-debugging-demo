using System.Collections.Generic;
using JavaScriptDebuggingDemoWebApi.Domain.Builder;

namespace JavaScriptDebuggingDemoWebApi.Domain
{
    public static class FakeDataCatalogue
    {
        public static IEnumerable<ExampleData> ExampleData
        {
            get
            {
                return new ExampleDataBuilder().BuildMany(10);
            }
        }
    }
}