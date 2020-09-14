
using TestAutomation.Selenium.CSharp.Basics.Framework.Constants;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIElementsFactory;
using TestAutomation.Selenium.CSharp.Basics.Framework.Utilities.UIFactory;

namespace TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.PageObjects
{
    public class WebTablePage
    {
        // Bookstore Table - Includes Header and Footer
        string bookStoreTable = "//div[@class='ReactTable -striped -highlight']";
        public UITable BookStoreTable => new UITable(ElementProperties.SetElementName(bookStoreTable, nameof(bookStoreTable)), LocatorType.XPATH);

        // Bookstore Content Table
        string bookStoreContentTable = "//div[@class='ReactTable -striped -highlight']";
        public UITable BookStoreContentTable => new UITable(ElementProperties.SetElementName(bookStoreTable, nameof(bookStoreContentTable)), LocatorType.XPATH);

        #region Body
        string bookStoreTableBody = "//div[@class='rt-tbody']";
        public UITable BookStoreTableBody => new UITable(ElementProperties.SetElementName(bookStoreTableBody, nameof(bookStoreTableBody)), LocatorType.XPATH);

        // Format: All columns seperated by [;]
        // Individual path format: "locator(LocatortType)<ActionName>"
        // 

        string bookStoreTableDeleteValues = "//div[@class='rt-td'][text()][1]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][2]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][3]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][4]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][5]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][6]<XPATH>{None()}[;]" +
                                          "//div[@class='action-buttons']/span[1]<XPATH>{None()}[;]" +
                                          "//div[@class='action-buttons']/span[2]<XPATH>{Click()}";
        public UITable BookStoreTableDeleteValues => new UITable(ElementProperties.SetElementName(bookStoreTableDeleteValues, nameof(bookStoreTableDeleteValues)), LocatorType.XPATH);

        string bookStoreTableEditValues = "//div[@class='rt-td'][text()][1]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][2]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][3]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][4]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][5]<XPATH>{None()}[;]" +
                                          "//div[@class='rt-td'][text()][6]<XPATH>{None()}[;]" +
                                          "//div[@class='action-buttons']/span[1]<XPATH>{Click()}[;]" +
                                          "//{ProjectMethod(TestAutomation.Selenium.CSharp.Basics.Project.ToolsQA.Tests.UIActionsElementsTests.WebTableTests.AddRegistration)}[;]" +
                                          "//div[@class='action-buttons']/span[2]<XPATH>{None()}";
        public UITable BookStoreTableEditValues => new UITable(ElementProperties.SetElementName(bookStoreTableEditValues, nameof(bookStoreTableEditValues)), LocatorType.XPATH);

        string tableFirstRowEditButton = "(//div[@class='action-buttons']/span[1])[1]";
        public UIButton TableFirstRowEditButton => new UIButton(ElementProperties.SetElementName(tableFirstRowEditButton, nameof(tableFirstRowEditButton)), LocatorType.XPATH);
        #endregion

        #region WebTableRegistration Form
        string firstName = "firstName";
        public UIInputText FirstName => new UIInputText(ElementProperties.SetElementName(firstName, nameof(firstName)), LocatorType.ID);

        string lastName = "lastName";
        public UIInputText LastName => new UIInputText(ElementProperties.SetElementName(lastName, nameof(lastName)), LocatorType.ID);

        string userEmail = "userEmail";
        public UIInputText UserEmail => new UIInputText(ElementProperties.SetElementName(userEmail, nameof(userEmail)), LocatorType.ID);

        string age = "age";
        public UIInputText Age => new UIInputText(ElementProperties.SetElementName(age, nameof(age)), LocatorType.ID);

        string salary = "salary";
        public UIInputText Salary => new UIInputText(ElementProperties.SetElementName(salary, nameof(salary)), LocatorType.ID);

        string department = "department";
        public UIInputText Department => new UIInputText(ElementProperties.SetElementName(department, nameof(department)), LocatorType.ID);

        string submit = "submit";
        public UIButton Submit => new UIButton(ElementProperties.SetElementName(submit, nameof(submit)), LocatorType.ID);
        #endregion

        #region Header
        string bookStoreTableHeader = "//div[@class='rt-thead -header']";
        public UITable BookStoreTableHeader => new UITable(ElementProperties.SetElementName(bookStoreTableHeader, nameof(bookStoreTableHeader)), LocatorType.XPATH);
        #endregion

        #region Footer
        string bookStoreTablePagination = "//div[@class='pagination-bottom']";
        public UITable BookStoreTablePagination => new UITable(ElementProperties.SetElementName(bookStoreTablePagination, nameof(bookStoreTablePagination)), LocatorType.XPATH);

        string bookStorePaginationPrevious = "//div[@class='-previous']/button";
        public UIButton BookStorePaginationPreviousButton => new UIButton(ElementProperties.SetElementName(bookStorePaginationPrevious, nameof(bookStorePaginationPrevious)), LocatorType.XPATH);

        string bookStorePaginationNextButton = "//div[@class='-next']/button";
        public UIButton BookStorePaginationNextButton => new UIButton(ElementProperties.SetElementName(bookStorePaginationNextButton, nameof(bookStorePaginationNextButton)), LocatorType.XPATH);

        string pageInfo = "//span[@class='-pageInfo']";
        public UILabel PageInfo => new UILabel(ElementProperties.SetElementName(pageInfo, nameof(pageInfo)), LocatorType.XPATH);

        string pageNumberText = "//div[@class='-pageJump']/input";
        public UILabel PageNumberText => new UILabel(ElementProperties.SetElementName(pageNumberText, nameof(pageNumberText)), LocatorType.XPATH);

        string totalPages = "//span[@class='-totalPages']";
        public UILabel TotalPages => new UILabel(ElementProperties.SetElementName(totalPages, nameof(totalPages)), LocatorType.XPATH);

        string pageSizeOptionSelect = "//span[@class='-totalPages']/select";
        public UITable PageSizeOptionSelect => new UITable(ElementProperties.SetElementName(pageSizeOptionSelect, nameof(pageSizeOptionSelect)), LocatorType.XPATH);
        #endregion
    }
}
