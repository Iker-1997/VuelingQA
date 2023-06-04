using OpenQA.Selenium;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Demoblaze.Auto.SetUp;
using Demoblaze.Auto.WebPages.Base;
using System.Threading;
using Demoblaze.Auto.Common;
using OpenQA.Selenium.Support.UI;
//using Demoblaze.Auto.Webpages;

namespace Demoblaze.Auto.WebPages
{
    public class LoginPage : CommonPage
    {
        public LoginPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS


        private IWebElement logInUsername
        {
            get { return WebDriver.FindElementById("loginusername"); }
        }
        private IWebElement logInPassword
        {
            get { return WebDriver.FindElementById("loginpassword"); }
        }
        private IWebElement logInBtn
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Log in']"); }
        }


        //FUNCTIONS

        public LoginPage fillLogin()
        {
            logInUsername.SendKeys("testIker");
            logInPassword.SendKeys("testIker");
            logInBtn.Click();
            return this;
        }
    }
}