using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.TestData
{
    public class TestConfig
    {
        //Login - config

        public static string applicationURL = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        public static string testUsername = "francis@yopmail.com";
        public static string testPassword = "test123";
        public static string userFullName = "Francis test";

        //Registration - config

        public static string title = "Mr.";
        public static string firstName = "Francis";
        public static string lastName = "test";

        //new account email
        public static string newUserEmail = "alt.bl-0mhr41x@yopmail.com";


        public static string password = "test123";
        public static string address = "Mnl";
        public static string city = "Mnl";
        public static string state = "mnl";

        //dropdown
        public static string dayValue = "1";
        public static string monthValue = "12";
        public static string yearValue = "1997";
        //dropdown state
        public static string stateValue = "3";

        public static string postCode = "00000";

        //dropdown country
        public static string countryValue = "21";
        public static string mobilePhone = "09279015849";
        public static string alias = "test";
        //reg page header
        public static string regPageHeader = "YOUR PERSONAL INFORMATION";

        public static string checkoutBtnTxt = "Proceed to checkout";

        //AddToCart - config
        public static string productDetailPage = "http://automationpractice.com/index.php?id_product=1&controller=product";

        public static string normalProduct = "Faded Short Sleeve T-shirts";
    }
}
