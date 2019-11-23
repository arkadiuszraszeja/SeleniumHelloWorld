using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1.Infrastructure
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateChromeWebDriver(string url)
        {
            var chromeOptions = new ChromeOptions();
            // chromeOptions.AddArgument("headless");
            chromeOptions.AddArgument("window-size=1000,2000");

            var webDriver = new ChromeDriver(@"C:\chromedriver", chromeOptions);
            webDriver.Url = url;
            return webDriver;
        }
    }
}
