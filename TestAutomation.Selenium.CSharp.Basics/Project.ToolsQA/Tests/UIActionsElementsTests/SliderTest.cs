using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class SliderTest : UIFramework
    {
        SliderPage sliderPage;
        UIBrowser uiBrowser;

        public SliderTest()
        {
            sliderPage = new SliderPage();
            uiBrowser = new UIBrowser();
        }

        [TestMethod]
        public void TestSlider_Move()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/slider");
            
            sliderPage.Slider.DragAndDropToOffset(Getpixel(20), 0);
        }

        public int Getpixel(int percentage)
        {
            double newPixelPosition = 0.0;

            var elemenProperties = sliderPage.Slider.GetlElementProperties();

            double elementWidth = elemenProperties["Width"];

            double currentPercentValue = Int32.Parse(sliderPage.SliderInput.GetAttributeValue("value"));

            double currentPixelPosition = elementWidth * (currentPercentValue / 100);

            newPixelPosition = currentPixelPosition + (currentPixelPosition * (percentage / 100.00));

            return Convert.ToInt32(newPixelPosition);
        }
    }
}
