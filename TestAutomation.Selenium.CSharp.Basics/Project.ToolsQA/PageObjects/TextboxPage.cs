using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class TextboxPage
    {
        // Fullname Label
        string fullNameLabel = "//label[contains(text(),'Full Name')]";
        public UILabel FullNameLabel => new UILabel(ElementProperties.SetElementName(fullNameLabel, nameof(fullNameLabel)), LocatorType.XPATH);

        // FullNameText
        string fullNameText = "//input[@placeholder='Full Name']";
        public UIInputText FullNameText => new UIInputText(ElementProperties.SetElementName(fullNameText, nameof(fullNameText)), LocatorType.XPATH);

        // Email Label
        string emailLabel = "//label[contains(text(),'Email')]";
        public UILabel EmailLabel => new UILabel(ElementProperties.SetElementName(emailLabel, nameof(emailLabel)), LocatorType.XPATH);

        // EmailText
        string emailText = "//input[@placeholder='name@example.com']";
        public UIInputText EmailText => new UIInputText(ElementProperties.SetElementName(emailText, nameof(emailText)), LocatorType.XPATH);

        // CurrentAddressLabel
        string currentAddressLabel = "//label[contains(text(),'Current Address')]";
        public UILabel CurrentAddressLabel => new UILabel(ElementProperties.SetElementName(currentAddressLabel, nameof(currentAddressLabel)), LocatorType.XPATH);

        // CurrentAddressText;
        string currentAddressText = "//textarea[@placeholder='Current Address']";
        public UIInputTextArea CurrentAddressText => new UIInputTextArea(ElementProperties.SetElementName(currentAddressText, nameof(currentAddressText)), LocatorType.XPATH);

        // Permanent Address Label
        string permanentAddressLabel = "//label[contains(text(),'Permanent Address')]"; 
        public UILabel PermanentAddressLabel => new UILabel(ElementProperties.SetElementName(permanentAddressLabel, nameof(permanentAddressLabel)), LocatorType.XPATH);

        // PermanentAddressText
        string permanentAddressText = "permanentAddress";
        public UIInputTextArea PermanentAddressText => new UIInputTextArea(ElementProperties.SetElementName(permanentAddressText, nameof(permanentAddressText)), LocatorType.ID);

        // Submit Button
        string submitButton = "//button[contains(text(),'Submit')]";
        public UIButton SubmitButton => new UIButton(ElementProperties.SetElementName(submitButton, nameof(submitButton)), LocatorType.XPATH);

        // Result Fields
        string resultFullNameLabel = "name";
        public UILabel ResultFullNameLabel => new UILabel(ElementProperties.SetElementName(resultFullNameLabel, nameof(resultFullNameLabel)), LocatorType.ID);

        string resultEmailLabel = "email";
        public UILabel ResultEmailLabel => new UILabel(ElementProperties.SetElementName(resultEmailLabel, nameof(resultEmailLabel)), LocatorType.ID);

        string resultCurrentAddressLabel = "currentAddress";
        public UILabel ResultCurrentAddressLabel => new UILabel(ElementProperties.SetElementName(resultCurrentAddressLabel, nameof(resultCurrentAddressLabel)), LocatorType.ID);

        string resultPermanentAddressLabel = "permanentAddress";
        public UILabel ResultPermanentAddressLabel => new UILabel(ElementProperties.SetElementName(resultPermanentAddressLabel, nameof(resultPermanentAddressLabel)), LocatorType.ID);
    }
}
        