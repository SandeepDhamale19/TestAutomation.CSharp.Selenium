using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class NavigationPanelPage
    {
        string appLink = "//a[@href='https://demoqa.com']";
        public UILink AppLink => new UILink(appLink, LocatorType.XPATH);


        string imagesToolsqaJpgButton = "//img[@src='/images/Toolsqa.jpg']";
        public UIButton ImagesToolsqaJpgButton => new UIButton(ElementProperties.SetElementName(imagesToolsqaJpgButton, nameof(imagesToolsqaJpgButton)), LocatorType.XPATH);


        string textboxTitleLabel = "//div[contains(text(),'Text Box')]";
        public UILabel TextboxTitleLabel => new UILabel(ElementProperties.SetElementName(textboxTitleLabel, nameof(textboxTitleLabel)), LocatorType.XPATH);


        string elementsLabel = "//div[contains(text(),'Elements')]";
        public UILabel ElementsLabel => new UILabel(ElementProperties.SetElementName(elementsLabel, nameof(elementsLabel)), LocatorType.XPATH);


        string textboxLabel = "//span[contains(text(),'Text Box')]";
        public UILabel TextboxLabel => new UILabel(ElementProperties.SetElementName(textboxLabel, nameof(textboxLabel)), LocatorType.XPATH);


        string checkboxLabel = "//span[contains(text(),'Check Box')]";
        public UILabel CheckboxLabel => new UILabel(ElementProperties.SetElementName(checkboxLabel, nameof(checkboxLabel)), LocatorType.XPATH);


        string radioButtonLabel = "//span[contains(text(),'Radio Button')]";
        public UILabel RadioButtonLabel => new UILabel(ElementProperties.SetElementName(radioButtonLabel, nameof(radioButtonLabel)), LocatorType.XPATH);


        string webTableLabel = "//span[contains(text(),'Web Tables')]";
        public UILabel WebTableLabel => new UILabel(ElementProperties.SetElementName(webTableLabel, nameof(webTableLabel)), LocatorType.XPATH);


        string buttonsLabel = "//span[contains(text(),'Buttons')]";
        public UILabel ButtonsLabel => new UILabel(ElementProperties.SetElementName(buttonsLabel, nameof(buttonsLabel)), LocatorType.XPATH);


        string linksLabel = "//span[contains(text(),'Links')]";
        public UILabel LinksLabel => new UILabel(ElementProperties.SetElementName(linksLabel, nameof(linksLabel)), LocatorType.XPATH);


        string uploadAndLabel = "//span[contains(text(),'Upload and Download')]";
        public UILabel UploadAndLabel => new UILabel(ElementProperties.SetElementName(uploadAndLabel, nameof(uploadAndLabel)), LocatorType.XPATH);


        string dynamicPropertiesLabel = "//span[contains(text(),'Dynamic Properties')]";
        public UILabel DynamicPropertiesLabel => new UILabel(ElementProperties.SetElementName(dynamicPropertiesLabel, nameof(dynamicPropertiesLabel)), LocatorType.XPATH);


        string formsLabel = "//div[contains(text(),'Forms')]";
        public UILabel FormsLabel => new UILabel(ElementProperties.SetElementName(formsLabel, nameof(formsLabel)), LocatorType.XPATH);


        string alertsLabel = "//div[contains(text(),'Alerts, Frame & Windows')]";
        public UILabel AlertsLabel => new UILabel(ElementProperties.SetElementName(alertsLabel, nameof(alertsLabel)), LocatorType.XPATH);


        string widgetsLabel = "//div[contains(text(),'Widgets')]";
        public UILabel WidgetsLabel => new UILabel(ElementProperties.SetElementName(widgetsLabel, nameof(widgetsLabel)), LocatorType.XPATH);


        string interactionsLabel = "//div[contains(text(),'Interactions')]";
        public UILabel InteractionsLabel => new UILabel(ElementProperties.SetElementName(interactionsLabel, nameof(interactionsLabel)), LocatorType.XPATH);


        string bookstoreLabel = "//div[contains(text(),'Book Store Application')]";
        public UILabel BookstoreLabel => new UILabel(ElementProperties.SetElementName(bookstoreLabel, nameof(bookstoreLabel)), LocatorType.XPATH);

        string accordianLabel = "//span[contains(text(),'Accordian')]";
        public UILabel AccordianLabel => new UILabel(ElementProperties.SetElementName(accordianLabel, nameof(accordianLabel)), LocatorType.XPATH);

        string autoCompleteLabel = "//span[contains(text(),'Auto Complete')]";
        public UILabel AutoCompleteLabel => new UILabel(ElementProperties.SetElementName(autoCompleteLabel, nameof(autoCompleteLabel)), LocatorType.XPATH);

        string datePickerLabel = "//span[contains(text(),'Date Picker')]";
        public UILabel DatePickerLabel => new UILabel(ElementProperties.SetElementName(datePickerLabel, nameof(datePickerLabel)), LocatorType.XPATH);

        string sliderLabel = "//span[contains(text(),'Slider')]";
        public UILabel SliderLabel => new UILabel(ElementProperties.SetElementName(sliderLabel, nameof(sliderLabel)), LocatorType.XPATH);

        string progressBarLabel = "//span[contains(text(),'Progress Bar')]";
        public UILabel ProgressBarLabel => new UILabel(ElementProperties.SetElementName(progressBarLabel, nameof(progressBarLabel)), LocatorType.XPATH);

        string tabsLabel = "//span[contains(text(),'Tabs')]";
        public UILabel TabsLabel => new UILabel(ElementProperties.SetElementName(tabsLabel, nameof(tabsLabel)), LocatorType.XPATH);

        string toolTipsLabel = "//span[contains(text(),'Tool Tips')]";
        public UILabel ToolTipsLabel => new UILabel(ElementProperties.SetElementName(toolTipsLabel, nameof(toolTipsLabel)), LocatorType.XPATH);

        string selectMenuLabel = "//span[contains(text(),'Select Menu')]";
        public UILabel SelectMenuLabel => new UILabel(ElementProperties.SetElementName(selectMenuLabel, nameof(selectMenuLabel)), LocatorType.XPATH);

        
    }
}
