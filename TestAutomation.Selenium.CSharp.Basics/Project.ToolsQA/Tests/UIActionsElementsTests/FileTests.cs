using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.FilesFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;
using TestAutomation.Selenium.CSharp.Basics.PageObjectModels;
using TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests
{
    [TestClass]
    public class FileTests : UIFramework
    {
        FilePage filePage;
        UIBrowser uiBrowser;
        NavigationPanelPage navigationPanelPage;

        public FileTests()
        {
            filePage = new FilePage();
            uiBrowser = new UIBrowser();
            navigationPanelPage = new NavigationPanelPage();
        }

        [TestMethod]
        public void TestFile_FileDownload()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/upload-download");

            FilesHelper.DeleteFiles("sampleFile.jpeg");

            filePage.DownloadButton.Click();
            FilesHelper.WaitTillFileExists("sampleFile.jpeg");
            Assert.IsTrue(FilesHelper.FileExists("sampleFile.jpeg"));
        }

        [TestMethod]
        public void TestFile_FileUplaod()
        {
            // Navigate to URL
            uiBrowser.NavigateToURL("https://demoqa.com/upload-download");

            string fileFolderPath = FilesHelper.GetFilesLocation();
            filePage.UploadFileInput.SetText(Path.Combine(fileFolderPath,"sampleFile.jpeg"));
            string fakeFilePath = filePage.UploadedFilePath.GetText();
            Assert.AreEqual(@"C:\fakepath\sampleFile.jpeg", fakeFilePath);
        }

    }
}
