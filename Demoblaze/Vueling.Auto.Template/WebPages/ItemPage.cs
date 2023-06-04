using Demoblaze.Auto.SetUp;
using Demoblaze.Auto.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demoblaze.Auto.WebPages
{
    public class ItemPage : CommonPage
    {
        public ItemPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS

        private IWebElement itemNameElement(string itemName)
        {   
            return WebDriver.FindElementByXPath("//h2[text()='" + itemName + "']");
        }
        private IWebElement btnAddToCart
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Add to cart']"); }
        }
        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }
        private IWebElement btnHome
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Home ']"); }
        }


        //FUNCTIONS

        public string getItemName(string itemName)
        {
            string itemNameText = itemNameElement(itemName).Text;
            return itemNameText;
        }
        public ItemPage clickAddToCart()
        {
            btnAddToCart.Click();
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();
            return this;
        }
        public ItemPage clickCart()
        {
            btnCart.Click();
            return this;
        }

        public ItemPage clickHome()
        {
            btnHome.Click();
            return this;
        }
    }
}