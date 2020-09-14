using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIActionsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class AutoCompleteTest : UIFramework
    {
        AutoCompletePage autoCompletePage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public AutoCompleteTest()
        {
            autoCompletePage = new AutoCompletePage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void TestAutoComplete_SelectMultiple()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/auto-complete");

            autoCompletePage.MultipleColorsInput.SetText("a");
            autoCompletePage.MutlipleColorsList.SelectValueFromList("Aqua");

            Thread.Sleep(500);
            autoCompletePage.MultipleColorsInput.SetText("b");
            Thread.Sleep(500);
            autoCompletePage.MutlipleColorsList.SelectValueFromList("Black");

            Thread.Sleep(500);
            autoCompletePage.MultipleColorsInput.SetText("d");
            Thread.Sleep(500);
            autoCompletePage.MutlipleColorsList.SelectValueFromList("Red");

            string colorList = autoCompletePage.SelectedColorsListLabel.GetText();
            Assert.AreEqual("Aqua\r\nBlack\r\nRed", colorList);
        }

        [TestMethod]
        public void TestAutoComplete_SelectSingle()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/auto-complete");

            autoCompletePage.SingleColorInput.SetText("a");
            autoCompletePage.SingleColorsList.SelectValueFromList("Aqua");

            string color = autoCompletePage.SingleSelectedColorLabel.GetText();

            Assert.AreEqual("Aqua", color);
        }
    }
}
