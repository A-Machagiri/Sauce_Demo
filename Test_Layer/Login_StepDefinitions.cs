using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestFramework
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly IWebDriver _driver;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given("the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("the user enters valid credentials")]
        public void WhenTheUserEntersValidCredentials()
        {
            _driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            _driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            _driver.FindElement(By.Id("login-button")).Click();
        }

        [Then("the user is redirected to the products page")]
        public void ThenTheUserIsRedirectedToTheProductsPage()
        {
            // Assert that the URL is the expected one
        }

        [When("the user enters invalid credentials")]
        public void WhenTheUserEntersInvalidCredentials()
        {
            _driver.FindElement(By.Id("user-name")).SendKeys("invalid_user");
            _driver.FindElement(By.Id("password")).SendKeys("wrong_password");
            _driver.FindElement(By.Id("login-button")).Click();
        }

        [Then("the user sees an error message")]
        public void ThenTheUserSeesAnErrorMessage()
        {
            // Assert that an error message is displayed
        }
    }
}