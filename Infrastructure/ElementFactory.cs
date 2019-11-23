using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject1.Infrastructure
{
    public class ElementFactory
    {
        public ElementFactory(IWebDriver webDriver, WebDriverWait wait)
        {
            _webDriver = webDriver;
            _wait = wait;
        }

        IWebDriver _webDriver;
        WebDriverWait _wait;

        public Element GetElement(By by)
        {
            return new Element(_webDriver.FindElement(by),_wait);
        }
    }
}
