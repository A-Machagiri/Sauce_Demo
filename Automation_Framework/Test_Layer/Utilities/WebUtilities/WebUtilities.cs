using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;

namespace Utilities.WebUtilities
{
    public class WebUtilities
    {
        private IWebDriver _driver;
        public WebDriverWait _wait;

        public void InitializeDriver(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    _driver = new ChromeDriver();
                    break;
                case "edge":
                    _driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Unsupported browser: " + browser);
            }
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // Initialize wait
        }
        public IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                throw new InvalidOperationException("Driver is not initialized");
            }
            return _driver;
        }
        public void NavigateToUrl(string Url)
        {
            _driver.Navigate().GoToUrl(Url);
        }

        
        public void NavigateBack()
        {
            _driver.Navigate().Back();
        }
        public void NavigateForward()
        {
            _driver.Navigate().Forward();
        }
       
        public void Quit()
        {
            _driver.Quit();
        }

    }
}
