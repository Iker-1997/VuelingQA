using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCart.Auto.Template.WebPages.Base;
using OpenCart.Auto.Template.SetUp;

namespace OpenCart.Auto.Template.WebPages
{
    public class RegisterPage : CommonPage
    {
        public RegisterPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS

        private IWebElement inputFirstName
        {
            get { return WebDriver.FindElementById("input-firstname"); }
        }
        private IWebElement inputLastName
        {
            get { return WebDriver.FindElementById("input-lastname"); }
        }
        private IWebElement inputEmail
        {
            get { return WebDriver.FindElementById("input-email"); }
        }
        private IWebElement inputTelephone
        {
            get { return WebDriver.FindElementById("input-telephone"); }
        }
        private IWebElement inputPassword
        {
            get { return WebDriver.FindElementById("input-password"); }
        }
        private IWebElement inputConfirmPassword
        {
            get { return WebDriver.FindElementById("input-confirm"); }
        }
        private IWebElement checkboxPrivacyPolicy
        {
            get { return WebDriver.FindElementByXPath("//input[@name='agree']"); }
        }
        private IWebElement btnContinue
        {
            get { return WebDriver.FindElementByXPath("//input[@value='Continue']"); }
        }



        //FUNCTIONS

        public RegisterPage FillRegister(string firstName, string lastName, string email, int telephone, string pass)
        {
            inputFirstName.SendKeys(firstName);
            inputLastName.SendKeys(lastName);
            inputEmail.SendKeys(email);
            inputTelephone.SendKeys(telephone.ToString());
            inputPassword.SendKeys(pass);
            inputConfirmPassword.SendKeys(pass);
            return this;
        }

        public RegisterPage ConfirmRegister()
        {
            checkboxPrivacyPolicy.Click();
            btnContinue.Click();
            return this;
        }
    }
}
