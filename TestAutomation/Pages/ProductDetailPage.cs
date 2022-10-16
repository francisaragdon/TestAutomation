using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.TestData;

namespace TestAutomation.Pages
{

    public class ProductDetailPage
    {
        public IWebDriver Webdriver { get; }

        IWebDriver driver;
        public ProductDetailPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // UI elemements
        public IWebElement addToCartBtn => driver.FindElement(By.XPath("//button[@class='exclusive']"));
        public IWebElement checkoutBtn => driver.FindElement(By.XPath("//a[@class='btn btn-default button button-medium']//span"));
        public IWebElement checkoutNormalProduct => driver.FindElement(By.XPath("//p[@class='product-name']//a[text()='"+TestConfig.normalProduct+ "']"));

        public IWebElement checkoutTotalProductCounter => driver.FindElement(By.XPath("//span[@id='summary_products_quantity']"));

        public IWebElement checkoutCartName => driver.FindElement(By.XPath("//td[@class='cart_description']//p[@class='product-name']"));
    }
}
