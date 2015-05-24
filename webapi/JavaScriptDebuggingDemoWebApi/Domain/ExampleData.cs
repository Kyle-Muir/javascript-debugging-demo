using System;
using System.Collections.Generic;

namespace JavaScriptDebuggingDemoWebApi.Domain
{
    public class ExampleData
    {
        private readonly int _id;
        private readonly string _title;
        private readonly string _productName;
        private readonly int _stockLevel;
        private readonly IEnumerable<Setting> _settings;

        public ExampleData(int id, string title, string productName, int stockLevel, IEnumerable<Setting> settings)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException("title");
            if (string.IsNullOrEmpty(productName)) throw new ArgumentNullException("productName");
            if (settings == null) throw new ArgumentNullException("settings");
            
            _id = id;
            _title = title;
            _productName = productName;
            _stockLevel = stockLevel;
            _settings = settings;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Title
        {
            get { return _title; }
        }

        public string ProductName
        {
            get { return _productName; }
        }

        public int StockLevel
        {
            get { return _stockLevel; }
        }

        public IEnumerable<Setting> Settings
        {
            get { return _settings; }
        }
    }
}