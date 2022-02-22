using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraderBox.io.Util;

namespace TraderBox.io.Pages
{
    internal class ProfilePage : Page
    {
        private By profileSwitchesLocator = By.XPath("//div[@class = 'profile-settings__name']//div[@class = 'traderbox-switch reverse']");
        private By themeSwitchLocator = By.ClassName("switch");
        private By darkThemeSwitchTextLocator = By.XPath("//div[@class = 'false-label primary-text']");
        private By lightThemeSwitchTextLocator = By.XPath("//div[@class = 'true-label primary-text active']");
        private By profileMenuItemsLocator = By.XPath("//li[@class='profile__menu-item primary-text']");
        private By tabItemsLocator = By.XPath("//div[@class = 'card-header-tabs wrapped']/div[@class = 'tab-item primary-bg primary-text']");
        private By referralLinkInputLocator = By.XPath("//div[@class = 'content-block']//input[@type = 'text']");
        private By referralLinkCreateBtnLocator = By.
            XPath("//div[@class = 'traderbox-button button color-green border-green background-black bordered']/div[@class = 'title']");
        private By createdReferralLinksLocator = By.XPath("//table[@class = 'referal-description__table table-transactions']//td[text() = 'ReferralLinkForGods']");
        private By allReferralLinksLocator = By.XPath("//table[@class = 'referal-description__table table-transactions']//td");
        private By horizontalMenuItemsLocator = By.XPath("//div[@class = 'menu']//div[@class = 'title']");
        private By iconLangSwitcherLocator = By.XPath("//div[@class = 'mobile-menu']//span[@title = 'us']");
        private By iconLangSwitcherOnMainHeaderLocator = By.XPath("//div[@class = 'header-right-menu right-menu']//span[@title = 'us']");

        public ProfilePage(IWebDriver driver) : base(driver)
        {
        }

        public ProfilePage ChooseLightTheme()
        {
            List<IWebElement> switches = GetElements(profileSwitchesLocator);
            switches[1].FindElement(themeSwitchLocator).Click();

            Log.Info("Light theme is chosen");

            return this;
        }

        public IWebElement GetNotActiveDarkThemeSwitchText()
        {
            List<IWebElement> switches = GetElements(profileSwitchesLocator);

            return switches[1].FindElement(darkThemeSwitchTextLocator);
        }

        public IWebElement GetActiveLightThemeSwitchText()
        {
            List<IWebElement> switches = GetElements(profileSwitchesLocator);

            return switches[1].FindElement(lightThemeSwitchTextLocator);
        }

        public ProfilePage GoToReferralProgram()
        {
            List<IWebElement> profileMenuItems = GetElements(profileMenuItemsLocator);
            profileMenuItems[1].Click();

            Log.Info("Referral program is opened");

            return this;
        }

        public ProfilePage ChooseLinksTabItem()
        {
            List<IWebElement> tabItems = GetElements(tabItemsLocator);
            tabItems[0].Click();

            Log.Info("Links tab item is opened");

            return this;
        }

        public ProfilePage InputNameOfReferralLink(string name)
        {
            IWebElement referralLinkInput = FindElementWithWaitElementExists(referralLinkInputLocator, 600);
            referralLinkInput.SendKeys(name);

            Log.Info("Name of referral link is inputted");

            return this;
        }

        public ProfilePage CreateReferralLink()
        {
            IWebElement referralLinkInput = FindElementWithWaitElementToBeClickable(referralLinkCreateBtnLocator, 600);
            referralLinkInput.Click();
            Task.Delay(9000).Wait();

            Log.Info("Referral link is created");

            return this;
        }

        public IWebElement GetCreatedReferralLink()
        {
            List<IWebElement> referralLinks = GetVisibilityElements(createdReferralLinksLocator, 600);

            return referralLinks[0];
        }

        public List<IWebElement> GetAllReferralLinks()
        {
            return GetVisibilityElements(allReferralLinksLocator, 600);
        }

        public ProfilePage GoToProfileMenu()
        {
            List<IWebElement> profileMenuItems = GetElements(horizontalMenuItemsLocator);
            profileMenuItems[4].Click();

            Log.Info("Profile menu is opened");

            return this;
        }

        public ProfilePage ChangeLanguageOnEnglish()
        {
            IWebElement iconLangSwitcher = FindElementWithWaitElementToBeClickable(iconLangSwitcherLocator, 600);
            iconLangSwitcher.Click();

            Log.Info("Language is changed on English");

            return this;
        }

        public IWebElement GetUSLangIconOnMainHeader()
        {
            return FindElementWithWaitElementExists(iconLangSwitcherOnMainHeaderLocator, 600);
        }
    }
}
