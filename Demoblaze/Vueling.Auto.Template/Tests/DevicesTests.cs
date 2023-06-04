//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
//using NUnit.Framework.Interfaces;
//using System;
//using System.IO;
//using System.Threading;
//using Demoblaze.Auto.SetUp;
//using Demoblaze.Auto.Webpages;
//using Demoblaze.Auto.WebPages.Base;
using Demoblaze.Auto.WebPages;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Demoblaze.Auto.Tests
{
    [TestFixture]
    class DevicesTests : TestSetCleanBase
    {
        [TestCase, Order(1)]

        public void FillContactForm()
        {
            homePage = new HomePage(setUpWebDriver);

            homePage.ClickContact();
            homePage.FillAndSubmitContactForm();
        }


        [TestCase, Order(2)]

        public void PurchaseOneLaptop()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            itemPage = new ItemPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.clickLogin();
            loginPage.fillLogin();
            string laptopName = "MacBook Pro";
            homePage.clickLaptop(laptopName);
            Assert.AreEqual(laptopName, itemPage.getItemName(laptopName), "This is the laptop you're finding.");
            itemPage.clickAddToCart();
            itemPage.clickCart();
            Assert.AreEqual(laptopName, cartPage.getItemNameInCart(laptopName), "This is the laptop you're finding.");
            Assert.AreEqual(cartPage.getItemPriceInCart(laptopName), cartPage.getTotalAmount(), "The price is correct.");
            cartPage.clickPlaceOrder();
            cartPage.fillPaymentForm();
            Thread.Sleep(500); //I we don't wait, it doesn't remove the item purchased and go to the HomePage.
            cartPage.confirmedPayment();
            homePage.clickLogout();
        }


        [TestCase, Order(3)]

        public void PurchaseOnePhone()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            itemPage = new ItemPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);


            homePage.clickLogin();
            loginPage.fillLogin();
            string phoneName = "Iphone 6 32gb";
            homePage.clickLaptop(phoneName);
            Assert.AreEqual(phoneName, itemPage.getItemName(phoneName), "This is the phone you're finding.");
            itemPage.clickAddToCart();
            itemPage.clickCart();
            Assert.AreEqual(phoneName, cartPage.getItemNameInCart(phoneName), "This is the phone you're finding.");
            Assert.AreEqual(cartPage.getItemPriceInCart(phoneName), cartPage.getTotalAmount(), "The price is correct.");
            cartPage.clickPlaceOrder();
            cartPage.fillPaymentForm();
            Thread.Sleep(500); //I we don't wait, it doesn't remove the item purchased and go to the HomePage.
            cartPage.confirmedPayment();
            homePage.clickLogout();
        }

        [TestCase, Order(4)]

        public void PurchaseOneMonitor()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            itemPage = new ItemPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.clickLogin();
            loginPage.fillLogin();
            string monitorName = "Apple monitor 24";
            homePage.clickMonitor(monitorName);
            Assert.AreEqual(monitorName, itemPage.getItemName(monitorName), "This is the monitor you're finding.");
            itemPage.clickAddToCart();
            itemPage.clickCart();
            Assert.AreEqual(monitorName, cartPage.getItemNameInCart(monitorName), "This is the monitor you're finding.");
            Assert.AreEqual(cartPage.getItemPriceInCart(monitorName), cartPage.getTotalAmount(), "The price is correct.");
            cartPage.clickPlaceOrder();
            cartPage.fillPaymentForm();
            Thread.Sleep(500); //I we don't wait, it doesn't remove the item purchased and go to the HomePage.
            cartPage.confirmedPayment();
            homePage.clickLogout();
        }


        [TestCase, Order(5)]

        public void TwoItemsAddedToCartExists()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            itemPage = new ItemPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);


            homePage.clickLogin();
            loginPage.fillLogin();
            string monitorName = "Apple monitor 24";
            homePage.clickMonitor(monitorName);
            Assert.AreEqual(monitorName, itemPage.getItemName(monitorName), "This is the phone you're finding.");
            itemPage.clickAddToCart();
            itemPage.clickHome();
            string laptopName = "MacBook Pro";
            homePage.clickLaptop(laptopName);
            Assert.AreEqual(laptopName, itemPage.getItemName(laptopName), "This is the laptop you're finding.");
            itemPage.clickAddToCart();
            itemPage.clickCart();
            string[] itemsName = new string[] { monitorName, laptopName };
            Assert.AreEqual(itemsName, cartPage.getMultipleItemNameInCart(itemsName), "These are the items you were finding.");
            cartPage.clickLogout();
        }


        [TestCase, Order(6)]

        public void DeleteItemsInCart()
        {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LoginPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.clickLogin();
            loginPage.fillLogin();
            homePage.clickCart();
            string monitorName = "Apple monitor 24";
            string laptopName = "MacBook Pro";
            string[] itemsName = new string[] { monitorName, laptopName };
            Assert.AreEqual(itemsName, cartPage.getMultipleItemNameInCart(itemsName), "These are the items you were finding.");
            cartPage.clickDelete(monitorName);
            cartPage.clickDelete(laptopName);
            cartPage.clickLogout();
        }
    }
}