using NUnitTestProject1.Infrastructure;
using OpenQA.Selenium;

namespace NUnitTestProject1.Pages
{
    public class LoginPage
    {
        public LoginPage(ElementFactory elementFactory)
        {
            _elementFactory = elementFactory;
        }

        ElementFactory _elementFactory;
        string _userName = "testSeleniumUser";
        string _password = "testSeleniumPassword";

        public IWebElement LoginInput { get => _elementFactory.GetElement(By.Id("mailbox:login")); }
        public IWebElement LoginButton { get => _elementFactory.GetElement(By.Id("mailbox:submit")); }
        public IWebElement PasswordInput { get => _elementFactory.GetElement(By.Id("mailbox:password")); }
        public IWebElement PasswordButton { get => _elementFactory.GetElement(By.CssSelector("#mailbox\\:submit > input")); }
        public const string URL = "mail.ru";
        public void Login()
        {
            LoginInput.SendKeys(_userName);
            LoginButton.Click();
            PasswordInput.SendKeys(_password);
            LoginButton.Click();
        }
    }
}
