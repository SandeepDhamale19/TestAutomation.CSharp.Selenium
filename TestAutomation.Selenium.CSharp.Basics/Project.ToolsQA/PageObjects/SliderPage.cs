using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class SliderPage
    {
        string slider = "//div[@id='sliderContainer']/div/span";
        public UIInteractive Slider => new UIInteractive(ElementProperties.SetElementName(slider, nameof(slider)), LocatorType.XPATH);

        string sliderInput = "//div[@id='sliderContainer']/div/span/input";
        public UIInteractive SliderInput => new UIInteractive(ElementProperties.SetElementName(sliderInput, nameof(sliderInput)), LocatorType.XPATH);
    }
}
