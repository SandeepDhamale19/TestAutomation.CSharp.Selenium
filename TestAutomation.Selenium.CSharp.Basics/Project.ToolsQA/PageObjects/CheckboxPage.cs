using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.DataFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class CheckboxPage
    {
        //BTN_Expand
        string expandButton = "//button[@title='Expand all']";
        public UIButton ExpandButton => new UIButton(ElementProperties.SetElementName(expandButton, nameof(expandButton)), LocatorType.XPATH);
        
        // BTN_Collapse
        string collapseButton = "//button[@title='Collapse all']";
        public UIButton CollapseButton => new UIButton(ElementProperties.SetElementName(collapseButton, nameof(collapseButton)), LocatorType.XPATH);

        //BTN_AllToggle         
        string allToggleButtons = "//button[@title='Toggle'][@type='button']";
        public UIButton AllToggleButtons => new UIButton(ElementProperties.SetElementName(allToggleButtons, nameof(allToggleButtons)), LocatorType.XPATH);

        //BTN_Toggle         
        string toggleButton = "//div[@id='tree-node']/ol/li/span/button[@title='Toggle'][@type='button']";
        public UIButton ToggleButton => new UIButton(ElementProperties.SetElementName(toggleButton, nameof(toggleButton)), LocatorType.XPATH);


        //LBL_Home2         
        string homeLabel = "(//ol/li/span/Label/span)[3]";
        public UILabel HomeLabel => new UILabel(ElementProperties.SetElementName(homeLabel, nameof(homeLabel)), LocatorType.XPATH);

        string homeCheckbox = "//*[@for='tree-node-home']";
        public UIButton HomeCheckbox => new UIButton(ElementProperties.SetElementName(homeCheckbox, nameof(homeCheckbox)), LocatorType.XPATH);


        //BTN_Toggle2         
        string toggle2Button = "(//li/ol/li/span/button[@title='Toggle'][@type='button'])[1]";
        public UIButton Toggle2Button => new UIButton(ElementProperties.SetElementName(toggle2Button, nameof(toggle2Button)), LocatorType.XPATH);


        //LBL_Desktop         
        string desktopLabel = "//span[contains(text(),'Desktop')]";
        public UILabel DesktopLabel => new UILabel(ElementProperties.SetElementName(desktopLabel, nameof(desktopLabel)), LocatorType.XPATH);

        string desktopCheckbox = "tree-node-desktop";
        public UIButton DesktopCheckbox => new UIButton(ElementProperties.SetElementName(desktopCheckbox, nameof(desktopCheckbox)), LocatorType.ID);


        //LBL_Notes
        string notesLabel = "//span[contains(text(),'Notes')]";
        public UILabel NotesLabel => new UILabel(ElementProperties.SetElementName(notesLabel, nameof(notesLabel)), LocatorType.XPATH);

        string notesCheckbox = "tree-node-notes";
        public UIButton NotesCheckbox => new UIButton(ElementProperties.SetElementName(notesCheckbox, nameof(notesCheckbox)), LocatorType.ID);


        //LBL_Commands
        string commandsLabel = "//span[contains(text(),'Commands')]";
        public UILabel CommandsLabel => new UILabel(ElementProperties.SetElementName(commandsLabel, nameof(commandsLabel)), LocatorType.XPATH);

        string commandsCheckbox = "tree-node-commands";
        public UIButton CommandsCheckbox => new UIButton(ElementProperties.SetElementName(commandsCheckbox, nameof(commandsCheckbox)), LocatorType.ID);

        //BTN_Toggle3
        string toggle3Button = "(//li/ol/li/span/button[@title='Toggle'][@type='button'])[2]";
        public UIButton Toggle3Button => new UIButton(ElementProperties.SetElementName(toggle3Button, nameof(toggle3Button)), LocatorType.XPATH);


        //LBL_Documents
        string documentsLabel = "//span[contains(text(),'Documents')]";
        public UILabel DocumentsLabel => new UILabel(ElementProperties.SetElementName(documentsLabel, nameof(documentsLabel)), LocatorType.XPATH);

        string documentsCheckbox = "tree-node-documents";
        public UIButton DocumentsCheckbox => new UIButton(ElementProperties.SetElementName(documentsCheckbox, nameof(documentsCheckbox)), LocatorType.ID);


        //BTN_Toggle4
        string toggle4Button = "(//li/ol/li/span/button[@title='Toggle'][@type='button'])[3]";
        public UIButton Toggle4Button => new UIButton(ElementProperties.SetElementName(toggle4Button, nameof(toggle4Button)), LocatorType.XPATH);


        //LBL_Workspace
        string workspaceLabel = "//span[contains(text(),'WorkSpace')]";
        public UILabel WorkspaceLabel => new UILabel(ElementProperties.SetElementName(workspaceLabel, nameof(workspaceLabel)), LocatorType.XPATH);

        string workspaceCheckbox = "tree-node-workspace";
        public UIButton WorkspaceCheckbox => new UIButton(ElementProperties.SetElementName(workspaceCheckbox, nameof(workspaceCheckbox)), LocatorType.ID);

        //LBL_React
        string reactLabel = "//span[contains(text(),'React')]";
        public UILabel ReactLabel => new UILabel(ElementProperties.SetElementName(reactLabel, nameof(reactLabel)), LocatorType.XPATH);

        string reactCheckbox = "tree-node-react";
        public UIButton ReactCheckbox => new UIButton(ElementProperties.SetElementName(reactCheckbox, nameof(reactCheckbox)), LocatorType.ID);


        //LBL_Angular
        string angularLabel = "//span[contains(text(),'Angular')]";
        public UILabel AngularLabel => new UILabel(ElementProperties.SetElementName(angularLabel, nameof(angularLabel)), LocatorType.XPATH);

        string angularCheckbox = "tree-node-angular";
        public UIButton AngularCheckbox => new UIButton(ElementProperties.SetElementName(angularCheckbox, nameof(angularCheckbox)), LocatorType.ID);

        //LBL_Veu
        string veuLabel = "//span[contains(text(),'Veu')]";
        public UILabel VeuLabel => new UILabel(ElementProperties.SetElementName(veuLabel, nameof(veuLabel)), LocatorType.XPATH);

        string veuCheckbox = "tree-node-veu";
        public UIButton VeuCheckbox => new UIButton(ElementProperties.SetElementName(veuCheckbox, nameof(veuCheckbox)), LocatorType.ID);


        //BTN_Toggle5
        string toggel5Button = "(//li/ol/li/span/button[@title='Toggle'][@type='button'])[4]";
        public UIButton Toggle5Button => new UIButton(ElementProperties.SetElementName(toggel5Button, nameof(toggel5Button)), LocatorType.XPATH);


        //LBL_Office
        string officeLabel = "//span[contains(text(),'Office')]";
        public UILabel OfficeLabel => new UILabel(ElementProperties.SetElementName(officeLabel, nameof(officeLabel)), LocatorType.XPATH);

        string officeCheckbox = "tree-node-office";
        public UIButton OfficeCheckbox => new UIButton(ElementProperties.SetElementName(officeCheckbox, nameof(officeCheckbox)), LocatorType.ID);


        //LBL_Public
        string publicLabel = "//span[contains(text(),'Public')]";
        public UILabel PublicLabel => new UILabel(ElementProperties.SetElementName(publicLabel, nameof(publicLabel)), LocatorType.XPATH);

        string publicCheckbox = "tree-node-public";
        public UIButton PublicCheckbox => new UIButton(ElementProperties.SetElementName(publicCheckbox, nameof(publicCheckbox)), LocatorType.ID);


        //LBL_Private
        string privateLabel = "//span[contains(text(),'Private')]";
        public UILabel PrivateLabel => new UILabel(ElementProperties.SetElementName(privateLabel, nameof(privateLabel)), LocatorType.XPATH);

        string privateCheckbox = "tree-node-privte";
        public UIButton PrivateCheckbox => new UIButton(ElementProperties.SetElementName(privateCheckbox, nameof(privateCheckbox)), LocatorType.ID);


        //LBL_Classified
        string classifiedLabel = "//span[contains(text(),'Classified')]";
        public UILabel ClassifiedLabel => new UILabel(ElementProperties.SetElementName(classifiedLabel, nameof(classifiedLabel)), LocatorType.XPATH);

        string classifiedCheckbox = "tree-node-classified";
        public UIButton ClassifiedCheckbox => new UIButton(ElementProperties.SetElementName(classifiedCheckbox, nameof(classifiedCheckbox)), LocatorType.ID);

        //LBL_General
        string generalLabel = "//span[contains(text(),'General')]";
        public UILabel GeneralLabel => new UILabel(ElementProperties.SetElementName(generalLabel, nameof(generalLabel)), LocatorType.XPATH);

        string generalCheckbox = "tree-node-general";
        public UIButton GeneralCheckbox => new UIButton(ElementProperties.SetElementName(generalCheckbox, nameof(generalCheckbox)), LocatorType.ID);

        //BTN_Toggle6
        string toggle6Button = "(//li/ol/li/span/button[@title='Toggle'][@type='button'])[5]";
        public UIButton Toggle6Button => new UIButton(ElementProperties.SetElementName(toggle6Button, nameof(toggle6Button)), LocatorType.XPATH);


        //LBL_Downloads
        string downloadsLabel = "//span[contains(text(),'Downloads')]";
        public UILabel DownloadsLabel => new UILabel(ElementProperties.SetElementName(downloadsLabel, nameof(downloadsLabel)), LocatorType.XPATH);

        string downloadsCheckbox = "tree-node-downloads";
        public UIButton DownloadsCheckbox => new UIButton(ElementProperties.SetElementName(downloadsCheckbox, nameof(downloadsCheckbox)), LocatorType.ID);


        //LBL_Wordfiledoc
        string wordfileDocLabel = "//span[contains(text(),'Word File.doc')]";
        public UILabel WordfiledocLabel => new UILabel(ElementProperties.SetElementName(wordfileDocLabel, nameof(wordfileDocLabel)), LocatorType.XPATH);

        string wordfileDocCheckbox = "tree-node-wordFile";
        public UIButton WordfileCheckbox => new UIButton(ElementProperties.SetElementName(wordfileDocCheckbox, nameof(wordfileDocCheckbox)), LocatorType.ID);


        //LBL_Excelfiledoc
        string excelfileDocLabel = "//span[contains(text(),'Excel File.doc')]";
        public UILabel ExcelfiledocLabel => new UILabel(ElementProperties.SetElementName(excelfileDocLabel, nameof(excelfileDocLabel)), LocatorType.XPATH);

        // TXT_ExcelfileDocCheckbox
        string excelfileDocCheckbox = "tree-node-excelFile";
        public UILabel ExcelfiledocCheckbox => new UILabel(ElementProperties.SetElementName(excelfileDocCheckbox, nameof(excelfileDocCheckbox)), LocatorType.ID);
    }
}
