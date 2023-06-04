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
    public class HomePage : CommonPage
    {
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS

        /*private IWebElement btnHome
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Home ']"); }
        }*/
        private IWebElement btnContact
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Contact']"); }
        }
        /*private IWebElement btnAboutUs
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'About us']"); }
        }*/
        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }
        private IWebElement btnLogIn
        {
            get { return WebDriver.FindElementById("login2"); }
        }
        /*private IWebElement btnSignUp
        {
            get { return WebDriver.FindElementById("signin2"); }
        }*/
        private IWebElement contactEmail
        {
            get { return WebDriver.FindElementById("recipient-email"); }
        }
        private IWebElement contactName
        {
            get { return WebDriver.FindElementById("recipient-name"); }
        }
        private IWebElement contactMessage
        {
            get { return WebDriver.FindElementById("message-text"); }
        }
        private IWebElement btnSendMessage
        {
            get { return WebDriver.FindElementByXPath("//button[text() = 'Send message']"); }
        }
        private By usernameLoged
        {
            get { return By.Id("nameofuser"); }
        }
        private IWebElement laptopsLink
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Laptops']"); }
        }
        private IWebElement findLaptop(string laptopName)
        {
            return WebDriver.FindElementByXPath("//a[text()='" + laptopName + "']");
        }
        private IWebElement phonesLink
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Phones']"); }
        }
        private IWebElement findPhone(string phoneName)
        {
            return WebDriver.FindElementByXPath("//a[text()='" + phoneName + "']");
        }
        private IWebElement monitorsLink
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Monitors']"); }
        }
        private IWebElement findMonitor(string monitorName)
        {
            return WebDriver.FindElementByXPath("//a[text()='" + monitorName + "']");
        }
        private IWebElement btnLogOut
        {
            get { return WebDriver.FindElementById("logout2"); }
        }
        


        //FUNCTIONS
        public HomePage ClickContact()
        {
            btnContact.Click();
            return this;
        }

        public HomePage FillAndSubmitContactForm()
        {
            contactEmail.SendKeys("test@test.com");
            contactName.SendKeys("Testerino tester");
            contactMessage.SendKeys("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dignissim scelerisque dui, quis molestie lorem dapibus vitae. Proin in libero lacinia, commodo augue quis, lobortis.");
            btnSendMessage.Click();
            return this;
        }

        public HomePage clickLogin()
        {
            btnLogIn.Click();
            return this;
        }

        public HomePage clickLaptop(string laptopName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(usernameLoged));
            laptopsLink.Click();
            findLaptop(laptopName).Click();
            return this;
        }

        public HomePage clickPhone(string phoneName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(usernameLoged));
            phonesLink.Click();
            findPhone(phoneName).Click();
            return this;
        }

        public HomePage clickMonitor(string monitorName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(usernameLoged));
            monitorsLink.Click();
            findMonitor(monitorName).Click();
            return this;
        }
        public HomePage clickLogout()
        {
            btnLogOut.Click();
            return this;
        }
        public HomePage clickCart()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(usernameLoged));
            btnCart.Click();
            return this;
        }
    }
}