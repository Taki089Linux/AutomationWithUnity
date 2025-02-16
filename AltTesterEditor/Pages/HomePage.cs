using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;

public class HomePage : BasePage
{
    private readonly HomePagePOM homePagePOM = HomePagePOM.Instance;
    public HomePage() : base() { }
    public HomePage(AltDriver altDriver) : base(altDriver) { }

    public void VerifyLoginSuccessfully(UserModel user)
    {
        altDriver.WaitForCurrentSceneToBe(EScence.HomeScence.GetDescription());
        var welcome = altDriver.WaitForObject(By.NAME, homePagePOM.Txt_Welcome);
        Assert.That(welcome.GetText(), Does.Contain(WelcomeMessage.WELCOME_USER(user.Username)));

    }
}