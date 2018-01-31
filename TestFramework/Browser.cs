using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using System;
using OpenQA.Selenium.Interactions;

namespace TestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new ChromeDriver(@"C:\Users\Katie\Documents\selenium\TestFramework");
        
        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        internal static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            //webDriver.Close();
            webDriver.Dispose();
        }

    }
}