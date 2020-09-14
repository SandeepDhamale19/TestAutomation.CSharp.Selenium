using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class AccordianPage
    {
        string dynamicDisplayedPara = "//div[@class='collapse show']/div";
        public UILabel DynamicDisplayedPara => new UILabel(ElementProperties.SetElementName(dynamicDisplayedPara, nameof(dynamicDisplayedPara)), LocatorType.XPATH);

        string para1Label = "//div[@id='section1Content']/p";
        public UILabel LoremIpsumLabel => new UILabel(ElementProperties.SetElementName(para1Label, nameof(para1Label)), LocatorType.XPATH);

        string para2Label = "//div[@id='section2Content']/p";
        public UILabel WhereItCameFromLabel => new UILabel(ElementProperties.SetElementName(para2Label, nameof(para2Label)), LocatorType.XPATH);

        string para3Label = "//div[@id='section3Content']/p";
        public UILabel WhyDoWeUseLabel => new UILabel(ElementProperties.SetElementName(para3Label, nameof(para3Label)), LocatorType.XPATH);

        string section1HeadingLabel = "//div[@id='section1Heading']";
        public UILabel Section1HeadingLabel => new UILabel(ElementProperties.SetElementName(section1HeadingLabel, nameof(section1HeadingLabel)), LocatorType.XPATH);

        string section2HeadingLabel = "//div[@id='section2Heading']";
        public UILabel Section2HeadingLabel => new UILabel(ElementProperties.SetElementName(section2HeadingLabel, nameof(section2HeadingLabel)), LocatorType.XPATH);

        string section3HeadingLabel = "//div[@id='section3Heading']";
        public UILabel Section3HeadingLabel => new UILabel(ElementProperties.SetElementName(section3HeadingLabel, nameof(section3HeadingLabel)), LocatorType.XPATH);
    }
}
