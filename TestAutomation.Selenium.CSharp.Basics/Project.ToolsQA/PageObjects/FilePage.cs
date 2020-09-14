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
    public class FilePage
    {
        // BTN_download
        string downloadButton = "downloadButton";
        public UIButton  DownloadButton => new UIButton(ElementProperties.SetElementName(downloadButton, nameof(downloadButton)), LocatorType.ID);

        // BTN_Upload
        string uploadFile = "uploadFile";
        public UIInputText UploadFileInput => new UIInputText(ElementProperties.SetElementName(uploadFile, nameof(uploadFile)), LocatorType.ID);

        // BTN_uploadedFilePath
        string uploadedFilePath = "uploadedFilePath";
        public UILabel UploadedFilePath => new UILabel(ElementProperties.SetElementName(uploadedFilePath, nameof(uploadedFilePath)), LocatorType.ID);

    }
}
