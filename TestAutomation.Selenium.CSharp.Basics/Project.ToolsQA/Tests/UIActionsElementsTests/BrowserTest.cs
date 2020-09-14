using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestAutomation.Selenium.CSharp.Basics.DriverFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class BrowserTest : UIFramework
    {
        BrowserPage browserPage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public BrowserTest()
        {
            browserPage = new BrowserPage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void TestBrowser_NewTab()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/browser-windows");

            browserPage.TabButton.Click();
            uiBrowser.SwitchToTab();
            string url = uiBrowser.GetURL();

            Assert.AreEqual("https://demoqa.com/sample", url);
        }

        [TestMethod]
        public void TestBrowser_NewWindow()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/browser-windows");

            browserPage.WindowButton.Click();
            uiBrowser.SwitchToWindow();
            string url = uiBrowser.GetURL();

            Assert.AreEqual("https://demoqa.com/sample", url);
        }

        [TestMethod]
        public void TestBrowser_NewWindowMessage()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/browser-windows");

            browserPage.MessageWindowButton.Click();
            uiBrowser.SwitchToWindow();

            IWebElement webElement = browserPage.MessageWindowLabel.GetElementIfExists();
            jsExec(webElement);
            string t  = webElement.Text;
            string message = browserPage.MessageWindowLabel.GetText();
            //string url = uiBrowser.GetURL();

           // Assert.AreEqual("https://demoqa.com/sample", url);
        }

        public void jsExec(IWebElement webElement)
        {
            String javaScript = "var evObj = document.createEvent('MouseEvents');" +
                "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
                "arguments[0].dispatchEvent(evObj);";


            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript(javaScript, webElement);
        }

        
    }
}
