using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class AlertPage
    {
        //BTN_TabButton
        string alertButton = "alertButton";
        public UIButton AlertButton => new UIButton(ElementProperties.SetElementName(alertButton, nameof(alertButton)), LocatorType.ID);

        string timerAlertButton = "timerAlertButton";
        public UIButton TimerAlertButton => new UIButton(ElementProperties.SetElementName(timerAlertButton, nameof(timerAlertButton)), LocatorType.ID);

        string confirmButton = "confirmButton";
        public UIButton ConfirmButton => new UIButton(ElementProperties.SetElementName(confirmButton, nameof(confirmButton)), LocatorType.ID);

        string promtButton = "promtButton";
        public UIButton PromtButton => new UIButton(ElementProperties.SetElementName(promtButton, nameof(promtButton)), LocatorType.ID);

        string confirmResult = "confirmResult";
        public UILabel ConfirmResult => new UILabel(ElementProperties.SetElementName(confirmResult, nameof(confirmResult)), LocatorType.ID);

        string promptResult = "promptResult";
        public UILabel PromptResult => new UILabel(ElementProperties.SetElementName(promptResult, nameof(promptResult)), LocatorType.ID);
    }
}
