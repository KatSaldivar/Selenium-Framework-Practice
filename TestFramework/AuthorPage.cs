using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class AuthorPage
    {
        [FindsBy(How = How.CssSelector, Using = "div.author-content h2")]
        private IWebElement authorName;
        public string AuthorName
        {
            get { return authorName.Text; }
        }
    }
}
