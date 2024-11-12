using OpenQA.Selenium;
using System;

namespace SwagLabsTests.Utilities
{
    public class WebUtilities
    {
        public IWebDriver Driver { get; set; }

        public WebUtilities(IWebDriver driver)
        {
            Driver = driver;
        }

        public void WaitForElement(By locator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(locator).Displayed);
        }
    }
}