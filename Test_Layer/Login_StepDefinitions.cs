using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SwagLabsTests
{
    [Binding]
    public class Login_StepDefinitions
    {
        private IWebDriver driver;

        public Login_StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given("the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("the user enters valid credentials")]
        public void WhenTheUserEntersValidCredentials()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
        }

        [Then("the user is redirected to the products page")]
        public void ThenTheUserIsRedirectedToTheProductsPage()
        {
            // Assert that the URL is the expected one
        }

        [When("the user enters invalid credentials")]
        public void WhenTheUserEntersInvalidCredentials()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("invalid_user");
            driver.FindElement(By.Id("password")).SendKeys("wrong_password");
            driver.FindElement(By.Id("login-button")).Click();
        }

        [Then("the user sees an error message")]
        public void ThenTheUserSeesAnErrorMessage()
        {
            // Assert that an error message is displayed
        }

        [When("the user attempts to login as a locked-out user")]
        public void WhenTheUserAttemptsToLoginAsALockedOutUser()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("locked_out_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
        }

        [Then("the user sees a locked out message")]
        public void ThenTheUserSeesALockedOutMessage()
        {
            // Assert that a locked out message is displayed
        }
    }
}