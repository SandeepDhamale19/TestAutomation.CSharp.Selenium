using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.DriverFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class SortableTest : UIFramework
    {
        SortablePage sortablePage;
        UIBrowser uiBrowser;

        public SortableTest()
        {
            sortablePage = new SortablePage();
            uiBrowser = new UIBrowser();
        }

        [TestMethod]
        public void TestSortable_SortList()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/sortable");

            string listNumberToMove = "Three";
            string listPositionToMove = "One";

            DriverSession.StoreSessionData("ListNumber", listPositionToMove);

            var sortableListPorperties = sortablePage.SortableList.GetlElementProperties();
            var locator = sortableListPorperties["Locator"];
            var locatorType = sortableListPorperties["LocatorType"];

            DriverSession.StoreSessionData("ListNumber", listNumberToMove);
            sortablePage.SortableList.DragAndDropRelease(locator , locatorType);
        }

        [TestMethod]
        public void TestSortable_SortGrid()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/sortable");

            sortablePage.GridTab.Click();

            string listNumberToMove = "Three";
            string listPositionToMove = "One";

            DriverSession.StoreSessionData("ListNumber", listPositionToMove);

            var sortableListPorperties = sortablePage.SortableGrid.GetlElementProperties();
            var xPosition = sortableListPorperties["XLocation"];
            var yPosition = sortableListPorperties["YLocation"];

            DriverSession.StoreSessionData("ListNumber", listNumberToMove);
            sortablePage.SortableGrid.DragAndDropToOffset(xPosition, yPosition);
        }
    }
}
