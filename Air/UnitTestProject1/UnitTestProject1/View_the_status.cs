using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using System.Threading;
using System.Diagnostics;


namespace Lab_4__UnitTest_
{
    class View_the_status
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

        
        public static void View_the_status_OK()
        {
            driver.FindElement(By.LinkText("Information")).Click();
            driver.FindElement(By.LinkText("Flight status")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            driver.FindElement(By.LinkText("Flight number")).Click();
            IWebElement q3 = driver.FindElement(By.Id("flightNumber"));
            q3.SendKeys("256");
            driver.FindElement(By.Id("date")).Click();
            driver.FindElement(By.Id("date")).SendKeys(Keys.Down);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("date")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='byFlight']/div/div/div/input")).Click();
        }

        
        public static void View_the_status_error()
        {
            driver.FindElement(By.LinkText("Information")).Click();
            driver.FindElement(By.LinkText("Flight status")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            driver.FindElement(By.LinkText("Flight number")).Click();
            IWebElement q3 = driver.FindElement(By.Id("flightNumber"));
            q3.SendKeys("1000");
            driver.FindElement(By.Id("date")).Click();
            driver.FindElement(By.Id("date")).SendKeys(Keys.Down);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("date")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='byFlight']/div/div/div/input")).Click();
        }
    }
}
