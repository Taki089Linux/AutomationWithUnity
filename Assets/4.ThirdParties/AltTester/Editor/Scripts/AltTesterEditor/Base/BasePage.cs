using AltTester.AltTesterUnitySDK.Driver;
public abstract class BasePage
{
    protected AltDriver altDriver;
    protected BasePage() => altDriver = DriverFactory.Instance.AltDriver;
    public BasePage(AltDriver altDriver) => this.altDriver = altDriver;


}