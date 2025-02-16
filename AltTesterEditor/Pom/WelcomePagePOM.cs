using System;

internal class WelComePagePOM
{
    private WelComePagePOM() { }
    public static readonly WelComePagePOM Instance = new Lazy<WelComePagePOM>(() => new WelComePagePOM()).Value;

    public string Btn_Login { get; } = "BtnLogin";
}