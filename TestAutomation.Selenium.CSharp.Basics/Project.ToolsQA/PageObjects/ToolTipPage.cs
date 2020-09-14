using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class ToolTipPage
    {
        string toolTipButton = "toolTipButton";
        public UILabel ToolTipButton => new UILabel(ElementProperties.SetElementName(toolTipButton, nameof(toolTipButton)), LocatorType.ID);

        string toolTipTextField = "toolTipTextField";
        public UILabel ToolTipTextField => new UILabel(ElementProperties.SetElementName(toolTipTextField, nameof(toolTipTextField)), LocatorType.ID);

        string toolTipLink = "//div[@id='texToolTopContainer']/a[1]";
        public UILabel ToolTipLink => new UILabel(ElementProperties.SetElementName(toolTipLink, nameof(toolTipLink)), LocatorType.XPATH);

        string toolTipSectionLink = "//div[@id='texToolTopContainer']/a[2]";
        public UILabel ToolTipSectionLink => new UILabel(ElementProperties.SetElementName(toolTipSectionLink, nameof(toolTipSectionLink)), LocatorType.XPATH);

        string toolTip = "//div[@class='tooltip-inner']";
        public UILabel ToolTip => new UILabel(ElementProperties.SetElementName(toolTip, nameof(toolTip)), LocatorType.XPATH);

    }
}
