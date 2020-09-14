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
    public class FramePage
    {
        string frame2 = "frame2";
        public UIFrame Frame2 => new UIFrame(ElementProperties.SetElementName(frame2, nameof(frame2)), LocatorType.ID);

        string frame1 = "frame1";
        public UIFrame Frame1 => new UIFrame(ElementProperties.SetElementName(frame1, nameof(frame1)), LocatorType.ID);

        string sampleHeading = "sampleHeading";
        public UILabel SampleHeading => new UILabel(ElementProperties.SetElementName(sampleHeading, nameof(sampleHeading)), LocatorType.ID);
    }
}
