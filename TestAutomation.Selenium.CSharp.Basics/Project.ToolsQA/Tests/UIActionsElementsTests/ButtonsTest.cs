using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class ButtonsTest : UIFramework
    {
        ButtonPage buttonPage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public ButtonsTest()
        {
            buttonPage = new ButtonPage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }
        
        [TestMethod]
        public void TestButtons_DoubleClick()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/buttons");

            // Navigate to Element section
            //navigationPanelPage.ButtonsLabel.Click(); 
            
            buttonPage.DoubleClickButton.DoubleClick();
            string message = buttonPage.DoubleClickMessage.GetText();

            Assert.AreEqual("You have done a double click", message);
        }

        [TestMethod]
        public void TestButtons_RightClick()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/buttons");

            // Navigate to Element section
            //navigationPanelPage.ButtonsLabel.Click(); 
            
            buttonPage.RightClickButton.RightClick();
            string message = buttonPage.RightClickMessage.GetText();
            
            Assert.AreEqual("You have done a right click", message);
        }

        [TestMethod]
        public void TestButtons_Click()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/buttons");

            // Navigate to Element section
            //navigationPanelPage.ButtonsLabel.Click(); 
            
            buttonPage.ClickMeButton.Click();
            string message = buttonPage.DynamicClickMessage.GetText();

            Assert.AreEqual("You have done a dynamic click", message);
        }
    }
}
