
using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class TabsPage
    {
        string whatTabLabel = "demo-tab-what";
        public UILabel WhatTabLabel => new UILabel(ElementProperties.SetElementName(whatTabLabel, nameof(whatTabLabel)), LocatorType.ID);

        string originTabLabel = "demo-tab-origin";
        public UILabel OriginTabLabel => new UILabel(ElementProperties.SetElementName(originTabLabel, nameof(originTabLabel)), LocatorType.ID);

        string useTabLabel = "demo-tab-use";
        public UILabel UseTabLabel => new UILabel(ElementProperties.SetElementName(useTabLabel, nameof(useTabLabel)), LocatorType.ID);

        string moreTabLabel = "demo-tab-more";
        public UILabel MoreTabLabel => new UILabel(ElementProperties.SetElementName(moreTabLabel, nameof(moreTabLabel)), LocatorType.ID);

        string whatTabPaneLabel = "demo-tabpane-what";
        public UILabel WhatTabPaneLabel => new UILabel(ElementProperties.SetElementName(whatTabPaneLabel, nameof(whatTabPaneLabel)), LocatorType.ID);

        string originTabPaneLabel = "demo-tabpane-origin";
        public UILabel OriginTabPaneLabel => new UILabel(ElementProperties.SetElementName(originTabPaneLabel, nameof(originTabPaneLabel)), LocatorType.ID);

        string useTabPaneLabel = "demo-tabpane-use";
        public UILabel UseTabPaneLabel => new UILabel(ElementProperties.SetElementName(useTabPaneLabel, nameof(useTabPaneLabel)), LocatorType.ID);

        string moreTabPaneLabel = "demo-tabpane-more";
        public UILabel MoreTabPaneLabel => new UILabel(ElementProperties.SetElementName(moreTabPaneLabel, nameof(moreTabPaneLabel)), LocatorType.ID);
    }
}
