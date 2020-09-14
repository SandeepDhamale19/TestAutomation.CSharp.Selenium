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
    public class AutoCompletePage
    {
        string multipleColorNamesLabel = "//span[contains(text(),'Type multiple color names')]";
        public UILabel MultipleColorNamesLabel => new UILabel(ElementProperties.SetElementName(multipleColorNamesLabel, nameof(multipleColorNamesLabel)), LocatorType.XPATH);

        string selectedColorsListLabel = "//span/following-sibling::div[@id='autoCompleteMultipleContainer']/div[1]/div[1]";
        public UILabel SelectedColorsListLabel => new UILabel(ElementProperties.SetElementName(selectedColorsListLabel, nameof(selectedColorsListLabel)), LocatorType.XPATH);

        string multipleColorsInput = "autoCompleteMultipleInput";
        public UIInputText MultipleColorsInput => new UIInputText(ElementProperties.SetElementName(multipleColorsInput, nameof(multipleColorsInput)), LocatorType.ID);

        string singleColorNamesLabel = "//span[contains(text(),'Type single color name')]";
        public UILabel SingleColorNamesLabel => new UILabel(ElementProperties.SetElementName(singleColorNamesLabel, nameof(singleColorNamesLabel)), LocatorType.XPATH);

        string singleColorInput = "autoCompleteSingleInput";
        public UIInputText SingleColorInput => new UIInputText(ElementProperties.SetElementName(singleColorInput, nameof(singleColorInput)), LocatorType.ID);

        string singleColorsList = "//div[@id='autoCompleteSingle']/div/div/div/div";
        public UIList SingleColorsList => new UIList(ElementProperties.SetElementName(singleColorsList, nameof(singleColorsList)), LocatorType.XPATH);

        string singleSelectedColorLabel = "//div[@id='autoCompleteSingleContainer']/div/div/div[1]";
        public UILabel SingleSelectedColorLabel => new UILabel(ElementProperties.SetElementName(singleSelectedColorLabel, nameof(singleSelectedColorLabel)), LocatorType.XPATH);


        string mutlipleColorsList = "//div[@id='autoCompleteMultipleContainer']/div[2]/div/div";
        public UIList MutlipleColorsList => new UIList(ElementProperties.SetElementName(mutlipleColorsList, nameof(mutlipleColorsList)), LocatorType.XPATH);
    }
}
