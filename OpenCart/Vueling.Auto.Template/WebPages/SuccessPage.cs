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
    public class SuccessPage : CommonPage
    {
        public SuccessPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS

        private IWebElement btnContinue
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Continue']"); }
        }



        //FUNCTIONS


        public SuccessPage ConfirmSuccess()
        {
            btnContinue.Click();
            return this;
        }
    }
}
