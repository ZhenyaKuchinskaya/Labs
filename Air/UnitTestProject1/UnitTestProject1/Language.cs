using OpenQA.Selenium.Opera;
using System.Threading;
using OpenQA.Selenium;

namespace Lab_4__UnitTest_
{
    class Language
    {
        static IWebDriver driver;
        private static string url = "https://www.britishairways.com/travel/home/public/en_by";

        public static IWebDriver Instance()
        {
            OperaOptions options = new OperaOptions();
            options.BinaryLocation = @"C:\Program Files\Opera\49.0.2725.64\opera.exe";
            driver = new OperaDriver("F:\\UnitTestProject1", options);
            return driver;
        }

        public static void URL()
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void Change()
        {
            driver.FindElement(By.ClassName("miscCountryWidth")).Click();
            driver.FindElement(By.LinkText("Change country/language")).Click();
            IWebElement op2 = driver.FindElement(By.Id("languagecode"));
            op2.SendKeys("Enter");
            op2.SendKeys(Keys.ArrowDown);
            op2.SendKeys(Keys.ArrowDown);
            op2.SendKeys(Keys.ArrowDown);
            op2.SendKeys(Keys.ArrowDown);
            op2.SendKeys(Keys.ArrowDown);
            op2.SendKeys(Keys.ArrowDown);
            op2.SendKeys(Keys.ArrowDown);
            op2.SendKeys(Keys.ArrowDown);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@class='primary']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='modalContinueBtn primary']")).Click();
        }
    }
}
