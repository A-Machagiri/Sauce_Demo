using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginActions
    {
        private IWebDriver _driver;

        public LoginActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterCredentials(string username, string password)
        {
            _driver.FindElement(LoginLocators.UsernameField).SendKeys(username);
            _driver.FindElement(LoginLocators.PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(LoginLocators.LoginButton).Click();
        }
    }
}