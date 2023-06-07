using OpenQA.Selenium;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using System.Threading;
using OpenCart.Auto.Template.Common;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using System.Globalization;
//using OpenCart.Auto.Webpages;

namespace OpenCart.Auto.Template.WebPages
{
    public class HomePage : CommonPage
    {
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS

        private IWebElement btnMyAccountTopMenu
        {
            get { return WebDriver.FindElementByXPath("//i[@class='fa fa-user']"); }
        }
        private IWebElement btnRegister
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Register']"); }
        }
        private IWebElement btnLogin
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Login']"); }
        }
   
        private IWebElement btnTablets
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Tablets']/.."); }
        }



        //FUNCTIONS

        public HomePage clickRegister()
        {
            btnMyAccountTopMenu.Click();
            btnRegister.Click();
            return this;
        }

        public HomePage clickLogin()
        {
            btnMyAccountTopMenu.Click();
            btnLogin.Click();
            return this;
        }

        public HomePage clickTablets()
        {

            btnTablets.Click();
            return this;
        }
    }
}

//new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsClickable(btnTablets));