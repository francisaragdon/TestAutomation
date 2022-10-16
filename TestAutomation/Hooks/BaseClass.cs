using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestAutomation.Hooks
{
    public static class BaseClass
    {
        public static IWebDriver MyDriver { get; set; }

        public static void EnterText(this IWebElement element, string value)
        {
            element.Click();
            element.Clear();
            element.SendKeys(value);
        }

        public static void ClickLogin(this IWebElement element)
        {
            element.Click();
        }

        public static void ClickHomeRegister(this IWebElement element)
        {
            element.Click();
        }

        public static void ClickButton(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectFromDropDownByValue(IWebElement element, string inputValue)
        { 
            SelectElement se = new SelectElement(element);
            se.SelectByValue(inputValue);
        }
    }
}
