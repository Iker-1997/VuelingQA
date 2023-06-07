using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class LoginPage : CommonPage
    {
        public LoginPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS

        private IWebElement inputEmail
        {
            get { return WebDriver.FindElementById("input-email"); }
        }
        private IWebElement inputPassword
        {
            get { return WebDriver.FindElementById("input-password"); }
        }
        private IWebElement btnLogin
        {
            get { return WebDriver.FindElementByXPath("//input[@value='Login']"); }
        }



        //FUNCTIONS

        public LoginPage FillLoginForm(string email, string password)
        {
            inputEmail.SendKeys(email);
            inputPassword.SendKeys(password);
            return this;
        }

        public LoginPage ClickLogin()
        {
            btnLogin.Click();
            return this;
        }

    }
}