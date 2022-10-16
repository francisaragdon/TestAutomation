using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Pages;
using TestAutomation.TestData;

namespace TestAutomation.Hooks
{
    public static class DriverClass
    {
        [BeforeScenario]
        public static void Test(String site)
        {
            try
            {
                ChromeOptions ChromeOptions = new ChromeOptions();
                ChromeOptions.AddArguments("--start-maximized");
                //ChromeOptions.AddArguments("--headless");

                BaseClass.MyDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ChromeOptions);
                BaseClass.MyDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                BaseClass.MyDriver.Navigate().GoToUrl(TestConfig.applicationURL);
                
            } catch (Exception testInitiationException)
            {
                Console.WriteLine("Failed Initiation : {0}", testInitiationException.Message);
            }
        }
        [AfterScenario]
        public static void Teardown()
        {
            BaseClass.MyDriver.Quit();
        }

        //utility
        public static void Login(string username, string password)
        {
            
            LoginPage loginPage = new LoginPage(BaseClass.MyDriver);
            BaseClass.EnterText(loginPage.loginUsername, TestConfig.testUsername);
            BaseClass.EnterText(loginPage.loginPassword, TestConfig.testPassword);
        }
      
    }
}
