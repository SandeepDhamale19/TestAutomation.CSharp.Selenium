using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class RadioButtonsTest : UIFramework
    {
        RadioButtonPage radioButtonPage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public RadioButtonsTest()
        {
            radioButtonPage = new RadioButtonPage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void Radiobutton_VerifyFeedbackMessage()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.RadioButtonLabel.Click();

            string feedbackMessage = radioButtonPage.WebsiteFeedbackLabel.GetText();
            Assert.AreEqual("Do you like the site?", feedbackMessage);
        }

        [TestMethod]
        public void Radiobutton_ClickYesAndVerifyMessage()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.RadioButtonLabel.Click();

            radioButtonPage.YesButton.Click();

            string selectedOptionText = radioButtonPage.SelectedOptionLabel.GetText();
            Assert.AreEqual("You have selected Yes", selectedOptionText);

            radioButtonPage.ImpressiveButton.Click();

            selectedOptionText = radioButtonPage.SelectedOptionLabel.GetText();
            Assert.AreEqual("You have selected Impressive", selectedOptionText);

        }

        [TestMethod]
        public void Radiobutton_CheckNoButtonDisabled()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.RadioButtonLabel.Click();

            string isEnabled = radioButtonPage.NoButton.GetAttributeValue("class");
            Assert.IsTrue(isEnabled.Contains("disabled"));
        }
    }
}
