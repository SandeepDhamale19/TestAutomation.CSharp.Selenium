using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class SelectablePage
    {
        string crasJustoLabel = "//li[contains(text(),'Cras justo odio')]";
        public UILabel CrasJustoLabel => new UILabel(ElementProperties.SetElementName(crasJustoLabel, nameof(crasJustoLabel)), LocatorType.XPATH);

        string dapibusLabel = "//li[contains(text(),'Dapibus ac facilisis in')]";
        public UILabel DapibusLabel => new UILabel(ElementProperties.SetElementName(dapibusLabel, nameof(dapibusLabel)), LocatorType.XPATH);

        string morbiLabel = "//li[contains(text(),'Morbi leo risus')]";
        public UILabel MorbiLabel => new UILabel(ElementProperties.SetElementName(morbiLabel, nameof(morbiLabel)), LocatorType.XPATH);

        string portaLabel = "//li[contains(text(),'Porta ac consectetur ac')]";
        public UILabel PortaLabel => new UILabel(ElementProperties.SetElementName(portaLabel, nameof(portaLabel)), LocatorType.XPATH);
    }
}
