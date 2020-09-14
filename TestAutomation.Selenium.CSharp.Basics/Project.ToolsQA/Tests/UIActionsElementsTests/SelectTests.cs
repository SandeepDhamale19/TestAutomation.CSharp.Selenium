using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;
using TestAutomation.Selenium.CSharp.Basics.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class SelectTests : UIFramework
    {
        SelectPage selectPage;
        UIBrowser uiBrowser;

        public SelectTests()
        {
            selectPage = new SelectPage();
            uiBrowser = new UIBrowser();
        }

        [TestMethod]
        public void TestSelect_SelectGroupFromList()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/select-menu");

            selectPage.SelectValueInput1.SetText("Group 1");
            //var ele = UIActions.GetChildElements("//div[@id='withOptGroup']/div[2]", "XPATH"); 
            selectPage.SelectOptionList.SelectValueFromList("GROUP 1\r\nGroup 1, option 1\r\nGroup 1, option 2");
            
        }

        [TestMethod]
        public void TestSelect_SelectOne()
        {;
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/select-menu");

            selectPage.SelectValueInput2.SetText("mr");
            selectPage.SelectOneList.SelectValueFromList("PICK ONE TITLE\r\nMr.\r\nMrs.");
            
        }
    }
}
