using AltTester.AltTesterUnitySDK.Driver;

public abstract class BasePage
{
    protected AltDriver altDriver;
    protected BasePage() => altDriver = DriverFactory.Instance.AltDriver;
    public BasePage(AltDriver altDriver)
    {
        altDriver = altDriver ?? DriverFactory.Instance.AltDriver;
    }

    public virtual void NavigateToLoginPage(EScence scence)
    {
        altDriver.LoadScene(scence.GetDescription());
    }

}