using NUnit.Framework;
using System;
public class AltTestLogin : BaseTest
{
    #region Declare Field
    private WelComePage welComePage;
    private LoginPage loginPage;
    private HomePage homePage;
    private readonly string _VALIDUSERNAME = ConfigManager.GetConfigValue("username");
    private readonly string _VALIDPASSWORD = ConfigManager.GetConfigValue("password");
    #endregion

    #region TestCase
    //Write your tet case for login here

    [Test]
    public void VerifyUserCanLoginSuccessfully()
    {
        //Navigate to Login Page
        welComePage.NavigateToLoginPage();

        //Login with valid info
        var user = new UserModel()
        {
            Password = _VALIDPASSWORD,
            Username = _VALIDUSERNAME,
        };
        loginPage.Login(user);

        //Verify Login Successfully
        homePage.VerifyLoginSuccessfully(user);
    }

    [Test]
    public void VerifyUserCannotLoginWithInvalidUsernameAndPassword()
    {
        //Navigate to Login Page
        welComePage.NavigateToLoginPage();

        //Login with valid info
        var user = new UserModel()
        {
            Username = $"{_VALIDUSERNAME}_Invalid",
            Password = $"{_VALIDPASSWORD}_Invalid"
        };
        loginPage.Login(user).VerifyInvalidInfo();
    }

    [Test]
    public void VerifyuserCannotLoginWithEmptyUsernameAndPassword()
    {
        //Navigate to Login Page
        welComePage.NavigateToLoginPage();

        //Login with valid info
        var user = new UserModel();
        loginPage.Login(user).VerifyInvalidEmptyInfo();
    }
    #endregion

    #region Test Init
    [SetUp]
    public void TestSetup()
    {
        welComePage = PageFactory.GetPage<WelComePage>();
        loginPage = PageFactory.GetPage<LoginPage>();
        homePage = PageFactory.GetPage<HomePage>();
    }
    #endregion

}