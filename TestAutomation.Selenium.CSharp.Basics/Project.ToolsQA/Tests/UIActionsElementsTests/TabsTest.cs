using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class TabsTest : UIFramework
    {
        TabsPage tabsPage;
        UIBrowser uiBrowser;

        public TabsTest()
        {
            tabsPage = new TabsPage();
            uiBrowser = new UIBrowser();
        }

        [TestMethod]
        public void Tabs_SwitchTabs()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/tabs");
            
            string whatTabText = tabsPage.WhatTabPaneLabel.GetText();

            tabsPage.OriginTabLabel.Click();
            string originTabText = tabsPage.OriginTabPaneLabel.GetText();

            tabsPage.UseTabLabel.Click();
            string useTabText = tabsPage.UseTabPaneLabel.GetText();

            // More is disabled
            //tabsPage.MoreTabLabel.Click();
            //string moreTabText = tabsPage.MoreTabPaneLabel.GetText();
        }
    }
}
