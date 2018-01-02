using OpenQA.Selenium.Opera;
using OpenQA.Selenium;

namespace Lab_4__UnitTest_
{
    class One_way
    {
        static IWebDriver driver;
        private static string url = "https://www.britishairways.com/travel/fx/public/en_by";

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

        public static void One_way_OK()
        {
            driver.FindElement(By.Name("depCountry")).SendKeys("C" + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
            driver.FindElement(By.Name("to")).SendKeys("Moscow" + Keys.Enter);
            driver.FindElement(By.Name("to")).Click();
            driver.FindElement(By.Name("to")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//input[@id='journeyType' and @value='OWFLT']")).Click();
            driver.FindElement(By.Name("depDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Id("theButton")).Click();

        }

      
        public static void One_way_With_error()
        {
            driver.FindElement(By.Name("depCountry")).SendKeys("C" + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
            driver.FindElement(By.Name("to")).SendKeys("Moscow" + Keys.Enter);
            driver.FindElement(By.Name("to")).Click();
            driver.FindElement(By.Name("to")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//input[@id='journeyType' and @value='OWFLT']")).Click();
            driver.FindElement(By.Name("depDate")).Click();
            driver.FindElement(By.XPath("//span[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Id("theButton")).Click();

        }
    }
}
