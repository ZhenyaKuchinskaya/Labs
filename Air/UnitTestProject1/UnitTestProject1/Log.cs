using OpenQA.Selenium.Opera;
using OpenQA.Selenium;

namespace Lab_4__UnitTest_
{
    class Log
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

        public static void Log_in_OK()
        {
            IWebElement q1 = driver.FindElement(By.Id("loginid"));
            q1.SendKeys("evgeniakucinskaya");
            IWebElement q2 = driver.FindElement(By.Id("password"));
            q2.SendKeys("XIPxop1997");
            driver.FindElement(By.Id("idLoginButton")).Click();

        }

        public static void Log_in_error()
        {
            IWebElement q1 = driver.FindElement(By.Id("loginid"));
            q1.SendKeys("evgeniakucinskaia");
            IWebElement q2 = driver.FindElement(By.Id("password"));
            q2.SendKeys("XIPxop1997");
            driver.FindElement(By.Id("idLoginButton")).Click();
        }

    }
}