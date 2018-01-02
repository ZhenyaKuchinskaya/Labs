using OpenQA.Selenium.Opera;
using OpenQA.Selenium;
using System.Threading;

namespace Lab_4__UnitTest_
{
    class Registration
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

        public static void Registration_error()
        {
            driver.FindElement(By.ClassName("registerPosition")).Click();
            IWebElement q1 = driver.FindElement(By.Id("email"));
            q1.SendKeys("zhenya_247@mail.ru");
            IWebElement q2 = driver.FindElement(By.Id("confirm-email"));
            q2.SendKeys("evgeniakucinskaya@gmail.com");
            IWebElement q3 = driver.FindElement(By.Id("pass"));
            q3.SendKeys("qwerty123");
            IWebElement q4 = driver.FindElement(By.Id("confirm-password"));
            q4.SendKeys("qwerty123");
            driver.FindElement(By.Id("submitButton")).Click();

        }

        public static void Registration_all()
        {
            driver.FindElement(By.ClassName("registerPosition")).Click();
            IWebElement q1 = driver.FindElement(By.Id("email"));
            q1.SendKeys("zhenya_247@mail.ru");
            IWebElement q2 = driver.FindElement(By.Id("confirm-email"));
            q2.SendKeys("zhenya_247@mail.ru");
            IWebElement q3 = driver.FindElement(By.Id("pass"));
            q3.SendKeys("qwerty123");
            IWebElement q4 = driver.FindElement(By.Id("confirm-password"));
            q4.SendKeys("qwerty123");
            IWebElement op22 = driver.FindElement(By.Id("title"));
            op22.SendKeys("Enter");
            op22.SendKeys(Keys.ArrowDown);
            op22.SendKeys(Keys.ArrowDown);
            op22.SendKeys(Keys.ArrowDown);
            Thread.Sleep(1000);
            IWebElement q5 = driver.FindElement(By.Id("first-name"));
            q5.SendKeys("Evgeniya");
            q5.SendKeys(Keys.Enter);
            IWebElement q6 = driver.FindElement(By.Id("family-name"));
            q6.SendKeys("Kychinskaya");
            q6.SendKeys(Keys.Enter);
            IWebElement q7 = driver.FindElement(By.Id("homeaddress1"));
            q7.SendKeys("Bobryiskaia 25");
            q7.SendKeys(Keys.Enter);
            IWebElement q8 = driver.FindElement(By.Id("homeaddress2"));
            q8.SendKeys("Barukina 86");
            q8.SendKeys(Keys.Enter);
            IWebElement q9 = driver.FindElement(By.Id("homecity"));
            q9.SendKeys("Minsk");
            q9.SendKeys(Keys.Enter);
            IWebElement q10 = driver.FindElement(By.Id("birthday"));
            q10.SendKeys("Enter");
            q10.SendKeys(Keys.ArrowDown);
            q10.SendKeys(Keys.ArrowDown); q10.SendKeys(Keys.ArrowDown);
            IWebElement q11 = driver.FindElement(By.Id("birthmonth"));
            q11.SendKeys("Enter");
            q11.SendKeys(Keys.ArrowDown);
            q11.SendKeys(Keys.ArrowDown);
            q11.SendKeys(Keys.ArrowDown);
            q11.SendKeys(Keys.ArrowDown); q11.SendKeys("Enter");
            IWebElement q12 = driver.FindElement(By.Id("birthyear"));
            q12.SendKeys("Enter");
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown);
            q12.SendKeys(Keys.ArrowDown); q12.SendKeys(Keys.ArrowDown);
            IWebElement q13 = driver.FindElement(By.Id("pref_language"));
            q13.SendKeys("Enter");
            q13.SendKeys(Keys.ArrowDown);
            q13.SendKeys(Keys.ArrowDown);
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[@id='form-ffFlag']/div/label[2]/span")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[@id='mfErrorID1']/span/span[2]")).Click();
            driver.FindElement(By.Id("submitButton")).Click();
        }

    }
}

 
