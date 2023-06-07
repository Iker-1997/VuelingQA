using NUnit.Framework;
using OpenCart.Auto.Template.Tests;
using OpenCart.Auto.Template.Common;
using OpenCart.Auto.Template.WebPages;
using OpenCart.Auto.Template.WebPages.Base;
using OpenCart.Auto.Template.SetUp;

namespace OpenCart.Auto.Template.Tests
{
    [TestFixture]

    class UserTests : TestSetCleanBase
    {

        string fisrtName = Helpers.GenerateFirstName(4);
        string lastName = Helpers.GenerateLastName(6);
        string email = Helpers.GetRandomString(8) + "@test.com";
        int telephone = Helpers.GetRandomPhoneNumber();
        string password = Helpers.GetRandomString(8);

        [TestCase, Order(1)]

        public void RegisterUser()
        {
            homePage = new HomePage(setUpWebDriver);
            registerPage = new RegisterPage(setUpWebDriver);
            successPage = new SuccessPage(setUpWebDriver);
            accountPage = new AccountPage(setUpWebDriver);
            logoutPage = new LogoutPage(setUpWebDriver);

            homePage.clickRegister();
            registerPage.FillRegister(fisrtName, lastName, email, telephone, password);
            registerPage.ConfirmRegister();
            successPage.ConfirmSuccess();
            accountPage.LogOutClick();
            logoutPage.ConfirmLogout();

        }


        [TestCase, Order(2)]

        public void LoginUser()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            accountPage = new AccountPage(setUpWebDriver);
            logoutPage = new LogoutPage(setUpWebDriver);

            homePage.clickLogin();
            loginPage.FillLoginForm(email, password);
            loginPage.ClickLogin();
            accountPage.LogOutClick();
            logoutPage.ConfirmLogout();


        }

    }
}