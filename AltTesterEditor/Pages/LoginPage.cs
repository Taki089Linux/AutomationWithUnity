using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;

public class LoginPage : BasePage
{
    private readonly LoginPagePOM loginPagePOM = LoginPagePOM.Instance;
    public LoginPage() : base() { }
    public LoginPage(AltDriver altDriver) : base(altDriver) { }

    public LoginPage Login(UserModel user)
    {
        altDriver.WaitForObject(By.NAME, loginPagePOM.Txt_Login).SetText(user.Username ?? "");
        altDriver.FindObject(By.NAME, loginPagePOM.Txt_Password).SetText(user.Password ?? "");

        altDriver.FindObject(By.NAME, loginPagePOM.Btn_Login).Click();
        return this;
    }

    public void VerifyInvalidInfo()
    {
        var error = altDriver.WaitForObject(By.NAME, loginPagePOM.Txt_Error);
        Assert.AreEqual(LoginMessage.ALERT_INCORRECT_INFO, error.GetText(), ExceptionMessage.NOT_MATCH_MESSAGE);
    }
    public void VerifyInvalidEmptyInfo()
    {
        var error = altDriver.WaitForObject(By.NAME, loginPagePOM.Txt_Error);
        Assert.AreEqual(LoginMessage.ALERT_EMPTY_INFO, error.GetText(), ExceptionMessage.NOT_MATCH_MESSAGE);
    }
}