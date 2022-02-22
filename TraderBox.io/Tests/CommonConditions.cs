using OpenQA.Selenium;
using NUnit.Framework;
using TraderBox.io.Driver;
using TraderBox.io.Pages;
using TraderBox.io.Model;
using NUnit.Framework.Interfaces;
using TraderBox.io.Util;

namespace TraderBox.io.Tests
{
    [SetUpFixture]
    public abstract class CommonConditions
    {
        protected IWebDriver _driver;
        internal MainPage mainPage;

        [SetUp]
        public void InitBrowserAndLogIn()
        {
            _driver = DriverManager.GetWebDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://traderbox.io/demo");

            User testUser = UserCreator.WithCredentialsFromProperty();
            mainPage = new LoginPage(_driver)
                .LogIn()
                .InputEmail(testUser.Email)
                .InputPassword(testUser.Password)
                .SubmitAuthorization();
        }

        [TearDown]
        public void CloseBrowser()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                ScreenShot.MakeScreenShot();
            }
            DriverManager.CloseWebDriver();
        }
    }
}
