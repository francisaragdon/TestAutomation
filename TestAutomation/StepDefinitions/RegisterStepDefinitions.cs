using System;
using TechTalk.SpecFlow;
using TestAutomation.Hooks;
using TestAutomation.Pages;
using TestAutomation.TestData;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public class RegisterStepDefinitions
    {
        [BeforeScenario]
        public void beforeScenario()
        {

        }

        [Given(@"User Navigates to the home page")]
        public void GivenUserNavigatesToTheHomePage()
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

        [When(@"User inputs <email> on register field")]
        public void WhenUserInputsEmailOnRegisterField()
        {
            RegistrationPage registrationPage = new RegistrationPage(BaseClass.MyDriver);
            BaseClass.EnterText(registrationPage.regBtnEmail, TestConfig.newUserEmail);
            BaseClass.ClickButton(registrationPage.regButton);
   
            Console.WriteLine("clicked create an account");
        }

        [When(@"User fills up required fields")]
        public void WhenUserFillsUpRequiredFields()
        {
            RegistrationPage registrationPage = new RegistrationPage(BaseClass.MyDriver);
            BaseClass.ClickButton(registrationPage.regTitle);
            BaseClass.EnterText(registrationPage.regFirstName, TestConfig.firstName);
            BaseClass.EnterText(registrationPage.regLastName, TestConfig.lastName);
            BaseClass.EnterText(registrationPage.regEmail, TestConfig.newUserEmail);
            BaseClass.EnterText(registrationPage.regPassword, TestConfig.password);
            BaseClass.SelectFromDropDownByValue(registrationPage.regDay, TestConfig.dayValue);
            BaseClass.SelectFromDropDownByValue(registrationPage.regMonth, TestConfig.monthValue);
            BaseClass.SelectFromDropDownByValue(registrationPage.regYear, TestConfig.yearValue);

            BaseClass.EnterText(registrationPage.regFname, TestConfig.firstName);
            BaseClass.EnterText(registrationPage.regLname, TestConfig.firstName);
            BaseClass.EnterText(registrationPage.regAddress, TestConfig.address);
            BaseClass.EnterText(registrationPage.regCity, TestConfig.city);
            BaseClass.SelectFromDropDownByValue(registrationPage.regState, TestConfig.stateValue);
            BaseClass.EnterText(registrationPage.regPostcode, TestConfig.postCode);
            //BaseClass.EnterText(registrationPage.regCountry, TestConfig.countryValue);
            BaseClass.EnterText(registrationPage.regMobile, TestConfig.mobilePhone);
            BaseClass.EnterText(registrationPage.regAlias, TestConfig.alias);

        }


        [Then(@"User is now registered")]
        public void ThenUserIsNowRegistered()
        {
            RegistrationPage registrationPage = new RegistrationPage(BaseClass.MyDriver);
            BaseClass.ClickButton(registrationPage.regFnlBtn);
            LoginPage loginPage = new LoginPage(BaseClass.MyDriver);
            AssertClass.ContainsText(loginPage.loginUserFirstName, TestConfig.userFullName);


        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverClass.Teardown();
        }
    }
}
