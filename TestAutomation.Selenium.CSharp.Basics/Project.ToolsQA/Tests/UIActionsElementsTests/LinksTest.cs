using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class LinksTest: UIFramework
    {
        LinkPage linkPage;
        UIBrowser uiBrowser;

        public LinksTest()
        {
            linkPage = new LinkPage();
            uiBrowser = new UIBrowser();
        }

        [TestMethod]
        public void TestLinks_SimpleClick()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/links");

            linkPage.HomeLink.Click();

            uiBrowser.SwitchToTab();
            string url = uiBrowser.GetURL();

            Assert.AreEqual("https://demoqa.com/", url);
        }

        [TestMethod]
        public void TestLinks_DynamicClick()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/links");

            linkPage.HomeGPayLink.Click();

            uiBrowser.SwitchToTab();
            string url = uiBrowser.GetURL();

            Assert.AreEqual("https://demoqa.com/", url);
        }

    }
}
