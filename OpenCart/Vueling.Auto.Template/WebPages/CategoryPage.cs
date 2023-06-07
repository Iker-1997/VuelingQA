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
    public class CategoryPage : CommonPage
    {
        public CategoryPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS


        private IWebElement btnFirstItemAddToCart
        {
            get { return WebDriver.FindElementByXPath("(//div[@class='product-thumb']//i[@class='fa fa-shopping-cart'])[1]"); }
        }

        private IWebElement btnCheckout
        {
            get { return WebDriver.FindElementByXPath("//a[@title='Checkout']"); }
        }
        

        //FUNCTIONS


        public CategoryPage AddToCartFirstItem()
        {
            btnFirstItemAddToCart.Click();
            return this;
        }

        public CategoryPage OpenCheckout()
        {
            btnCheckout.Click();
            return this;

        }

    }
}
