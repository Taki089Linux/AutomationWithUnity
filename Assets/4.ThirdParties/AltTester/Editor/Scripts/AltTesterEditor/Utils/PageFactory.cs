using System;
using System.Collections.Generic;

public static class PageFactory
{
    public static T GetPage<T>() where T : BasePage, new()
    {
        return new T();
    }
}
