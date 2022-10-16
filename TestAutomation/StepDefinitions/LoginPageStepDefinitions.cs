using System;
using TechTalk.SpecFlow;
using TestAutomation.Hooks;
using TestAutomation.Pages;
using TestAutomation.TestData;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions
    {

        [Given(@"User navigates to application login page")]
        public void GivenUserNavigatesToApplicationLoginPage()
        {
            try
            {
                DriverClass.Test(TestConfig.applicationURL);

            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not load the application", E.Message);
            }
        }

        [When(@"User login using credentials francis@yopmail\.com and password")]
        public void WhenUserLoginUsingCredentialsFrancisYopmail_ComAndPassword()
        {
            LoginPage loginPage = new LoginPage(BaseClass.MyDriver);
            BaseClass.EnterText(loginPage.loginUsername, TestConfig.testUsername);
            BaseClass.EnterText(loginPage.loginPassword, TestConfig.testPassword);
            BaseClass.ClickButton(loginPage.loginUserButton);
        }

        [Then(@"I should sucessfully be logged in")]
        public void ThenIShouldSucessfullyBeLoggedIn()
        {
            LoginPage loginPage = new LoginPage(BaseClass.MyDriver);
            AssertClass.ContainsText(loginPage.loginUserFirstName, TestConfig.userFullName);
            DriverClass.Teardown();
        }


    }
}
