using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using OpenQA.Selenium.Support.UI;

namespace TestFramework
{
    public class HomePage
    {
        static string Url = "http://pluralsight.com";
        static string PageTitle = "Pluralsight | Unlimited Online Developer, IT and Cyber Security Training";
        
        [FindsBy(How = How.LinkText, Using = "Authors")]
        private IWebElement authorLink;
        
        IJavaScriptExecutor jse = (IJavaScriptExecutor)Browser.Driver;

        public void GoTo()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectAuthor(string authorName)
        {
            jse.ExecuteScript("arguments[0].scrollIntoView(true)", authorLink);
            authorLink.Click();
            var author = Browser.Driver.FindElement(By.LinkText(authorName));
            //jse.ExecuteScript("scroll(0, 250)"); //SCROLLS TO BOTTOM
            author.Click();
        }

        public bool IsAtAuthorPage(string authorName)
        {
            var authorPage = new AuthorPage();
            PageFactory.InitElements(Browser.Driver, authorPage);
            return authorPage.AuthorName == authorName;
        }

    }
}
