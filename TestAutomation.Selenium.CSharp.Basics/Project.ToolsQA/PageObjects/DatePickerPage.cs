using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.DriverFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class DatePickerPage
    {
        #region Date
        string selectDateLabel = "//div[contains(text(),'Select Date')]";
        public UILabel SelectDateLabel => new UILabel(ElementProperties.SetElementName(selectDateLabel, nameof(selectDateLabel)), LocatorType.XPATH);

        string datePickerMonthYearInput = "datePickerMonthYearInput";
        public UIInputText DatePickerMonthYearInput => new UIInputText(ElementProperties.SetElementName(datePickerMonthYearInput, nameof(datePickerMonthYearInput)), LocatorType.ID);

        string monthListSelect = "//select[@class='react-datepicker__month-select']";
        public UISelect MonthListSelect => new UISelect(ElementProperties.SetElementName(monthListSelect, nameof(monthListSelect)), LocatorType.XPATH);

        string yearListSelect = "//select[@class='react-datepicker__year-select']";
        public UISelect YearListSelect => new UISelect(ElementProperties.SetElementName(yearListSelect, nameof(yearListSelect)), LocatorType.XPATH);

        #endregion

        #region Date Time
        string selectDateTimeLabel = "//div[contains(text(),'Select Date')]";
        public UILabel SelectDateTimeLabel => new UILabel(ElementProperties.SetElementName(selectDateTimeLabel, nameof(selectDateTimeLabel)), LocatorType.XPATH);

        string dateAndTimePickerInput = "dateAndTimePickerInput";
        public UIInputText DateAndTimePickerInput => new UIInputText(ElementProperties.SetElementName(dateAndTimePickerInput, nameof(dateAndTimePickerInput)), LocatorType.ID);

        string monthListDateTimeSelect = "//span[@class='react-datepicker__month-read-view--selected-month']";
        public UILabel MonthListDateTimeSelect => new UILabel(ElementProperties.SetElementName(monthListDateTimeSelect, nameof(monthListDateTimeSelect)), LocatorType.XPATH); 
        
        string monthListDateTimeOption = "//div[@class='react-datepicker__month-option']";
        public UIList MonthListDateTimeOption => new UIList(ElementProperties.SetElementName(monthListDateTimeOption, nameof(monthListDateTimeOption)), LocatorType.XPATH);

        string yearListDateTimeSelect = "//span[@class='react-datepicker__year-read-view--selected-year']";
        public UILabel YearListDateTimeSelect => new UILabel(ElementProperties.SetElementName(yearListDateTimeSelect, nameof(yearListDateTimeSelect)), LocatorType.XPATH);

        string yearListDateTimeOption = "//div[@class='react-datepicker__year-option']";
        public UIList YearListDateTimeOption => new UIList(ElementProperties.SetElementName(yearListDateTimeOption, nameof(yearListDateTimeOption)), LocatorType.XPATH);
        #endregion


        string prevMonthButton = "//button[contains(text(),'Previous Month')]";
        public UILabel PrevMonthButton => new UILabel(ElementProperties.SetElementName(prevMonthButton, nameof(prevMonthButton)), LocatorType.XPATH);

        string nextMonthButton = "//button[contains(text(),'Next Month')]";
        public UILabel NextMonthButton => new UILabel(ElementProperties.SetElementName(nextMonthButton, nameof(nextMonthButton)), LocatorType.XPATH);

        string calendarTitle = "//div[@class='react-datepicker__header']/div";
        public UILabel CalendarTitle => new UILabel(ElementProperties.SetElementName(calendarTitle, nameof(calendarTitle)), LocatorType.XPATH);        


        string dayLabel = "//div[contains(text(),'[?]')]";
        public UILabel DayLabel => new UILabel(ElementProperties.SetElementName(dayLabel.Replace("[?]", DriverSession.GetSessionKeyData("day").ToString()), nameof(dayLabel)), LocatorType.XPATH);

        string dateLabel = "(//div[contains(text(),'[?]')])[1]";
        public UILabel DateLabel => new UILabel(ElementProperties.SetElementName(dateLabel.Replace("[?]", DriverSession.GetSessionKeyData("date").ToString()), nameof(dateLabel)), LocatorType.XPATH);

        string timeLabel = "//li[contains(text(),'[?]')]";
        public UILabel TimeLabel => new UILabel(ElementProperties.SetElementName(timeLabel.Replace("[?]", DriverSession.GetSessionKeyData("time").ToString()), nameof(timeLabel)), LocatorType.XPATH);

    }
}
