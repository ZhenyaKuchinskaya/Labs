using OpenQA.Selenium.Opera;
using System.Threading;
using OpenQA.Selenium;

namespace Lab_4__UnitTest_
{
    class  Two_way
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

        public static void Two_way_OK()
        {
            driver.FindElement(By.Name("depCountry")).SendKeys("M" + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
            driver.FindElement(By.Name("from")).SendKeys(Keys.Down + Keys.Down + Keys.Enter);
            IWebElement q1 = driver.FindElement(By.Name("to"));
            q1.SendKeys("London, Heathrow (LHR), United Kingdom");
            driver.FindElement(By.Name("depDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Name("retDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Id("theButton")).Click();

        }

        public static void Two_way_Error()
        {
            driver.FindElement(By.Name("depCountry")).SendKeys("M" + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
            driver.FindElement(By.Name("from")).SendKeys(Keys.Down + Keys.Down + Keys.Enter);
            IWebElement q1 = driver.FindElement(By.Name("to"));
            q1.SendKeys("London, City Airport (LCY), United Kingdom");
            driver.FindElement(By.Name("depDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Name("retDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Id("theButton")).Click();


        }

        public static void Two_way_Error2()
        {
            driver.FindElement(By.Name("depCountry")).SendKeys("M" + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
            driver.FindElement(By.Name("from")).SendKeys(Keys.Down + Keys.Down + Keys.Enter);
            IWebElement q1 = driver.FindElement(By.Name("to"));
            q1.SendKeys("Acapulco");
            driver.FindElement(By.Name("depDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Name("retDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Id("theButton")).Click();


        }

        public static void Two_way_not_found()
        {
            driver.FindElement(By.Name("depCountry")).SendKeys("M" + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
            driver.FindElement(By.Name("from")).SendKeys(Keys.Down + Keys.Down + Keys.Enter);
            IWebElement q1 = driver.FindElement(By.Name("to"));
            q1.SendKeys("London, Heathrow (LHR), United Kingdom");
            driver.FindElement(By.Name("depDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Name("retDate")).Click();
            driver.FindElement(By.XPath("//a[@class='ui-state-default' ]")).Click();
            driver.FindElement(By.Name("ad")).SendKeys(Keys.Up + Keys.Enter);
            driver.FindElement(By.Name("ch")).SendKeys(Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("theButton")).Click();


        }


    }
}
