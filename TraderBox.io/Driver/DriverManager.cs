using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TraderBox.io.Util;

namespace TraderBox.io.Driver
{
    public static class DriverManager
    {
        private static IWebDriver _driver;

        public static IWebDriver GetWebDriver()
        {
            if (_driver == null)
            {
                switch (TestDataReader.GetTestsSettings().browser.BrowserName)
                {
                    case "firefox":
                        {
                            var firefoxOptions = new FirefoxOptions();
                            _driver = new FirefoxDriver(Directory.GetCurrentDirectory(), firefoxOptions);
                            break;
                        }
                    default:
                        {
                            var chromeOptions = new ChromeOptions();
                            //chromeOptions.AddArguments("--headless", "--disable-gpu", "--window-size=1920,1200",
                            //    "--ignore-certificate-errors", "--disable-extensions", "--no-sandbox", "--disable-dev-shm-usage");
                            _driver = new ChromeDriver(Directory.GetCurrentDirectory(), chromeOptions);
                            break;
                        }
                }
            }

            return _driver;
        }

        public static void CloseWebDriver()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
