using NUnit.Framework;
using OpenCart.Auto.Template.Tests;
using OpenCart.Auto.Template.Common;
using OpenCart.Auto.Template.WebPages;
using OpenCart.Auto.Template.WebPages.Base;
using OpenCart.Auto.Template.SetUp;

namespace OpenCart.Auto.Template.Tests
{
    [TestFixture]

    class FlowTests : TestSetCleanBase
    {

        string firstName = Helpers.GenerateFirstName(4);
        string lastName = Helpers.GenerateLastName(6);
        string email = Helpers.GetRandomString(8) + "@test.com";
        int telephone = Helpers.GetRandomPhoneNumber();
        string password = Helpers.GetRandomString(8);
        string address = Helpers.GetRandomString(16);
        string city = Helpers.GetRandomString(10);
        string postalCode = Helpers.GetRandomNumberBetween(10000, 99999).ToString();

        [TestCase]

        public void BuyTablet()
        {
            homePage = new HomePage(setUpWebDriver);
            registerPage = new RegisterPage(setUpWebDriver);
            successPage = new SuccessPage(setUpWebDriver);
            accountPage = new AccountPage(setUpWebDriver);
            categoryPage = new CategoryPage(setUpWebDriver);
            checkoutPage = new CheckoutPage(setUpWebDriver);

            homePage.clickRegister();
            registerPage.FillRegister(firstName, lastName, email, telephone, password);
            registerPage.ConfirmRegister();
            successPage.ConfirmSuccess();
            accountPage.ReturnHome();
            homePage.clickTablets();
            categoryPage.AddToCartFirstItem();
            categoryPage.OpenCheckout();
            checkoutPage.FillBillingFormAndContinue(firstName, lastName, address, city, postalCode);
            checkoutPage.DeliveryDetailsAndContinue();
            checkoutPage.DeliveryMethodAndContinue();
            checkoutPage.PaymentMethodAndContinue();
            checkoutPage.ConfirmOrder();
            successPage.ConfirmSuccess();

        }

    }
}