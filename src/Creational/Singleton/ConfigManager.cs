namespace Singleton;

internal class ConfigManager
{
    private readonly Dictionary<string, object> _settings = new Dictionary<string, object>();
    public static ConfigManager Instance { get; } = new ConfigManager();

    private ConfigManager() { }

    public void Set(string key, object value) { _settings[key] = value; }
    public object Get(string key) { return _settings[key]; }
}
