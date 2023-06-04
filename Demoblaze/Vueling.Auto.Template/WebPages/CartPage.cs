using Demoblaze.Auto.Common;
using Demoblaze.Auto.SetUp;
using Demoblaze.Auto.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze.Auto.WebPages
{
    public class CartPage : CommonPage
    {
        public CartPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS

        private By firstTableRow
        {
            get { return By.ClassName("success"); }
        }
        private IWebElement itemNameInCart(string itemName)
        {
            return WebDriver.FindElementByXPath("//tr[@class='success']/td[text()='" + itemName + "']");
        }
        private string itemPriceInCartText(string itemName)
        {
            return itemNameInCart(itemName).FindElement(By.XPath("./following-sibling::*[1]")).Text;
        }
        private IWebElement totalAmount
        {
            get { return WebDriver.FindElementById("totalp"); }
        }
        private IWebElement btnPlaceOrder
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Place Order']"); }
        }
        private IWebElement paymentFormName
        {
            get { return WebDriver.FindElementById("name"); }
        }
        private IWebElement paymentFormCountry
        {
            get { return WebDriver.FindElementById("country"); }
        }
        private IWebElement paymentFormCity
        {
            get { return WebDriver.FindElementById("city"); }
        }
        private IWebElement paymentFormCreditCard
        {
            get { return WebDriver.FindElementById("card"); }
        }
        private IWebElement paymentFormMonth
        {
            get { return WebDriver.FindElementById("month"); }
        }
        private IWebElement paymentFormYear
        {
            get { return WebDriver.FindElementById("year"); }
        }
        private IWebElement btnPurchase
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Purchase']"); }
        }
        private By orderPurchasedLogo
        {
            get { return By.ClassName("sa-placeholder"); }
        }
        private IWebElement btnPurchaseConfirmedOk
        {
            get { return WebDriver.FindElementByXPath("//button[text()='OK']"); }
        }
        private IWebElement btnLogOut
        {
            get { return WebDriver.FindElementById("logout2"); }
        }
        private IWebElement btnDeleteItem(string itemName)
        {
            return WebDriver.FindElementByXPath("//tr[@class='success']/td[text()='" + itemName + "']/following-sibling::*/a");
        }



        //FUNCTIONS


        public string getItemNameInCart(string itemName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(firstTableRow));
            string itemNameText = itemNameInCart(itemName).Text;
            return itemNameText;
        }
        public string getItemPriceInCart(string itemName)
        {
            string itemPriceText = itemPriceInCartText(itemName);
            return itemPriceText;
        }
        public string getTotalAmount()
        {
            string totalAmountText = totalAmount.Text;
            return totalAmountText;
        }
        public CartPage clickPlaceOrder()
        {
            btnPlaceOrder.Click();
            return this;
        }
        public CartPage fillPaymentForm()
        {
            paymentFormName.SendKeys("Testerino");
            paymentFormCountry.SendKeys("Antigua y barbuda");
            paymentFormCity.SendKeys("Monaco");
            paymentFormCreditCard.SendKeys("123456789");
            paymentFormMonth.SendKeys("May");
            paymentFormYear.SendKeys("2023");
            btnPurchase.Click();
            return this;
        }
        public CartPage confirmedPayment()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(orderPurchasedLogo));
            btnPurchaseConfirmedOk.Click();
            return this;
        }

        public Array getMultipleItemNameInCart(string[] itemsName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(firstTableRow));
            string[] MultipleItemsName = new string[itemsName.Length];
            for (int i = 0; i < itemsName.Length; i++)
            {
                MultipleItemsName[i] = itemNameInCart(itemsName[i]).Text;
            }
            return MultipleItemsName;
        }
        public CartPage clickLogout()
        {
            btnLogOut.Click();
            return this;
        }

        public CartPage clickDelete(string itemName)
        {
            btnDeleteItem(itemName).Click();
            return this;
        }
    }
}