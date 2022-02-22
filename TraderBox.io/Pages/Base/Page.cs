using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;

namespace TraderBox.io.Pages
{
    internal class Page
    {
        protected IWebDriver driver;
        private WebDriverWait wait;

        public Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FindElement(By locator)
        {
            return driver.FindElement(locator);
        }

        public List<IWebElement> GetElements(By locator)
        {
            IReadOnlyCollection<IWebElement> readOnlyElements = driver.FindElements(locator);
            List<IWebElement> elements = new List<IWebElement>();
            foreach (IWebElement element in readOnlyElements)
                elements.Add(element);

            return elements;
        }

        public List<IWebElement> GetVisibilityElements(By locator, double seconds)
        {
            IReadOnlyCollection<IWebElement> readOnlyElements = driver.FindElements(locator);
            List<IWebElement> elements = new List<IWebElement>();
            foreach (IWebElement element in readOnlyElements)
                elements.Add(element);

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            return elements;
        }

        public IWebElement FindElementWithWaitElementExists(By locator, double seconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            return wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public IWebElement FindElementWithWaitElementToBeClickable(By locator, double seconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public IWebElement FindElementWithWaitElementIsVisible(By locator, double seconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void SwitchToFrame(By frameLocator)
        {
            driver.SwitchTo().Frame(FindElement(frameLocator));
        }

        public void SwitchToDefaultContent()
        {
            driver.SwitchTo().DefaultContent();
        }
    }
}

