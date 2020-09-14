using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class ProgressBarPage
    {
        string progressBarButton = "//div[@id='progressBar']/div";
        public UIButton ProgressBarButton => new UIButton(ElementProperties.SetElementName(progressBarButton, nameof(progressBarButton)), LocatorType.XPATH);

        string startStopButton = "startStopButton";
        public UIButton StartStopButton => new UIButton(ElementProperties.SetElementName(startStopButton, nameof(startStopButton)), LocatorType.ID);
    }
}
