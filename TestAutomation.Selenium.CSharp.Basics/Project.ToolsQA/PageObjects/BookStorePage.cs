using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class BookStorePage
    {
        string searchTextbox = "searchBox";
        public UIInputText SearchboxInput => new UIInputText(searchTextbox, LocatorType.ID);

        string searchResultLink = "(//div[contains(@class,'ReactTable')]//a)[1]";
        public UILink SearchResultLink => new UILink(ElementProperties.SetElementName(searchResultLink, nameof(searchResultLink)), LocatorType.XPATH);

        public void SearchBook(string bookName)
        {
            SearchboxInput.SetText(bookName);
        }

        public bool VerifyBookName(string bookNameSubstring)
        {
            return SearchResultLink.GetText().ToLower().Contains(bookNameSubstring);
        }
    }
}
