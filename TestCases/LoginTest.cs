using NUnit.Framework;
using NUnitTestProject1.Infrastructure;
using NUnitTestProject1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject1.TestCases
{
    public class LoginTest : IDisposable
    {
        [SetUp]
        public void Setup()
        {
            _driver = WebDriverFactory.CreateChromeWebDriver("https://www.mail.ru");
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 30));
            _elementFactory = new ElementFactory(_driver, _wait);
        }

        IWebDriver _driver;
        ElementFactory _elementFactory;
        WebDriverWait _wait;

        [Test]
        public void Login()
        {
            LoginPage loginPage = new LoginPage(_elementFactory);
            loginPage.Login();
            _wait.Until(x => _driver.Url.Contains(MailboxPage.URL));
            Assert.IsTrue(_driver.Url.Contains(MailboxPage.URL));
        }

        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
