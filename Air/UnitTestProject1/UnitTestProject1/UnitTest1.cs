using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using System.Threading;
using System.Diagnostics;


namespace Lab_4__UnitTest_
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;
        [AssemblyInitialize]
        public static void Instance(TestContext context)
        {
            OperaOptions options = new OperaOptions();
            options.BinaryLocation = @"C:\Program Files\Opera\49.0.2725.64\opera.exe";
            driver = new OperaDriver("F:\\UnitTestProject1", options);
        }


        [TestMethod]
        public void Change_language()
        {
            Language.Instance();
            Language.URL();
            Language.Change();
        }
        
        [TestMethod]
        public void Registration_with_error()
        {
            Registration.Instance();
            Registration.URL();
            Registration.Registration_error();
                    }

        [TestMethod]
        public void Registration_OK()
        {
            Registration.Instance();
            Registration.URL();
            Registration.Registration_all();

        }
        
        [TestMethod]
        public void Log_in()
        {
            Log.Instance();
            Log.URL();
            Log.Log_in_OK();

        }

        [TestMethod]
        public void Log_in_error_name()
        {
            Log.Instance();
            Log.URL();
            Log.Log_in_error();
        }
        
        [TestMethod]
        public void One_way_flight()
        {
            One_way.Instance();
            One_way.URL();
            One_way.One_way_OK();
            
        }

        [TestMethod]
        public void One_way_flight_error_with_data()
        {
            One_way.Instance();
            One_way.URL();
            One_way.One_way_With_error();

        }
        
        [TestMethod]
        public void Two_way_flight_error_with_data_not_found()
        {
            Two_way.Instance();
            Two_way.URL();
            Two_way.Two_way_Error();
            
        }

        [TestMethod]
        public void Two_way_flight()
        {
            Two_way.Instance();
            Two_way.URL();
            Two_way.Two_way_OK();
        }

        [TestMethod]
        public void Two_way_flight_error_with_data_not_found2()
        {
            Two_way.Instance();
            Two_way.URL();
            Two_way.Two_way_Error2();
        }

        [TestMethod]
        public void Two_way_flight_not_found_adults()
        {
            Two_way.Instance();
            Two_way.URL();
            Two_way.Two_way_not_found();
        }
        
        [TestMethod]
        public void Search()
        {
            Searching.Instance();
            Searching.URL();
            Searching.Search();

        }

        [TestMethod]
        public void Search_with_error()
        {
            Searching.Instance();
            Searching.URL();
            Searching.Search_error();

        }

        [TestMethod]
        public void View_the_status_of_the_flight()
        {
            View_the_status.Instance();
            View_the_status.URL();
            View_the_status.View_the_status_OK();
        }

        [TestMethod]
        public void View_the_status_of_a_non_existent_flight()
        {
            View_the_status.Instance();
            View_the_status.URL();
            View_the_status.View_the_status_error();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
            driver = null;
            foreach (var process in Process.GetProcessesByName("operadriver"))
            {
                process.Kill();
            }
        }


    }
}