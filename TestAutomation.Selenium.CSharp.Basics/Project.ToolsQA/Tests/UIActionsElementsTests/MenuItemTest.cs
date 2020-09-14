using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class MenuItemTest : UIFramework
    {
        MenuItemsPage menuItemsPage;
        UIBrowser uiBrowser;

        public MenuItemTest()
        {
            menuItemsPage = new MenuItemsPage();
            uiBrowser = new UIBrowser();
        }

        [TestMethod]
        public void TestMenu_HoverOverAndAction()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/menu");

            menuItemsPage.MainItem2Link.HoverOver();

            Func<string> MethodGetText = new Func<string>(GetText);

            menuItemsPage.AllSubLinks.HoverOverAndAction(MethodGetText);
        }

        [TestMethod]
        public void TestMenu_HoverAllSubMenu()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/menu");

            menuItemsPage.MainItem2Link.HoverOver();

            Func<string> MethodGetText = new Func<string>(GetText);

            List<object> allResults = menuItemsPage.AllSubLinks.HoverOverAllAndAction(MethodGetText);
        }


        public string GetText()
        {
            return menuItemsPage.MainItem1Link.GetText();
        }
    }
}
