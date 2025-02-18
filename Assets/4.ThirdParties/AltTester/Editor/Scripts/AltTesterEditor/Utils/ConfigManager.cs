using Newtonsoft.Json;
using System;
using System.IO;

public class ConfigManager
{
    private static readonly dynamic config;
    static ConfigManager()
    {
        var path = Directory.GetCurrentDirectory();
        string configPath = Path.Combine(path, "Assets", "4.ThirdParties", "AltTester", "Editor", "Scripts", "AltTesterEditor", "TestData", "config.json");
        string json = File.ReadAllText(configPath);
        config = JsonConvert.DeserializeObject(json);
    }

    public static string GetConfigValue(string key)
    {
        return config[key];
    }
}