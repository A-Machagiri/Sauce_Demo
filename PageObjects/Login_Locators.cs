using OpenQA.Selenium;

namespace PageObjects
{
    public static class LoginLocators
    {
        public static By UsernameField = By.Id("user-name");
        public static By PasswordField = By.Id("password");
        public static By LoginButton = By.Id("login-button");
    }
}