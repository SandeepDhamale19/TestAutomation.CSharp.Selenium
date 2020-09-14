using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class MenuItemsPage
    {
        string allMainLinks = "//ul[@id='nav']/li";
        public UILabel AllMainLink => new UILabel(ElementProperties.SetElementName(allMainLinks, nameof(allMainLinks)), LocatorType.XPATH);


        string mainItem1Link = "//ul[@id='nav']//a[text()='Main Item 1']";
        public UILabel MainItem1Link => new UILabel(ElementProperties.SetElementName(mainItem1Link, nameof(mainItem1Link)), LocatorType.XPATH);

        string mainItem2Link = "//ul[@id='nav']//a[text()='Main Item 2']";
        public UILabel MainItem2Link => new UILabel(ElementProperties.SetElementName(mainItem2Link, nameof(mainItem2Link)), LocatorType.XPATH);

        string mainItem3Link = "//ul[@id='nav']//a[text()='Main Item 3']";
        public UILabel MainItem3Link => new UILabel(ElementProperties.SetElementName(mainItem3Link, nameof(mainItem3Link)), LocatorType.XPATH);

        string allSubLinks = "//ul[@id='nav']/li[2]/ul/li";
        public UILabel AllSubLinks => new UILabel(ElementProperties.SetElementName(allSubLinks, nameof(allSubLinks)), LocatorType.XPATH);

        string subItem3Link = "//a[text()='SUB SUB LIST »']";
        public UILabel SubItem3Link => new UILabel(ElementProperties.SetElementName(subItem3Link, nameof(subItem3Link)), LocatorType.XPATH);


        string allSubSubLinks = "//ul[@id='nav']/li[2]/ul/li";
        public UILabel AllSubSubLinks => new UILabel(ElementProperties.SetElementName(allSubSubLinks, nameof(allSubSubLinks)), LocatorType.XPATH);
    }
}
