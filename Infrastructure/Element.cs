using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace NUnitTestProject1.Infrastructure
{
    public class Element : IWebElement
    {
        public Element(IWebElement webElement, WebDriverWait wait)
        {
            _webElement = webElement;
            _wait = wait;
        }
        private IWebElement _webElement;
        private WebDriverWait _wait;

        public string TagName => _webElement.TagName;
        public string Text => _webElement.Text;
        public bool Enabled => _webElement.Enabled;
        public bool Selected => _webElement.Selected;
        public Point Location => _webElement.Location;
        public Size Size => _webElement.Size;
        public bool Displayed => _webElement.Displayed;

        public void Clear()
        {
            
            _webElement.Clear();
        }

        public void Click()
        {
            _webElement.Click();
        }

        public IWebElement FindElement(By by)
        {
            Wait();
            return _webElement.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            Wait();
            return _webElement.FindElements(by);
        }

        public string GetAttribute(string attributeName)
        {
            Wait();
            return _webElement.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            Wait();
            return _webElement.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            Wait();
            return _webElement.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            Wait();
            _webElement.SendKeys(text);
        }

        public void Submit()
        {
            Wait();
            _webElement.Submit();
        }

        private void Wait()
        {
            _wait.Until(x =>
            {
                try
                {
                    return _webElement.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }
    }
}
