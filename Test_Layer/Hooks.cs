using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SwagLabsTests
{
    [Binding]
    public class Hooks
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}