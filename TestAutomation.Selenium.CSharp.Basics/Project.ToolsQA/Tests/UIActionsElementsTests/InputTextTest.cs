using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class InputTextTest : UIFramework
    {
        TextboxPage textbox;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public InputTextTest()
        { 
            textbox = new TextboxPage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void Textbox_EnterText()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.TextboxLabel.Click();

            // Enter Element values
            textbox.FullNameText.SetText("Captain America");
            textbox.EmailText.SetText("Captain.America@TestAutomationServices.com");

            string address = $@"Country: USA
                                State: Alaska
                                Street: 500 W36th Ave, Suite 300";

            textbox.CurrentAddressText.SetTextArea(address);

            textbox.PermanentAddressText.SetTextArea(address);

            textbox.SubmitButton.ScrollToView();
            textbox.SubmitButton.Click();

            // Verify ELement Values
            string resultFullName = textbox.ResultFullNameLabel.GetText();
            Assert.AreEqual("Name:Captain America", resultFullName);

            string resultEmail = textbox.ResultEmailLabel.GetText();
            Assert.AreEqual("Email:Captain.America@TestAutomationServices.com", resultEmail);

            string resultCurrentAddress = textbox.ResultCurrentAddressLabel.GetAttributeValue("value");
            Assert.AreEqual($@"Country: USA
                                State: Alaska
                                Street: 500 W36th Ave, Suite 300", resultCurrentAddress);

            string resultPermanentAddress = textbox.ResultPermanentAddressLabel.GetAttributeValue("value");
            Assert.AreEqual($@"Country: USA
                                State: Alaska
                                Street: 500 W36th Ave, Suite 300", resultPermanentAddress);
        }
    }
}
