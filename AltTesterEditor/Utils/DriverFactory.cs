using AltTester.AltTesterUnitySDK.Driver;
using System;

public class DriverFactory
{
    public AltDriver AltDriver { get; set; }
    private static readonly Lazy<DriverFactory> _instance = new(() => new DriverFactory());
    public static DriverFactory Instance => _instance.Value;

    private DriverFactory()
    {
        try
        {
            AltDriver = new AltDriver(host: "127.0.0.1", port: 13000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ExceptionMessage.NOT_FOUND_DRIVER}: {ex.Message}");
        }
    }

    public void StopDriver()
    {
        AltDriver?.Stop();
    }
}
