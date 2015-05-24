using System.Collections.Generic;

namespace JavaScriptDebuggingDemoWebApi.Domain.Builder
{
    public class SettingsBuilder
    {
        private int _seed = Constants.DefaultSeedValue;

        public SettingsBuilder()
        {
            GenerateNewRandomValues(1);
        }

        public IEnumerable<Setting> BuildMany(int numberToBuild)
        {
            List<Setting> settings = new List<Setting>();
            for (int i = 0; i < numberToBuild; i++)
            {
                GenerateNewRandomValues(i);
                Setting setting = Build();
                settings.Add(setting);
            }
            return settings;
        }

        private Setting Build()
        {
            return new Setting(Key, Value);
        }

        public string Value { get; set; }

        public string Key { get; set; }


        private void GenerateNewRandomValues(int seed)
        {
            if (_seed != Constants.DefaultSeedValue)
            {
                seed = _seed;
            }
            Key = StringGenerator.CreateString(seed, 20);
            Value = StringGenerator.CreateString(seed, 15);
        }

        public SettingsBuilder WithSeed(int seed)
        {
            _seed = seed;
            return this;
        }
    }
}