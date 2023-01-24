using System.Collections.Generic;

namespace DesignPatterns.singleton
{
    public class ConfigManager
    {
        private ConfigManager()
        {
        }

        private Dictionary<string, object> _settings = new();

        private static ConfigManager Instance { get; } = new ConfigManager();

        public void Set(string key, object value)
        {
            _settings.Add(key, value);
        }

        public object Get(string key)
        {
            if (_settings.ContainsKey(key)) return _settings[key];

            return null;
        }

        public static ConfigManager GetInstance()
        {
            return Instance;
        }
    }
}