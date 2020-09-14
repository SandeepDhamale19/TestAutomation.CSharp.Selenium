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
    public class BrowserPage
    {
        //BTN_TabButton
        string tabButton = "tabButton";
        public UIButton TabButton => new UIButton(ElementProperties.SetElementName(tabButton, nameof(tabButton)), LocatorType.ID);

        //BTN_WindowButton
        string windowButton = "windowButton";
        public UIButton WindowButton => new UIButton(ElementProperties.SetElementName(windowButton, nameof(windowButton)), LocatorType.ID);

        //BTN_MessageWindowButton
        string messageWindowButton = "messageWindowButton";
        public UIButton MessageWindowButton => new UIButton(ElementProperties.SetElementName(messageWindowButton, nameof(messageWindowButton)), LocatorType.ID);

        //BTN_MessageWindowButton
        string messageWindowLabel = "//body";
        public UILabel MessageWindowLabel => new UILabel(ElementProperties.SetElementName(messageWindowLabel, nameof(messageWindowLabel)), LocatorType.XPATH);

    }
}
