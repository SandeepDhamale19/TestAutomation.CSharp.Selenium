using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class ToolTipTest : UIFramework
    {
        ToolTipPage toolTipPage;
        UIBrowser uiBrowser;

        public ToolTipTest()
        {
            toolTipPage = new ToolTipPage();
            uiBrowser = new UIBrowser();
        }

        [TestMethod]
        public void ToolTip_Hover()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/tool-tips");

            toolTipPage.ToolTipButton.HoverOver();
            string hoverText = toolTipPage.ToolTip.GetText();

            toolTipPage.ToolTipLink.HoverOver();
            hoverText = toolTipPage.ToolTip.GetText();

            toolTipPage.ToolTipTextField.HoverOver();
            hoverText = toolTipPage.ToolTip.GetText();

            toolTipPage.ToolTipSectionLink.HoverOver();
            hoverText = toolTipPage.ToolTip.GetText();
        }
    }
}
