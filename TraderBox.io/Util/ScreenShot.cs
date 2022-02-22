using OpenQA.Selenium;
using System;
using System.IO;
using TraderBox.io.Driver;

namespace TraderBox.io.Util
{
    public class ScreenShot
    {
        public static void MakeScreenShot()
        {
            Screenshot ss = ((ITakesScreenshot)DriverManager.GetWebDriver()).GetScreenshot();
            string path = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");

            try
            {
                ss.SaveAsFile(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName +
                    "/TraderBox.io/SavedLogs/" + path + ".png", ScreenshotImageFormat.Png);

                Log.Info("Screenshot is maken");
            }
            catch (Exception e)
            {
                Log.Info(e, "Screenshot isn't maken");
                throw;
            }
        }
    }
}
