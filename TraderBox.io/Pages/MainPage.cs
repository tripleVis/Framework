using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraderBox.io.Util;

namespace TraderBox.io.Pages
{
    internal class MainPage : Page
    {
        private By windowWithMessageAboutSettingUpTwoFactorAuthenticationLocator = By.
            XPath("//div[@class = 'el-dialog__wrapper traderbox-dialog modal-mfa-notify coinup']" +
                "//i[@class = 'el-dialog__close el-icon el-icon-close']");
        private By coinsViewOfDemoAccLocator = By.XPath("//div[@class = 'group']/div[@class = 'title primary-text']");
        private By startNumberOfDotsLocator = By.
            XPath("//span[contains(text(),'DOT') and @class = 'title primary-text']/ancestor::tr//span[@class = 'primary-text']");
        private By searchingForAllPolkadotTradingPairsLocator = By.XPath("//div[@class = 'input']//input[@type = 'text']");
        private By choosingDotBtcTradingPairLocator = By.XPath("//div[@class = 'ticker primary-text']//span[contains(text(),'DOT/BTC')]");
        private By inputingNumberOfDotsLocator = By.XPath("//div[@class = 'order-tab']//div[@class = 'quantity-block']//input[@type = 'text']");
        private By submitingCurrnecyExchangeBtnLocator = By.XPath("//div[@class = 'footer primary-bg light']/div[@class = 'button green']");
        private By finishNumberOfDotsLocator = By.
                XPath("//span[contains(text(),'DOT') and @class = 'title primary-text']/ancestor::tr//span[@class = 'primary-text']");
        private By iframeLocator = By.XPath("//iframe[starts-with(@id, 'tradingview')]");
        private By fullscreenModLocator = By.Id("header-toolbar-fullscreen");
        private By exitFullscreenButtonLocator = By.ClassName("tv-exit-fullscreen-button");
        private By openProfileLocator = By.XPath("//div[@class = 'header-profile-link primary-text item']");
        private By openHelpLocator = By.XPath("//a[@class = 'header-help-link secondary-text help item']//span");
        private By dropboxWithAllStockExchangesLocator = By.XPath("//div[@class = 'current-exchange primary-text']");
        private By dropdownItemOfCreationLocator = By.XPath("//div[@class = 'dropdown-item add-exchange']");
        private By nameOfNewStockExchangeLocator = By.XPath("//div[@class = 'el-input']/input[@class = 'el-input__inner']");
        private By confirmButtonsLocator = By.XPath("//div[@class = 'traderbox-button color-white border-black background-green centered big']/div[@class = 'title']");
        private By createdStockExchangeLocator = By.XPath("//div[@class = 'dropdown-item traderbox-exchange']/div[text() = 'Currency']");
        private By allStockExchangesLocator = By.XPath("//div[@class = 'dropdown-item traderbox-exchange']/div[@class = 'title primary-text']");

        public MainPage(IWebDriver driver) : base(driver) { }

        public MainPage CloseWindowWithMessageAboutSettingUpTwoFactorAuthentication()
        {
            IWebElement closeWindowWithMessageAboutSettingUpTwoFactorAuthentication =
                FindElementWithWaitElementToBeClickable(windowWithMessageAboutSettingUpTwoFactorAuthenticationLocator, 600);
            closeWindowWithMessageAboutSettingUpTwoFactorAuthentication.Click();

            Log.Info("Window with message about setting up two-factor authentication is closed");

            return this;
        }

        public MainPage ViewCoinsOfDemoAcc()
        {
            IWebElement viewCoinsOfDemoAcc = FindElementWithWaitElementToBeClickable(coinsViewOfDemoAccLocator, 600);
            viewCoinsOfDemoAcc.Click();

            Log.Info("Demo account coins is viewed");

            return this;
        }

        public string GetExpectedNumberOfDots(int testValueForDots)
        {
            string startNumberOfDots = FindElementWithWaitElementExists(startNumberOfDotsLocator, 600).Text;
            int dotIndex = startNumberOfDots.IndexOf(".");
            string startNumberOfDotsBeforeDotIndex = startNumberOfDots.Substring(0, dotIndex);

            Log.Info("Expected number of dots is got");

            return Convert.ToString(Convert.ToInt32(startNumberOfDotsBeforeDotIndex) + testValueForDots);
        }

