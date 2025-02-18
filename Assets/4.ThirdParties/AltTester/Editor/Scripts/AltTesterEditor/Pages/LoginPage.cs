using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;
using System;
using UnityEngine.UIElements;

public class LoginPage : BasePage
{
    private readonly LoginPagePOM loginPagePOM = LoginPagePOM.Instance;
    public LoginPage() : base() { }
    public LoginPage(AltDriver altDriver) : base(altDriver) { }

    public LoginPage Login(UserModel user)
    {

        EnterCredential(user);
        var loginButton = altDriver.FindObject(By.NAME, loginPagePOM.Btn_Login);
        loginButton.Click();

        return this;
    }

    private void EnterCredential(UserModel user)
    {
        var loginField = altDriver.WaitForObject(By.NAME, loginPagePOM.Txt_Login, timeout: 5);
        var passwordField = altDriver.FindObject(By.NAME, loginPagePOM.Txt_Password);
        if (!string.IsNullOrEmpty(user.Username)) loginField.SetText(user.Username);
        if (!string.IsNullOrEmpty(user.Password)) passwordField.SetText(user.Password);
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