using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject1.Infrastructure
{
    public class ElementFactory
    {
        public ElementFactory(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 30));
        }

        IWebDriver _webDriver;
        WebDriverWait _wait;

        public Element GetElement(By by)
        {
            return new Element(_webDriver.FindElement(by),_wait);
        }
    }
}
