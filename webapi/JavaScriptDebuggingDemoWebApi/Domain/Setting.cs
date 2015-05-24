using System;

namespace JavaScriptDebuggingDemoWebApi.Domain
{
    public class Setting
    {
        private readonly string _key;
        private readonly string _value;

        public Setting(string key, string value)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException("key");
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

            _key = key;
            _value = value;
        }

        public string Key
        {
            get { return _key; }
        }

        public string Value
        {
            get { return _value; }
        }
    }
}