//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
//using NUnit.Framework.Interfaces;
//using System;
//using System.IO;
//using System.Threading;
//using Flylevel.Auto.SetUp;
//using Flylevel.Auto.Webpages;
//using Flylevel.Auto.WebPages.Base;
using Flylevel.Auto.WebPages;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Globalization;
using System;

namespace Flylevel.Auto.Tests
{
    [TestFixture]
    class FlyLevelTests : TestSetCleanBase
    {

        [TestCase]

        public void FindFlight()
        {
            flyLevelHomePage = new FlyLevelHomePage(setUpWebDriver);
            string origin = "Barcelona";
            string destination = "Boston";
            string departureDay = "9";
            string returnDay = "16";
            int adults = 1;
            int childs = 0;
            int infants = 0;


            flyLevelHomePage.addOrigin(origin);
            flyLevelHomePage.addDestination(destination);
            flyLevelHomePage.addTripDays(departureDay, returnDay);
            flyLevelHomePage.addPassengers(adults, childs, infants);
            flyLevelHomePage.sendFlightInfo();
        }

        [TestCase]

        public void RT11DaysTest()
        {
            flyLevelHomePage = new FlyLevelHomePage(setUpWebDriver);
            string origin = "Barcelona";
            string destination = "Santiago de Chile";
            string month = "SEPTIEMBRE";
            int daysMore = 11;
            int adults = 3;
            int childs = 1;
            int infants = 1;

            flyLevelHomePage.addOrigin(origin);
            flyLevelHomePage.addDestination(destination);
            flyLevelHomePage.addTripDaysDataTime(month, daysMore);
            flyLevelHomePage.addPassengers(adults, childs, infants);
            flyLevelHomePage.sendFlightInfo();

        }
    }
}