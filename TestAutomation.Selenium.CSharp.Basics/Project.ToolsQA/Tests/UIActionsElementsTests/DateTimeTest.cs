using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.DataFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.DriverFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class DateTimeTest : UIFramework
    {
        DatePickerPage datePickerPage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public DateTimeTest()
        {
            datePickerPage = new DatePickerPage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void TestDateTime_SetDate()
        {
            int year = 2021;
            int month = 11;
            int date = 11;

            int hours = 07;
            int minutes = 15;
            int seconds = 30;
            DateTime dateTime = new DateTime(year, month, date, hours, minutes, seconds);
            DriverSession.StoreSessionData("date", date.ToString());

            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/date-picker");
            
            datePickerPage.DatePickerMonthYearInput.ClearText();

            datePickerPage.MonthListSelect.SelectByText(DateTimeFunctions.GetFullMonthName(dateTime));
            datePickerPage.YearListSelect.SelectByText(year.ToString());
            datePickerPage.DateLabel.Click();

            string selectedDate = datePickerPage.DatePickerMonthYearInput.GetTextfromTextbox();

            Assert.AreEqual(string.Format("{0:d}", dateTime), selectedDate);
        }

        [TestMethod]
        public void TestDateTime_SetDateTime()
        {
            int year = 2021;
            int month = 11;
            int date = 11;

            int hours = 07;
            int minutes = 15;
            int seconds = 30;
            DateTime dateTime = new DateTime(year, month, date, hours, minutes, seconds);
            DriverSession.StoreSessionData("date", date.ToString());
            DriverSession.StoreSessionData("time", string.Concat(hours.ToString(),":",minutes.ToString()));

            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/date-picker");

            datePickerPage.DateAndTimePickerInput.ClearText();

            datePickerPage.MonthListDateTimeSelect.Click();
            datePickerPage.MonthListDateTimeOption.SelectValueFromList(DateTimeFunctions.GetFullMonthName(dateTime));

            datePickerPage.YearListDateTimeSelect.Click();
            datePickerPage.YearListDateTimeOption.SelectValueFromList(year.ToString());

            datePickerPage.DateLabel.Click();
            datePickerPage.TimeLabel.Click();

            string selectedDate = datePickerPage.DateAndTimePickerInput.GetTextfromTextbox();

            Assert.AreEqual(string.Format("{0:MMMM d, yyyy h:mm tt}", dateTime), selectedDate);
        }
    }
}
