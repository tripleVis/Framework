using OpenQA.Selenium;
using TraderBox.io.Util;

namespace TraderBox.io.Pages
{
    internal class LoginPage : Page
    {
        private By logInBtnLocator = By.XPath("//a[@class = 'button button_white w-button js-auth-btn']");
        private By emailLocator = By.Id("loginform-identifier");
        private By passwordLocator = By.Id("loginform-password");
        private By submitBtnLocator = By.Name("login-button");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public LoginPage LogIn()
        {
            IWebElement logInBtn = FindElement(logInBtnLocator);
            logInBtn.Click();

            Log.Info("LogIn button is clicked");

            return this;
        }

        public LoginPage InputEmail(string testEmail)
        {
            IWebElement inputEmail = FindElementWithWaitElementExists(emailLocator, 10);
            inputEmail.SendKeys(testEmail);

            Log.Info("Email field is filled");

            return this;
        }

        public LoginPage InputPassword(string testPassword)
        {
            IWebElement inputPassword = FindElement(passwordLocator);
            inputPassword.SendKeys(testPassword);

            Log.Info("Password field is filled");

            return this;
        }

        public MainPage SubmitAuthorization()
        {
            IWebElement submitBtn = FindElement(submitBtnLocator);
            submitBtn.Click();

            Log.Info("Authorization is submitted");

            return new MainPage(driver);
        }
    }
}
