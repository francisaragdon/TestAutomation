using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Pages
{
    public class RegistrationPage
    {
        public IWebDriver Webdriver { get; }

        IWebDriver driver;
        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public IWebElement regBtnEmail => driver.FindElement(By.XPath("//input[@id='email_create']"));

        //Mr
        public IWebElement regTitle => driver.FindElement(By.XPath("//div[@id='uniform-id_gender1']"));

        public IWebElement regButton => driver.FindElement(By.XPath("//button[@id='SubmitCreate']"));
        public IWebElement regFirstName => driver.FindElement(By.XPath("//input[@id='customer_firstname']"));
        public IWebElement regLastName => driver.FindElement(By.XPath("//input[@id='customer_lastname']"));
        public IWebElement regEmail => driver.FindElement(By.XPath("//input[@id='email']"));
        public IWebElement regPassword => driver.FindElement(By.XPath("//input[@id='passwd']"));
        public IWebElement regDay => driver.FindElement(By.XPath("//select[@id='days']"));
        public IWebElement regMonth => driver.FindElement(By.XPath("//select[@id='months']"));
        public IWebElement regYear => driver.FindElement(By.XPath("//select[@id='years']"));
        public IWebElement regFname => driver.FindElement(By.XPath("//input[@id='firstname']"));
        public IWebElement regLname => driver.FindElement(By.XPath("//input[@id='lastname']"));
        public IWebElement regAddress => driver.FindElement(By.XPath("//input[@id='address1']"));
        public IWebElement regCity => driver.FindElement(By.XPath("//input[@id='city']"));
        public IWebElement regState => driver.FindElement(By.XPath("//select[@id='id_state']"));
        public IWebElement regPostcode => driver.FindElement(By.XPath("//input[@id='postcode']"));
        public IWebElement regCountry => driver.FindElement(By.XPath("//select[@id='id_country']"));
        public IWebElement regMobile => driver.FindElement(By.XPath("//input[@id='phone_mobile']"));
        public IWebElement regAlias => driver.FindElement(By.XPath("//input[@id='alias']"));

        public IWebElement regFnlBtn => driver.FindElement(By.XPath("//button[@id='submitAccount']"));

        public IWebElement regPage => driver.FindElement(By.XPath("//div[@class='account_creation'][1]//*[@class='page-subheading']"));




        public void regButtonClick()
        {
            regButton.Click();
        }

        


    }
}
