using System;

internal class HomePagePOM
{
    public static readonly HomePagePOM Instance = new Lazy<HomePagePOM>(() => new HomePagePOM()).Value;
    public string Txt_Welcome { get; } = "TxtWelcome";
}