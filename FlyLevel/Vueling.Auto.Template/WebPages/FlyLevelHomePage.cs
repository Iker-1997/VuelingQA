using OpenQA.Selenium;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Flylevel.Auto.SetUp;
using Flylevel.Auto.WebPages.Base;
using System.Threading;
using Flylevel.Auto.Common;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using System.Globalization;
//using Flylevel.Auto.Webpages;

namespace Flylevel.Auto.WebPages
{
    public class FlyLevelHomePage : CommonPage
    {
        public FlyLevelHomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //ELEMENTS

        private IWebElement btnOrigin
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='origin']"); }
        }

        private IWebElement inputOrigin
        {
            get { return WebDriver.FindElementByXPath("(//input[@class='input-value'])[1]"); }
        }

        private IWebElement btnCityOrigin(string origin)
        {
            return WebDriver.FindElementByXPath("//div[@class='city' and text()='" + origin + "']");
        }

        private IWebElement inputDestination
        {
            get { return WebDriver.FindElementByXPath("(//input[@class='input-value'])[2]"); }
        }

        private IWebElement btnCityDestination(string destination)
        {
            return WebDriver.FindElementByXPath("(//div[@class='city' and text()='" + destination + "'])[2]");
        }

        private IWebElement dateDepartureDay(string departureDay)
        {
            return WebDriver.FindElementByXPath("(//div[@class='day' and text()='" + departureDay + "'])[1]");
        }

        private IWebElement dateReturnDay(string returnDay)
        {
            return WebDriver.FindElementByXPath("(//div[@class='day' and text()='" + returnDay + "'])[1]");
        }

        private IWebElement btnPasssengerOk
        {
            get { return WebDriver.FindElementByClassName("btn-pax"); }
        }

        private IWebElement btnSendInfo
        {
            get { return WebDriver.FindElementById("searcher_submit_buttons"); }
        }

        private IWebElement firstCalendarMonth
        {
            get { return WebDriver.FindElementByXPath("//div[@class='datepicker__months']/section[1]//span[@class='month']"); }
        }

        private IWebElement btnNextMonth
        {
            get { return WebDriver.FindElementByClassName("datepicker__next-action"); }
        }

        private IWebElement firstDayAvailable
        {
            get { return WebDriver.FindElementByXPath("((//div[@class='datepicker__months']/section[1]//div[@class='datepicker__day is-available '])[1])"); }
        }

        private IWebElement startTripDay
        {
            get { return WebDriver.FindElementByXPath("//div[@class='datepicker__day is-available is-start-date is-in-range is-end-date']"); }
            // La clase is-end-date es obligatorio ponerla porque al haber clickado en el mismo dia antes, el raton se queda encima de
            // el mismo elemento y lo detecta como si quisieramos seleccionar como end-date.
        }

        private IWebElement dateReturnXDaysMore(IWebElement initialDay, int daysMore)
        {
            string initialDayDataTime = initialDay.GetAttribute("data-time");
            long initialDayInt = long.Parse(initialDayDataTime);
            long daysMoreMili = daysMore * 24 * 60 * 60 * 1000;
            long expectedDayMili = initialDayInt + daysMoreMili;
            return WebDriver.FindElementByXPath("//div[@data-time='" + expectedDayMili + "']");
        }

        private IWebElement adultNumbers
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='adult']//div[@class='pax-count js-pax-count']"); }
        }

        private IWebElement btnMoreAdults
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='adult']//div[@class='js-plus']"); }
        }
        private IWebElement childNumbers
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='child']//div[@class='pax-count js-pax-count']"); }
        }

        private IWebElement btnMoreChilds
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='child']//div[@class='js-plus']"); }
        }
        private IWebElement infantNumbers
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='infant']//div[@class='pax-count js-pax-count']"); }
        }

        private IWebElement btnMoreInfants
        {
            get { return WebDriver.FindElementByXPath("//div[@data-field='infant']//div[@class='js-plus']"); }
        }


        //FUNCTIONS


        public FlyLevelHomePage addOrigin(string origin)
        {
            WebDriver.FindElement(By.Id("ensCloseBanner")).Click();
            btnOrigin.Click();
            inputOrigin.SendKeys(origin);
            btnCityOrigin(origin).Click();
            return this;
        }

        public FlyLevelHomePage addDestination(string destination)
        {
            inputDestination.SendKeys(destination);
            btnCityDestination(destination).Click();
            return this;
        }

        public FlyLevelHomePage addTripDays(string departureDay, string returnDay)
        {
            dateDepartureDay(departureDay).Click();
            dateReturnDay(returnDay).Click();
            return this;
        }

        public FlyLevelHomePage addTripDaysDataTime(string month, int daysMore)
        {
            while (firstCalendarMonth.Text != month)
            {
                btnNextMonth.Click();
            }
            firstDayAvailable.Click();
            dateReturnXDaysMore(startTripDay, daysMore).Click();
            return this;
        }

        public FlyLevelHomePage addPassengers(int numberOfAdults, int numberOfChilds, int numberOfInfants)
        {
            string adults = numberOfAdults.ToString();
            while (adultNumbers.Text != adults)
            {
                btnMoreAdults.Click();
            }
            string childs = numberOfChilds.ToString();
            while (childNumbers.Text != childs)
            {
                btnMoreChilds.Click();
            }
            string infants = numberOfInfants.ToString();
            while (infantNumbers.Text != infants)
            {
                btnMoreInfants.Click();
            }
            btnPasssengerOk.Click();
            return this;
        }

        public FlyLevelHomePage sendFlightInfo()
        {
            btnSendInfo.Click();
            return this;
        }
    }
}