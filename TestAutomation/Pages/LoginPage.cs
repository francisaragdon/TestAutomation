using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Hooks;
using TestAutomation.TestData;

namespace TestAutomation.Pages
{

    public class LoginPage
    {
        public IWebDriver Webdriver { get; }

        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // UI elemements
        public IWebElement linkLogin => driver.FindElement(By.XPath("//a[@class='login']"));
        public IWebElement loginUsername => driver.FindElement(By.XPath("//input[@id='email']"));
        public IWebElement loginPassword => driver.FindElement(By.XPath("//input[@id='passwd']"));
        public IWebElement loginUserButton => driver.FindElement(By.XPath("//button[@id='SubmitLogin']"));

        public IWebElement loginUserFirstName => driver.FindElement(By.XPath("//a[@class='account']//span[text()='"+TestConfig.userFullName+"']"));

        public void Login(string userName, string password)
        {
            LoginPage loginPage = new LoginPage(BaseClass.MyDriver);
            loginUsername.SendKeys(userName);
            loginPassword.SendKeys(password);
            BaseClass.ClickButton(loginPage.loginUserButton);
        }
    }
}
