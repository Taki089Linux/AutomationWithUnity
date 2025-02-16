using NUnit.Framework;
public class AltTestLogin : BaseTest
{
    #region Declare Field
    private WelComePage welComePage;
    private LoginPage loginPage;

    private string _VALIDUSERNAME;
    private string _VALIDPASSWORD;
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

    }

    #endregion

    #region Test Init
    [SetUp]
    public void TestSetup()
    {
        welComePage = PageFactory.GetPage<WelComePage>();
        loginPage = PageFactory.GetPage<LoginPage>();

        _VALIDUSERNAME = ConfigManager.GetConfigValue("username");
        _VALIDPASSWORD = ConfigManager.GetConfigValue("password");
    }
    #endregion

}