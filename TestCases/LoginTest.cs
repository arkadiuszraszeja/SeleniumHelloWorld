using NUnit.Framework;
using NUnitTestProject1.Infrastructure;
using NUnitTestProject1.Pages;
using OpenQA.Selenium;
using System;

namespace NUnitTestProject1.TestCases
{
    public class LoginTest : IDisposable
    {
        [SetUp]
        public void Setup()
        {
            _driver = WebDriverFactory.CreateChromeWebDriver("https://www.mail.ru");
            _elementFactory = new ElementFactory(_driver);
        }

        IWebDriver _driver;
        ElementFactory _elementFactory;

        [Test]
        public void Login()
        {
            LoginPage loginPage = new LoginPage(_elementFactory);
            loginPage.Login();
            
            Assert.IsTrue(true);
        }

        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
