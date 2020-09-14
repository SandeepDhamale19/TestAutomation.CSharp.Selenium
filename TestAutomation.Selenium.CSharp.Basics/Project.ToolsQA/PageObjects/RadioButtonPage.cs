using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class RadioButtonPage
    {
        //BTN_Yes
        string yesButton = "//label[@for='yesRadio']";
        public UILabel YesButton => new UILabel(ElementProperties.SetElementName(yesButton, nameof(yesButton)), LocatorType.XPATH);

        //BTN_No
        string noButton = "//label[@for='noRadio']";
        public UILabel NoButton => new UILabel(ElementProperties.SetElementName(noButton, nameof(noButton)), LocatorType.XPATH);

        //BTN_Impressive
        string impressiveButton = "//label[@for='impressiveRadio']";
        public UILabel ImpressiveButton => new UILabel(ElementProperties.SetElementName(impressiveButton, nameof(impressiveButton)), LocatorType.XPATH);

        //LBL_DoYouLike
        string websiteFeedbackLabel = "//div[text()='Do you like the site?']";
        public UILabel WebsiteFeedbackLabel => new UILabel(ElementProperties.SetElementName(websiteFeedbackLabel, nameof(websiteFeedbackLabel)), LocatorType.XPATH);

        //LBL_SelectedOption
        string selectedOptionLabel = "//p";
        public UILabel SelectedOptionLabel => new UILabel(ElementProperties.SetElementName(selectedOptionLabel, nameof(selectedOptionLabel)), LocatorType.XPATH);
    }
}
