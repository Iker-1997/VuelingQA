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
    public class LogoutPage : CommonPage
    {
        public LogoutPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS


        private IWebElement btnContinue
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Continue']"); }
        }



        //FUNCTIONS


        public LogoutPage ConfirmLogout()
        {
            btnContinue.Click();
            return this;
        }
    }
}
