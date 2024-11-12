using OpenQA.Selenium;

namespace SwagLabsTests.PageObjects
{
    public static class Login_Locators
    {
        public static By UsernameField = By.Id("user-name");
        public static By PasswordField = By.Id("password");
        public static By LoginButton = By.Id("login-button");
    }
}