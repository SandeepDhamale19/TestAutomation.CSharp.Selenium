using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class AlertTest : UIFramework
    {
        AlertPage alertPage;
        UIBrowser uiBrowser;
        UIAlert uiAlert;
        
        NavigationPanelPage navigationPanelPage;

        public AlertTest()
        {
            alertPage = new AlertPage();
            uiAlert = new UIAlert();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }
   
        [TestMethod]
        public void TestAlert_Accept()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/alerts");

            alertPage.AlertButton.Click();
            uiAlert.AcceptAlert();
        }

        [TestMethod]
        public void TestAlert_Dismiss()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/alerts");

            alertPage.AlertButton.Click();
            uiAlert.CloseAlert();
        }

        [TestMethod]
        public void TestAlert_DelayAccept()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/alerts");

            alertPage.TimerAlertButton.Click();

            Thread.Sleep(5000);
            uiAlert.AcceptAlert();
        }

        [TestMethod]
        public void TestAlert_ConfirmAlert()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/alerts");

            alertPage.ConfirmButton.Click();
            uiAlert.AcceptAlert();

            string confirmMessage = alertPage.ConfirmResult.GetText();

            Assert.AreEqual("You selected Ok", confirmMessage);
        }

        [TestMethod]
        public void TestAlert_CancelAlert()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/alerts");

            alertPage.ConfirmButton.Click();
            uiAlert.CloseAlert();

            string confirmMessage = alertPage.ConfirmResult.GetText();

            Assert.AreEqual("You selected Cancel", confirmMessage);
        }
    }
}
