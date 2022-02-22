using OpenQA.Selenium;
using System.Collections.Generic;
using TraderBox.io.Util;

namespace TraderBox.io.Pages
{
    class TariffPage : Page
    {
        private By switchesLocator = By.XPath("//div[@class = 'check-b__item']/div");
        private By chosenSwitchLocator = By.XPath("//div[@class = 'check-b__item']/div[@class = 'switch switch_active']");

        public TariffPage(IWebDriver driver) : base(driver)
        {
        }

        public TariffPage ChooseTariffWithBigDiscount()
        {
            List<IWebElement> switches = GetElements(switchesLocator);
            switches[1].Click();

            Log.Info("Tariff with big discount is chosen");

            return this;
        }

        public IWebElement GetChosenTariffWithBigDiscount()
        {
            IWebElement chosenSwitch = FindElementWithWaitElementToBeClickable(chosenSwitchLocator, 600);

            return chosenSwitch;
        }
    }
}
