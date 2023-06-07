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
    public class AccountPage : CommonPage
    {
        public AccountPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS


        private IWebElement btnMyAccountTopMenu
        {
            get { return WebDriver.FindElementByXPath("//i[@class='fa fa-user']"); }
        }
        private IWebElement btnLogOut
        {
            get { return WebDriver.FindElementByXPath("//ul//a[text()='Logout']"); }
        }
        private IWebElement btnHomePageLogo
        {
            get { return WebDriver.FindElementByXPath("//div[@id='logo']//a"); }
        }


        

        //FUNCTIONS


        public AccountPage LogOutClick()
        {
            btnMyAccountTopMenu.Click();
            btnLogOut.Click();
            return this;
        }

        public AccountPage ReturnHome() 
        {
            btnHomePageLogo.Click();
            return this;
        }
    }
}
