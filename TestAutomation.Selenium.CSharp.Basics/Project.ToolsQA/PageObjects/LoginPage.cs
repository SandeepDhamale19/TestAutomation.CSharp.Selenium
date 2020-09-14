using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class LoginPage
    {
        string userNameTextbox = "userName";
        public UIInputText UserNameInput =>  new UIInputText(ElementProperties.SetElementName(userNameTextbox, nameof(userNameTextbox)), LocatorType.ID);

        string passwordTextbox = "password";
        public UIInputText PasswordInput => new UIInputText(ElementProperties.SetElementName(passwordTextbox, nameof(passwordTextbox)), LocatorType.ID);

        string loginButton = "login";
        public UIButton LoginButton => new UIButton(ElementProperties.SetElementName(loginButton, nameof(loginButton)), LocatorType.ID);

        string logoutButton = "submit";
        public UIButton LogoutButton => new UIButton(ElementProperties.SetElementName(logoutButton, nameof(logoutButton)), LocatorType.ID);

        public void Login(string userName, string password)
        {
            UserNameInput.SetText(userName);
            PasswordInput.SetText(password);
            LoginButton.Click();

            Thread.Sleep(1000);
            bool pageDispalyed = LogoutButton.IsDisplayed();

            Assert.IsTrue(pageDispalyed);
        }
    }
}
