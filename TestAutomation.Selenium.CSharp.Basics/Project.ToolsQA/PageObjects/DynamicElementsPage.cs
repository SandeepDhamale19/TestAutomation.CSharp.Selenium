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
    public class DynamicElementsPage
    {
        //BTN_EnableAfter
        string enableAfter = "enableAfter";
        public UIButton EnableAfterButton => new UIButton(ElementProperties.SetElementName(enableAfter, nameof(enableAfter)), LocatorType.ID);

        //BTN_ColorChange
        string colorChange = "colorChange";
        public UIButton ColorChangeButton => new UIButton(ElementProperties.SetElementName(colorChange, nameof(colorChange)), LocatorType.ID);

        //BTN_VisibleAfter
        string visibleAfter = "visibleAfter";
        public UIButton VisibleAfterButton => new UIButton(ElementProperties.SetElementName(visibleAfter, nameof(visibleAfter)), LocatorType.ID);

        string textWithRandomId = "//button[@id='enableAfter']/preceding-sibling::p";
        public UILabel TextWithRandomIdLabel => new UILabel(ElementProperties.SetElementName(textWithRandomId, nameof(textWithRandomId)), LocatorType.XPATH);
    }
}
