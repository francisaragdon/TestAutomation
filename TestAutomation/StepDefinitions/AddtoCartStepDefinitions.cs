using System;
using TechTalk.SpecFlow;
using TestAutomation.Hooks;
using TestAutomation.Pages;
using TestAutomation.TestData;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public class AddtoCartStepDefinitions
    {
/*        [BeforeScenario]
        public void beforeScenario()
        {
            Console.WriteLine("Before Scenario");
            try
            {
                DriverClass.Test(TestConfig.applicationURL);

            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not load the application", E.Message);
            }
        }*/


        [Given(@"User is in the product details page")]
        public void GivenUserIsInTheProductDetailsPage()
        {
            DriverClass.Test(TestConfig.applicationURL);
            LoginPage lp = new LoginPage(BaseClass.MyDriver);
            lp.Login(TestConfig.newUserEmail, TestConfig.password);
            BaseClass.MyDriver.Navigate().GoToUrl(TestConfig.productDetailPage);

            //assert if product is visible
            /*            TestConfig tc = new TestConfig();
                        DriverClass.Login(TestConfig.testUsername, TestConfig.testPassword);
                        DriverClass.Test(TestConfig.productDetailPage);*/
        }

        [When(@"User clicks on add to cart")]
        public void WhenUserClicksOnAddToCart()
        {
            ProductDetailPage productDetailPage = new ProductDetailPage(BaseClass.MyDriver);
            BaseClass.ClickButton(productDetailPage.addToCartBtn);
            AssertClass.IsElementPresent(productDetailPage.checkoutBtn);
            BaseClass.ClickButton(productDetailPage.checkoutBtn);
        }

        [Then(@"product is added to cart")]
        public void ThenProductIsAddedToCart()
        {
            ProductDetailPage productDetailPage = new ProductDetailPage(BaseClass.MyDriver);
            AssertClass.AssertElementIsPresent(productDetailPage.checkoutTotalProductCounter);
            AssertClass.ContainsText(productDetailPage.checkoutCartName, TestConfig.normalProduct);
            DriverClass.Teardown();
        }
    }
}
