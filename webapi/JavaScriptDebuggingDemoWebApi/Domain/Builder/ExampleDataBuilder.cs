using System;
using System.Collections.Generic;

namespace JavaScriptDebuggingDemoWebApi.Domain.Builder
{
    public class ExampleDataBuilder
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ProductName { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<Setting> Settings { get; set; }

        public ExampleDataBuilder()
        {
            GenerateNewRandomValues(1);
        }

        public IEnumerable<ExampleData> BuildMany(int numberToBuild)
        {
            List<ExampleData> data = new List<ExampleData>();
            for (int i = 0; i < numberToBuild; i++)
            {
                GenerateNewRandomValues(i);
                ExampleData exampleData = Build();
                data.Add(exampleData);
            }
            return data;
        }

        private ExampleData Build()
        {
            return new ExampleData(Id, Title, ProductName, StockLevel, Settings);
        }

        private void GenerateNewRandomValues(int seed)
        {
            Random random = new Random(seed);
            Id = random.Next(20000);
            Title = StringGenerator.CreateString(seed, 20);
            ProductName = StringGenerator.CreateString(seed, 6);
            StockLevel = random.Next(100000);
            Settings = new SettingsBuilder().WithSeed(seed).BuildMany(1);
        }
    }
}