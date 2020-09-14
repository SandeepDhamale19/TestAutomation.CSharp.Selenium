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
    public class ButtonPage
    {
        //BTN_DoubleClick
        string doubleClickButton = "doubleClickBtn";
        public UIButton DoubleClickButton => new UIButton(ElementProperties.SetElementName(doubleClickButton, nameof(doubleClickButton)), LocatorType.ID);

        //BTN_ClickMe
        string clickMeButton = "//button[text()='Click Me']";
        public UIButton ClickMeButton => new UIButton(ElementProperties.SetElementName(clickMeButton, nameof(clickMeButton)), LocatorType.XPATH);

        string rightClickButton = "rightClickBtn";
        public UIButton RightClickButton => new UIButton(ElementProperties.SetElementName(rightClickButton, nameof(rightClickButton)), LocatorType.ID);

        string rightClickLabel = "rightClickMessage";
        public UILabel RightClickMessage => new UILabel(ElementProperties.SetElementName(rightClickLabel, nameof(rightClickLabel)), LocatorType.ID);

        string doubleClickLabel = "doubleClickMessage";
        public UILabel DoubleClickMessage => new UILabel(ElementProperties.SetElementName(doubleClickLabel, nameof(doubleClickLabel)), LocatorType.ID);

        string dynamicClickLabel = "dynamicClickMessage";
        public UILabel DynamicClickMessage => new UILabel(ElementProperties.SetElementName(dynamicClickLabel, nameof(dynamicClickLabel)), LocatorType.ID);
    }
}
