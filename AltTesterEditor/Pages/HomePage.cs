using AltTester.AltTesterUnitySDK.Driver;

public class HomePage : BasePage
{
    private readonly HomePagePOM homePagePOM = HomePagePOM.Instance;
    public HomePage() : base() { }
    public HomePage(AltDriver altDriver) : base(altDriver) { }
}