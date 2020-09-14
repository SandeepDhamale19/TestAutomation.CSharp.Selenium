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
    public class SelectPage
    {
        string selectValueLabel = "//div[contains(text(),'Select Value')]";
        public UILabel SelectValueLabel => new UILabel(ElementProperties.SetElementName(selectValueLabel, nameof(selectValueLabel)), LocatorType.XPATH);

        string selectOptionLabel = "//div[contains(text(),'Select Option')]";
        public UILabel SelectOptionLabel => new UILabel(ElementProperties.SetElementName(selectOptionLabel, nameof(selectOptionLabel)), LocatorType.XPATH);

        string selectOptionList = "//div[@id='withOptGroup']/div[2]/div";
        public UIList SelectOptionList => new UIList(ElementProperties.SetElementName(selectOptionList, nameof(selectOptionList)), LocatorType.XPATH);

        string selectValueInput1 = "react-select-2-input";
        public UIInputText SelectValueInput1 => new UIInputText(ElementProperties.SetElementName(selectValueInput1, nameof(selectValueInput1)), LocatorType.ID);

        string selectOneLabel = "//div[contains(text(),'Select One')]";
        public UILabel SelectOneLabel => new UILabel(ElementProperties.SetElementName(selectOneLabel, nameof(selectOneLabel)), LocatorType.XPATH);

        string selectOneList = "//div[@id='selectOne']/div[2]/div";
        public UIList SelectOneList => new UIList(ElementProperties.SetElementName(selectOneList, nameof(selectOneList)), LocatorType.XPATH);


        string selectTitleLabel = "//div[contains(text(),'Select Title')]";
        public UILabel SelectTitleLabel => new UILabel(ElementProperties.SetElementName(selectTitleLabel, nameof(selectTitleLabel)), LocatorType.XPATH);

        string selectValueInput2 = "react-select-3-input";
        public UIInputText SelectValueInput2 => new UIInputText(ElementProperties.SetElementName(selectValueInput2, nameof(selectValueInput2)), LocatorType.ID);

        string oldStyleLabel = "//div[contains(text(),'Old Style Select Menu')]";
        public UILabel OldStyleLabel => new UILabel(ElementProperties.SetElementName(oldStyleLabel, nameof(oldStyleLabel)), LocatorType.XPATH);

        string oldSelect = "oldSelectMenu";
        public UISelect OldSelect => new UISelect(ElementProperties.SetElementName(oldSelect, nameof(oldSelect)), LocatorType.ID);


        string multiSelectLabel = "(//div[@id='selectMenuContainer']/div/div/p/b)[1]";
        public UILabel MultiSelectLabel => new UILabel(ElementProperties.SetElementName(multiSelectLabel, nameof(multiSelectLabel)), LocatorType.XPATH);

        string selectLabel = "//div[contains(text(),'Select...')]";
        public UILabel SelectLabel => new UILabel(ElementProperties.SetElementName(selectLabel, nameof(selectLabel)), LocatorType.XPATH);

        string selectValueInput3 = "react-select-4-input";
        public UIInputText SelectValueInput3 => new UIInputText(ElementProperties.SetElementName(selectValueInput3, nameof(selectValueInput3)), LocatorType.ID);

        string standardMultiSelect = "//b[contains(text(),'Standard multi select')]";
        public UILabel StandardMultiSelect => new UILabel(ElementProperties.SetElementName(standardMultiSelect, nameof(standardMultiSelect)), LocatorType.XPATH);

        string carsSelect = "cars";
        public UISelect CarsSelect => new UISelect(ElementProperties.SetElementName(carsSelect, nameof(carsSelect)), LocatorType.ID);
    }
}
