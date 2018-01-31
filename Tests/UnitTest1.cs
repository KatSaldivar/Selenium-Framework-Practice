using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void Can_Go_To_Author_Pages()
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectAuthor("Abby Covert");
            Assert.IsTrue(Pages.HomePage.IsAtAuthorPage("Abby Covert"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }
    }
}
