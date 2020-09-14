using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class CheckboxesTest : UIFramework
    {
        CheckboxPage checkbox;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public CheckboxesTest()
        {
            checkbox = new CheckboxPage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void Checkbox_ToggleAllButtons()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.CheckboxLabel.Click();

            // Toggle all buttons
            //checkbox.ToggleButton.Click();
            //checkbox.Toggle2Button.Click();
            //checkbox.Toggle3Button.Click();
            //checkbox.Toggle4Button.Click();
            //checkbox.Toggle5Button.Click();
            //checkbox.Toggle6Button.Click();

            checkbox.AllToggleButtons.ClickAll();
            
        }

        [TestMethod]
        public void Checkbox_ExpandAndCollapse()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.CheckboxLabel.Click();

            checkbox.ExpandButton.Click();

            checkbox.CollapseButton.Click();

        }

        [TestMethod]
        public void Checkbox_Check()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.CheckboxLabel.Click();

            checkbox.HomeCheckbox.Click();

        }
    }
}
