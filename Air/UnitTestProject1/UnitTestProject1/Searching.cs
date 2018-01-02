using OpenQA.Selenium;
using OpenQA.Selenium.Opera;

namespace Lab_4__UnitTest_
{
    class Searching
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

        
        public static void Search()
        {
            driver.FindElement(By.ClassName("miscSearchWidth")).SendKeys("Enter");
            IWebElement op1 = driver.FindElement(By.Id("navSearch"));
            op1.SendKeys("London");
            op1.SendKeys(Keys.Enter);

        }

      
        public static void Search_error()
        {
            driver.FindElement(By.ClassName("miscSearchWidth")).SendKeys("Enter");
            IWebElement op = driver.FindElement(By.Id("navSearch"));
            op.SendKeys("sfreyer");
            op.SendKeys(Keys.Enter);

        }
    }
}
