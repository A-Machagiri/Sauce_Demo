using OpenQA.Selenium;

namespace TestFramework
{
    public class Hooks
    {
        public IWebDriver Driver { get; set; }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Initialize WebDriver
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Close WebDriver
            Driver.Quit();
        }
    }
}