using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class FrameTests : UIFramework
    {
        FramePage framePage;
        UIBrowser uiBrowser;
        UIFrame uiFrame;
        NavigationPanelPage navigationPanelPage;

        public FrameTests()
        {
            framePage = new FramePage();
            uiBrowser = new UIBrowser();
            uiFrame = new UIFrame();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void TestFrames_SwitchToFrameByIndex()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/frames");

            uiFrame.SwitchToFrame(0);
            string frameText = framePage.SampleHeading.GetText();
            string fName = uiFrame.GetFrameName();
            //string fId = uiFrame.GetFrameId();
        }

        [TestMethod]
        public void TestFrames_SwitchToFrameByName()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/frames");

           
        }

        [TestMethod]
        public void TestFrames_SwitchToFrameByElement()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/frames");

            framePage.Frame1.SwitchToFrame();
            string frameText = framePage.SampleHeading.GetText();
            string fName = uiFrame.GetFrameName();
            //string fId = uiFrame.GetFrameId();
        }
    }
}
