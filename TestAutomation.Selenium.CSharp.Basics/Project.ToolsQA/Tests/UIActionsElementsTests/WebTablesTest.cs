using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class WebTablesTest : UIFramework
    {
        WebTablePage webTablePage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public WebTablesTest()
        {
            webTablePage = new WebTablePage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void WebTable_EditWebTableData()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.WebTableLabel.Click();

            webTablePage.BookStoreTableDeleteValues.EditWebTableData();
        }

        [TestMethod]
        public void WebTable_EditWebTableDataAndAddRegistration()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.WebTableLabel.Click();

            webTablePage.BookStoreTableEditValues.EditWebTableData();
        }

        [TestMethod]
        public void WebTable_GetWebTableData()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.WebTableLabel.Click();

            var webTableData = webTablePage.BookStoreTableDeleteValues.GetWebTableData();
        }

        [TestMethod]
        public void WebTable_AddRegistration()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/elements");

            // Navigate to Element section
            navigationPanelPage.WebTableLabel.Click();

            webTablePage.TableFirstRowEditButton.Click();

            AddRegistration();
        }

        public void AddRegistration()
        {
            webTablePage.FirstName.SetText("Captain");
            webTablePage.LastName.SetText("America");
            webTablePage.UserEmail.SetText("Captain.America@TestAutomationServices.com");
            webTablePage.Age.SetText("34");
            webTablePage.Salary.SetText("10000000");
            webTablePage.Department.SetText("Avengers");

            webTablePage.Submit.Click();
        }

    }
}
