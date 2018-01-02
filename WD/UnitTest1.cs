using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab_4__UnitTest_
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;
        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            driver = new ChromeDriver(@"C:\Users\Евгения\source\repos\UnitTestProject1");
            driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public void Test()
        {
            driver.Navigate().GoToUrl("http://github.com");
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("login_field")).SendKeys("JEKA_TEST");
            driver.FindElement(By.Id("password")).SendKeys("JEKA_TEST");
            driver.FindElement(By.Name("commit")).Click();
        }
    }
}