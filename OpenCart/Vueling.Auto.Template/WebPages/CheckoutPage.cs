using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCart.Auto.Template.WebPages.Base;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.Common;
using OpenQA.Selenium.Support.UI;

namespace OpenCart.Auto.Template.WebPages
{
    public class CheckoutPage : CommonPage
    {
        public CheckoutPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS


        private By inputFirstName
        {
            get { return By.Id("input-payment-firstname"); }
        }
        private IWebElement _inputFirstName
        {
            get { return WebDriver.FindElement(inputFirstName); }
        }
        private IWebElement inputLastName
        {
            get { return WebDriver.FindElementById("input-payment-lastname"); }
        }
        private IWebElement inputAddress
        {
            get { return WebDriver.FindElementById("input-payment-address-1"); }
        }
        private IWebElement inputCity
        {
            get { return WebDriver.FindElementById("input-payment-city"); }
        }
        private IWebElement inputPostalCode
        {
            get { return WebDriver.FindElementById("input-payment-postcode"); }
        }
        private IWebElement selectRegion
        {
            get { return WebDriver.FindElementById("input-payment-zone"); }
        }
        private IWebElement selectFirstRegion
        {
            get { return WebDriver.FindElementByXPath("//select[@id='input-payment-zone']/option[2]"); }
        }
        private IWebElement btnContinuePayment
        {
            get { return WebDriver.FindElementByXPath("//div[@class='pull-right']/input"); }
        }
        private By btnContinueDeliveryDetails
        {
            get { return By.Id("button-shipping-address"); }
        }
        private IWebElement _btnContinueDeliveryDetails
        {
            get { return WebDriver.FindElement(btnContinueDeliveryDetails); }
        }
        private By btnContinueDeliveryMethod
        {
            get { return By.Id("button-shipping-method"); }
        }
        private IWebElement _btnContinueDeliveryMethod
        {
            get { return WebDriver.FindElement(btnContinueDeliveryMethod); }
        }
        private By btnContinuePaymentMethod
        {
            get { return By.Id("button-payment-method"); }
        }
        private IWebElement checkboxPrivacy
        {
            get { return WebDriver.FindElementByName("agree"); }
        }
        private IWebElement _btnContinuePaymentMethod
        {
            get { return WebDriver.FindElement(btnContinuePaymentMethod); }
        }
        private By btnConfirmOrder
        {
            get { return By.Id("button-confirm"); }
        }
        private IWebElement _btnConfirmOrder
        {
            get { return WebDriver.FindElement(btnConfirmOrder); }
        }

        //FUNCTIONS


        public CheckoutPage FillBillingFormAndContinue(
            string firstName,
            string lastName,
            string address,
            string city,
            string postalCode
        ){
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(inputFirstName));
            _inputFirstName.SendKeys(firstName);
            inputLastName.SendKeys(lastName);
            inputAddress.SendKeys(address);
            inputCity.SendKeys(city);
            inputPostalCode.SendKeys(postalCode);
            selectRegion.Click();
            selectFirstRegion.Click();
            btnContinuePayment.Click();
            return this;
        }

        public CheckoutPage DeliveryDetailsAndContinue()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(btnContinueDeliveryDetails));
            _btnContinueDeliveryDetails.Click();
            return this;
        }
        
        public CheckoutPage DeliveryMethodAndContinue()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(btnContinueDeliveryMethod));
            _btnContinueDeliveryMethod.Click();
            return this;
        }
        public CheckoutPage PaymentMethodAndContinue()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(btnContinuePaymentMethod));
            checkboxPrivacy.Click();
            _btnContinuePaymentMethod.Click();
            return this;
        }
        
        public CheckoutPage ConfirmOrder()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(btnConfirmOrder));
            _btnConfirmOrder.Click();
            return this;
        }

    }
}
