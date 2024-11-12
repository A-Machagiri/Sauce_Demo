using OpenQA.Selenium;
using SwagLabsTests.PageObjects;

namespace SwagLabsTests.PageObjects
{
    public class Login_Actions
    {
        private IWebDriver driver;

        public Login_Actions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterCredentials(string username, string password)
        {
            driver.FindElement(Login_Locators.UsernameField).SendKeys(username);
            driver.FindElement(Login_Locators.PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(Login_Locators.LoginButton).Click();
        }
    }
}