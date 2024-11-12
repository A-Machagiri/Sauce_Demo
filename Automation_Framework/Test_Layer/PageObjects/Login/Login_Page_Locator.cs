using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace PageObjects.Login
{
    public class Login_Page_Locator
    {
        private WebDriverWait _wait;
        private By _username = By.Id("user-name");
        private By _password = By.Id("password");
        private By _loginButton = By.Id("login-button");
        private By _logoutNav = By.XPath("//button[@id='react-burger-menu-btn']");
        private By _logoutButton = By.XPath("//a[@id='logout_sidebar_link']");
    }
}
