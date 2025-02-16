using AltTester.AltTesterUnitySDK.Driver;

public class WelComePage: BasePage
{
    private readonly WelComePagePOM welComePagePOM = WelComePagePOM.Instance;
    public WelComePage() : base() { }
    public WelComePage(AltDriver altDriver) : base(altDriver) { }

    public WelComePage NavigateToLoginPage()
    {
        var loginBtn = altDriver.WaitForObject(By.NAME, welComePagePOM.Btn_Login);
        loginBtn.Click();
        return this;
    }
}