using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class DynamicElementsTest : UIFramework
    {
        DynamicElementsPage dynamicElementsPage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public DynamicElementsTest()
        {
            dynamicElementsPage = new DynamicElementsPage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void TestDynamicElements_DynamicId()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/dynamic-properties");            

            string originalId = dynamicElementsPage.TextWithRandomIdLabel.GetAttributeValue("id");

            uiBrowser.Refresh();

            string newId = dynamicElementsPage.TextWithRandomIdLabel.GetAttributeValue("id");

            Assert.AreNotEqual(originalId, newId);
        }

        [TestMethod]
        public void TestDynamicElements_ColourChange()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/dynamic-properties");

            string elementColorBefore = dynamicElementsPage.ColorChangeButton.GetCSSPropertyValue("color");
            Assert.AreEqual("rgba(255, 255, 255, 1)", elementColorBefore);

            Thread.Sleep(5000);

            string elementColorAfter = dynamicElementsPage.ColorChangeButton.GetCSSPropertyValue("color");
            Assert.AreEqual("rgba(220, 53, 69, 1)", elementColorAfter);
        }

    }
}
