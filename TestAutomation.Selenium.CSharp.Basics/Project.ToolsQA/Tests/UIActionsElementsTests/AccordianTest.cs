using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class AccordianTest : UIFramework
    {
        AccordianPage accordianPage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public AccordianTest()
        {
            accordianPage = new AccordianPage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void TestAccordian_Section1()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/accordian");
            
            string paraText = accordianPage.DynamicDisplayedPara.GetText();
            Assert.IsTrue(paraText.StartsWith("Lorem Ipsum is simply dummy text"));
        }

        [TestMethod]
        public void TestAccordian_Section2()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/accordian");

            accordianPage.Section2HeadingLabel.Click();

            string paraText = accordianPage.DynamicDisplayedPara.GetText();
            Assert.IsTrue(paraText.StartsWith("Contrary to popular belief"));
        }

        [TestMethod]
        public void TestAccordian_Section3()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/accordian");

            accordianPage.Section3HeadingLabel.ScrollToView();
            accordianPage.Section3HeadingLabel.Click();

            string paraText = accordianPage.DynamicDisplayedPara.GetText();
            Assert.IsTrue(paraText.StartsWith("It is a long established fact"));
        }
    }
}
