using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class LinkPage
    {
        // LNK_Home
        string homeLink = "simpleLink";
        public UILink HomeLink => new UILink(ElementProperties.SetElementName(homeLink, nameof(homeLink)), LocatorType.ID);

        // LNK_Home
        string homeGPayLink = "dynamicLink";
        public UILink HomeGPayLink => new UILink(ElementProperties.SetElementName(homeGPayLink, nameof(homeGPayLink)), LocatorType.ID);
    }
}
