
using System;

internal class LoginPagePOM
{
    private LoginPagePOM() { }
    public static LoginPagePOM Instance => new Lazy<LoginPagePOM>(() => new LoginPagePOM()).Value;

    public string Txt_Login { get; } = "IpfEmail";
    public string Txt_Password { get; } = "IpfPassword";
    public string Btn_Login { get; } = "BtnLogin";
    public string Txt_Error { get; } = "TxtError";
}