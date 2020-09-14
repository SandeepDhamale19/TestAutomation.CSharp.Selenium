using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class ProgressBarTest : UIFramework
    {
        ProgressBarPage progressBarPage;
        UIBrowser uiBrowser;

        public ProgressBarTest()
        {
            progressBarPage = new ProgressBarPage();
            uiBrowser = new UIBrowser();
        }

        [TestMethod]
        public void TestProgressBar_StopByInterval()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/progress-bar");

            progressBarPage.StartStopButton.Click();
            Thread.Sleep(3000);

            string valueAfterInteval = progressBarPage.ProgressBarButton.GetAttributeValue("aria-valuenow");
            Assert.IsTrue(Int32.Parse(valueAfterInteval) > 0);
        }

        [TestMethod]
        public void TestProgressBar_StopByPercentage()
        {
            int stopPercentValue = 25;

            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/progress-bar");

            progressBarPage.StartStopButton.Click();

            int currentValue = 0;

            while (currentValue!= stopPercentValue)
            {
                currentValue = Int32.Parse(progressBarPage.ProgressBarButton.GetAttributeValue("aria-valuenow"));
                if(currentValue== stopPercentValue)
                {
                    progressBarPage.StartStopButton.Click();
                    break;
                }

                //Thread.Sleep(1);
            }

            string valueAfterInteval = progressBarPage.ProgressBarButton.GetAttributeValue("aria-valuenow");
            Assert.IsTrue(Int32.Parse(valueAfterInteval)>=25);

        }
    }
}
