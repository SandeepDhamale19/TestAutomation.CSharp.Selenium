using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.DriverFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class SortablePage
    {
        string sortableList = "//div[@id='demo-tabpane-list']//div[@class ='list-group-item list-group-item-action'][text()='[?]']";
        public UIList SortableList => new UIList(ElementProperties.SetElementName(sortableList.Replace("[?]", DriverSession.GetSessionKeyData("ListNumber").ToString()), nameof(sortableList)), LocatorType.XPATH);
        
        string sortableGrid = "//div[@id='demo-tabpane-grid']//div[@class ='list-group-item list-group-item-action'][text()='[?]']";
        public UIList SortableGrid => new UIList(ElementProperties.SetElementName(sortableGrid.Replace("[?]", DriverSession.GetSessionKeyData("ListNumber").ToString()), nameof(sortableGrid)), LocatorType.XPATH);

        string gridTab = "demo-tab-grid";
        public UILabel GridTab => new UILabel(ElementProperties.SetElementName(gridTab, nameof(gridTab)), LocatorType.ID);
    }
}