        public MainPage SearchForAllPolkadotTradingPairs()
        {
            IWebElement searchForAllPolkadotTradingPairs = FindElementWithWaitElementExists(searchingForAllPolkadotTradingPairsLocator, 600);
            searchForAllPolkadotTradingPairs.SendKeys("dot");

            Log.Info("All polkadot trading pairs is searched");

            return this;
        }

        public MainPage ChooseDotBtcTradingPair()
        {
            IWebElement chooseDotBtcTradingPair = FindElementWithWaitElementToBeClickable(choosingDotBtcTradingPairLocator, 600);
            chooseDotBtcTradingPair.Click();

            Log.Info("DotBtc trading pair is chosen");

            return this;
        }

        public MainPage InputNumberOfDots(string testValueForDots)
        {
            IWebElement inputNumberOfDots = FindElementWithWaitElementExists(inputingNumberOfDotsLocator, 600);
            inputNumberOfDots.SendKeys(Convert.ToString(testValueForDots));

            Log.Info("Number of dots is input");

            return this;
        }

        public MainPage SubmitCurrnecyExchange()
        {
            IWebElement submitCurrnecyExchangeBtn = FindElementWithWaitElementToBeClickable(submitingCurrnecyExchangeBtnLocator, 600);
            submitCurrnecyExchangeBtn.Click();

            Log.Info("Currnecy exchange is submitted");

            return this;
        }

        public string GetFinishNumberOfDots()
        {
            Task.Delay(50000).Wait();
            string finishNumberOfDots = FindElementWithWaitElementExists(finishNumberOfDotsLocator, 600).Text;
            int dotIndex = finishNumberOfDots.IndexOf(".");

            Log.Info("Finish number of dots is got");

            return finishNumberOfDots.Substring(0, dotIndex);
        }

        public MainPage OpenFullscreenMod()
        {
            SwitchToFrame(iframeLocator);
            IWebElement fullscreenMod = FindElementWithWaitElementToBeClickable(fullscreenModLocator, 600);
            fullscreenMod.Click();

            Log.Info("Fullscreen mod is opened");

            return this;
        }

        public IWebElement GetFullscreenModeOpen()
        {
            IWebElement realTextInFullscreenMod = FindElementWithWaitElementExists(exitFullscreenButtonLocator, 600);

            Log.Info("Fullscreen close button exists");

            return realTextInFullscreenMod;
        }

        public ProfilePage GoToProfilePage()
        {
            IWebElement profile = FindElementWithWaitElementToBeClickable(openProfileLocator, 600);
            profile.Click();

            Log.Info("Profile is opened");

            return new ProfilePage(driver);
        }

        public HelpPage GoToHelpPage()
        {
            IWebElement help = FindElementWithWaitElementToBeClickable(openHelpLocator, 600);
            help.Click();

            Log.Info("Help is opened");

            return new HelpPage(driver);
        }

        public MainPage OpenDropboxWithAllStockExchanges()
        {
            Task.Delay(9000).Wait();
            IWebElement dropboxWithAllStockExchanges = FindElementWithWaitElementIsVisible(dropboxWithAllStockExchangesLocator, 600);
            dropboxWithAllStockExchanges.Click();

            Log.Info("Dropbox with all stock exchanges is opened");

            return this;
        }

        public MainPage AddExchange()
        {

            IWebElement dropdownItemOfCreation = FindElementWithWaitElementToBeClickable(dropdownItemOfCreationLocator, 600);
            dropdownItemOfCreation.Click();

            Log.Info("Dropbox item of creation is clicked");

            return this;
        }

        public MainPage InputNameOfNewStockExcgange(string name)
        {
            IWebElement nameOfNewStockExchange = FindElementWithWaitElementExists(nameOfNewStockExchangeLocator, 600);
            nameOfNewStockExchange.SendKeys(name);

            Log.Info("Name of new stock exchange is inputted");

            return this;
        }

        public MainPage ClickConfirmButton()
        {
            List<IWebElement> confirmButtons = GetVisibilityElements(confirmButtonsLocator, 600);
            confirmButtons[1].Click();

            Log.Info("New stock exchange is created");

            return this;
        }

        public IWebElement GetCreatedStockExchange()
        {
            List<IWebElement> referralLinks = GetVisibilityElements(createdStockExchangeLocator, 600);

            return referralLinks[0];
        }

        public List<IWebElement> GetAllStockExchanges()
        {
            return GetVisibilityElements(allStockExchangesLocator, 600);
        }
    }
}
