using System;

namespace MVCBookshelf.Content.Values
{
    public static class Lang
    {
    /* General - Global */
        public const string appName = "MVCBookshelf";
        public const string searchTextBox = "Search for something in table..";
        public const string searchInputPlaceholder = "Enter something.";
        /* Forms */
        public const string formInputSuccess = "MVCBookshelf";
        public const string tablesNothingFoundHeader2 = "No data found.";
        public const string tablesNothingFoundHeader3 = "Click the button above to add a record.";
        /* Buttons */
        public const string buttonSearch = "Search";
        public const string buttonClose = "Close";
        public const string buttonCreate = "Add";
        public const string buttonEdit = "Update";
        public const string buttonDelete = "Delete";

        /* Home/References Page*/
        public const string homePageTitle = appName + " | Home Page";
        public const string homePageButtonContactDetailsOfAuthors = "Contact details of authors";
        public const string homePageButtonOrderID = "Order ID number";
        /* References - Search contact details of authors with top sellers */
        public const string homePageModal1Header = "Search for contact details of authors:";
        public const string homePageModal1Desc = "Find the contact details of authors depending on the top selling titles (date is optional).";
        public const string homePageModal1ButtonSearch = "Search";
        public const string homePageModal1ButtonClose = "Close";
        /* Labels */
        public const string homePageModal1FormTopNumLabel = "Top sellers position:";
        public const string homePageModal1FormDateFromLabel = "Date From:";
        public const string homePageModal1FormDateToLabel = "Date To:";
        /* Field Placeholders */
        public const string homePageModal1FormPlaceholderTopNum = "Enter top sellers number (Ex: 5).";
        public const string homePageModal1FormPlaceholderDateFrom = "Enter date to start (Ex: 2019-01-15).";
        public const string homePageModal1FormPlaceholderDateTo = "Enter date to finish between (Ex: 2019-02-18).";

        /* Error Page */
        public const string error404PageTitle = "404: Page not found | " + appName;
        public const string error404Header1 = "Oops!";
        public const string error404Header2 = "We can't seem to find the page\nyou are looking for.";
        public const string error404Header3 = "Error code: 404";

    /* Authors Page */
        public const string authorsPageTitle = appName + " | Authors";
        public const string authorsPageHeader = "Authors Table";
        /* Create Page */
        public const string authorsPageCreateTitle = appName + " | Create Author";
        public const string authorsPageHeaderCreate = "Add a new author";
        /* Edit Page */
        public const string authorsPageEditTitle = appName + " | Edit Author";
        public const string authorsPageHeaderEdit = "Edit author";
        /* Delete Page */
        public const string authorsPageDeleteTitle = appName + " | Delete Author";
        public const string authorsPageHeaderDelete = "Delete author";
        public const string authorsPageHeaderDelete2 = "Are you sure you want to delete this author?";
        /* ADD BUTTON */
        public const string authorsPageButtonCreate = "Add a new author";
        /* Field Placeholders */
        public const string authorsPageFormPlaceholderFirstName = "Ex: John";
        public const string authorsPageFormPlaceholderLastName = "Ex: Smith";
        public const string authorsPageFormPlaceholderMiddleNameInitials = "Ex: K (without dot)";
        public const string authorsPageFormPlaceholderPhone = "Ex: 99567181";
        public const string authorsPageFormPlaceholderCity = "Ex: Piraeus";
        public const string authorsPageFormPlaceholderZipCode = "Ex: 18534";
        public const string authorsPageFormPlaceholderAddress = "Ex: Karaoli kai dimitriou";
        public const string authorsPageFormPlaceholderState = "Ex: Attiki";


    /* Discounts Page */
        public const string discountsPageTitle = appName + " | Discounts";
        public const string discountsPageHeader = "Discounts Table";
        /* Create Page */
        public const string discountsPageCreateTitle = appName + " | Create Discount";
        public const string discountsPageHeaderCreate = "Add a new discount";
        /* Edit Page */
        public const string discountPageEditTitle = appName + " | Edit Discount";
        public const string discountsPageHeaderEdit = "Edit discount";
        /* Delete Page */
        public const string discountsPageDeleteTitle = appName + " | Delete Discount";
        public const string discountsPageHeaderDelete = "Delete discount";
        public const string discountsPageHeaderDelete2 = "Are you sure you want to delete this discount?";
        /* BUTTONS */
        public const string discountsPageButtonCreate = "Add a new discount";
        /* Field Placeholders */
        public const string discountsPageFormPlaceholderDiscountType = "Ex: Initial Customer";
        public const string discountsPageFormPlaceholderStoreID = "Ex: 8042";
        public const string discountsPageFormPlaceholderLowQty = "Ex: 100";
        public const string discountsPageFormPlaceholderHighQty = "Ex: 1000";
        public const string discountsPageFormPlaceholderDiscount = "Ex: 10.65";

    /* Employees Page */
        public const string employeesPageTitle = appName + " | Employees";
        public const string employeesPageHeader = "Employees Table";
        /* Create Page */
        public const string employeesPageCreateTitle = appName + " | Create Employee";
        public const string employeesPageHeaderCreate = "Add a new employee";
        /* Edit Page */
        public const string employeesPageEditTitle = appName + " | Edit Employee";
        public const string employeesPageHeaderEdit = "Edit employee";
        /* Delete Page */
        public const string employeesPageDeleteTitle = appName + " | Delete Employee";
        public const string employeesPageHeaderDelete = "Delete employee";
        public const string employeesPageHeaderDelete2 = "Are you sure you want to delete this employee?";
        /* BUTTONS */
        public const string employeePageButtonCreate = "Add a new employee";
        /* Field Placeholders */
        public const string employeesPageFormPlaceholderFirstName = "Ex: Paolo";
        public const string employeesPageFormPlaceholderLastName = "Ex: Accorti";
        public const string employeesPageFormPlaceholderMinit = "Ex: M";
        public const string employeesPageFormPlaceholderJobId = "Ex: 2";
        public const string employeesPageFormPlaceholderJobLVL = "Ex: 35";
        public const string employeesPageFormPlaceholderPubId = "Ex: 0877";

    /* Jobs Page */
        public const string jobsPageTitle = appName + " | Jobs";
        public const string jobsPageHeader = "Jobs Table";
        /* Create Page */
        public const string jobsPageCreateTitle = appName + " | Create Job";
        public const string jobsPageHeaderCreate = "Add a new job";
        /* Edit Page */
        public const string jobsPageEditTitle = appName + " | Edit Job";
        public const string jobsPageHeaderEdit = "Edit job";
        /* Delete Page */
        public const string jobsPageDeleteTitle = appName + " | Delete Job";
        public const string jobsPageHeaderDelete = "Delete job";
        public const string jobsPageHeaderDelete2 = "Are you sure you want to delete this job?";
        /* BUTTONS */
        public const string jobsPageButtonCreate = "Add a new job";
        /* Field Placeholders */
        public const string jobsPageFormPlaceholderJobDesc = "Ex: Editor";
        public const string jobsPageFormPlaceholderMinLvl = "Ex: 10";
        public const string jobsPageFormPlaceholderMaxLvl = "Ex: 150";

    /* Publishers Page */
        public const string publishersPageTitle = appName + " | Publishers";
        public const string publishersPageHeader = "Publishers Table";
        /* Create Page */
        public const string publishersPageCreateTitle = appName + " | Create Publisher";
        public const string publishersPageHeaderCreate = "Add a new publisher";
        /* Edit Page */
        public const string publishersPageEditTitle = appName + " | Edit Publisher";
        public const string publishersPageHeaderEdit = "Edit publisher";
        /* Delete Page */
        public const string publishersPageDeleteTitle = appName + " | Delete Publisher";
        public const string publishersPageHeaderDelete = "Delete publisher";
        public const string publishersPageHeaderDelete2 = "Are you sure you want to delete this publisher?";
        /* BUTTONS */
        public const string publishersPageButtonCreate = "Add a new publisher";
        /* Field Placeholders */
        public const string publishersPageFormPlaceholderPubName = "Ex: Name of publisher";
        public const string publishersPageFormPlaceholderCity = "Ex: Boston";
        public const string publishersPageFormPlaceholderState = "Ex: MA";
        public const string publishersPageFormPlaceholderCountry = "Ex: USA";

    /* Sales Page */
        public const string salesPageTitle = appName + " | Sales";
        public const string salesPageHeader = "Sales Table";
        /* Create Page */
        public const string salesPageCreateTitle = appName + " | Create Sale";
        public const string salesPageHeaderCreate = "Add a new sale";
        /* Edit Page */
        public const string salesPageEditTitle = appName + " | Edit Sale";
        public const string salesPageHeaderEdit = "Edit sale";
        /* Delete Page */
        public const string salesPageDeleteTitle = appName + " | Delete Sale";
        public const string salesPageHeaderDelete = "Delete sale";
        public const string salesPageHeaderDelete2 = "Are you sure you want to delete this sale?";
        /* BUTTONS */
        public const string salesPageButtonCreate = "Add a new sale";
        /* Field Placeholders */
        public const string salesPageFormPlaceholderStoreId = "Ex: 6300";
        public const string salesPageFormPlaceholderOrdNum = "Ex: 6871";
        public const string salesPageFormPlaceholderOrdDate = "Ex: 14-09-2020";
        public const string salesPageFormPlaceholderQty = "Ex: 5";
        public const string salesPageFormPlaceholderTitleId = "Ex: BU1032";

    /* Stores Page */
        public const string storesPageTitle = appName + " | Stores";
        public const string storesPageHeader = "Stores Table";
        /* Create Page */
        public const string storesPageCreateTitle = appName + " | Create Store";
        public const string storesPageHeaderCreate = "Add a new store";
        /* Edit Page */
        public const string storesPageEditTitle = appName + " | Edit Store";
        public const string storesPageHeaderEdit = "Edit store";
        /* Delete Page */
        public const string storesPageDeleteTitle = appName + " | Delete Store";
        public const string storesPageHeaderDelete = "Delete store";
        public const string storesPageHeaderDelete2 = "Are you sure you want to delete this store?";
        /* BUTTONS */
        public const string storesPageButtonCreate = "Add a new store";
        /* Field Placeholders */
        public const string storesPageFormPlaceholderStoreName = "Ex: Name of store";
        public const string storesPageFormPlaceholderStoreAddress = "Ex: 788 Avenue St.";
        public const string storesPageFormPlaceholderCity = "Ex: Seattle";
        public const string storesPageFormPlaceholderState = "Ex: WA";
        public const string storesPageFormPlaceholderZip = "Ex: 98056";

    /* Title Authors Page */
        public const string titleAuthorsPageTitle = appName + " | Title Authors";
        public const string titleAuthorsPageHeader = "Title Authors Table";
        /* Create Page */
        public const string titleAuthorsPageCreateTitle = appName + " | Create Title Author";
        public const string titleAuthorsPageHeaderCreate = "Add a new title author";
        /* Edit Page */
        public const string titleAuthorsPageEditTitle = appName + " | Edit Title Author";
        public const string titleAuthorsPageHeaderEdit = "Edit title author";
        /* Delete Page */
        public const string titleAuthorsPageDeleteTitle = appName + " | Delete Title Author";
        public const string titleAuthorsPageHeaderDelete = "Delete title author";
        public const string titleAuthorsPageHeaderDelete2 = "Are you sure you want to delete this title author?";
        /* BUTTONS */
        public const string titleAuthorsPageButtonCreate = "Add a new title author";
        /* Field Placeholders */
        public const string titleAuthorsPageFormPlaceholderAuthorId = "Ex: 172-32-1176";
        public const string titleAuthorsPageFormPlaceholderTitleId = "Ex: PS3333";
        public const string titleAuthorsPageFormPlaceholderAuthorOrder = "Ex: 1";
        public const string titleAuthorsPageFormPlaceholderRoyalTyper = "Ex: 100";

    /* Titles Page */
        public const string titlesPageTitle = appName + " | Titles";
        public const string titlesPageHeader = "Titles Table";
        /* Create Page */
        public const string titlesPageCreateTitle = appName + " | Create Title";
        public const string titlesPageHeaderCreate = "Add a new title";
        /* Edit Page */
        public const string titlesPageEditTitle = appName + " | Edit Title";
        public const string titlesPageHeaderEdit = "Edit title";
        /* Delete Page */
        public const string titlesPageDeleteTitle = appName + " | Delete Title";
        public const string titlesPageHeaderDelete = "Delete title";
        public const string titlesPageHeaderDelete2 = "Are you sure you want to delete this title?";
        /* BUTTONS */
        public const string titlesPageButtonCreate = "Add a new title";
        /* Field Placeholders */
        public const string titlesPageFormPlaceholderTitle = "Ex: Title name";
        public const string titlesPageFormPlaceholderType = "Ex: Psychology";
        public const string titlesPageFormPlaceholderPubId = "Ex: 1389";
        public const string titlesPageFormPlaceholderPrice = "Ex: 19.99";
        public const string titlesPageFormPlaceholderAdvance = "Ex: 5000.0";
        public const string titlesPageFormPlaceholderRoyalty = "Ex: 10";
        public const string titlesPageFormPlaceholderYtdSales = "Ex: 4602";
        public const string titlesPageFormPlaceholderPubDate = "Ex: 06-12-1998";

    /* Roysched Page */
        public const string royschedPageTitle = appName + " | Royscheds";
        public const string royschedPageHeader = "Roysched Table";
        /* Create Page */
        public const string royschedPageCreateTitle = appName + " | Create Roysched";
        public const string royschedPageHeaderCreate = "Add a new roysched";
        /* Edit Page */
        public const string royschedPageEditTitle = appName + " | Edit Roysched";
        public const string royschedPageHeaderEdit = "Edit roysched";
        /* Delete Page */
        public const string royschedPageDeleteTitle = appName + " | Delete Roysched";
        public const string royschedPageHeaderDelete = "Delete roysched";
        public const string royschedPageHeaderDelete2 = "Are you sure you want to delete this roysched?";
        /* BUTTONS */
        public const string royschedPageButtonCreate = "Add a new roysched";
        /* Field Placeholders */
        public const string royschedPageFormPlaceholderTitleId = "Ex: BU1032";
        public const string royschedPageFormPlaceholderLorange = "Ex: 0";
        public const string royschedPageFormPlaceholderHirange = "Ex: 5000";
        public const string royschedPageFormPlaceholderRoyalty = "Ex: 10";

        /* Database Metadata */
        public const string metadataRequiredField = "This field is required";
        /* Metadata Authors */
        public const string metadataAuthorId = "AUTHOR ID";
        public const string metadataLastName = "LAST NAME";
        public const string metadataFirstName = "FIRST NAME";
        public const string metadataPhone = "PHONE NUMBER";
        public const string metadataAddress = "ADDRESS";
        public const string metadataCity = "CITY";
        public const string metadataState = "STATE";
        public const string metadataZip = "ZIP CODE";
        public const string metadataContract = "CONTRACT";

        /* Metadata Discounts */
        public const string metadataStoreId = "STORE ID";
        public const string metadataHighqty = "HIGH QUANTITY";
        public const string metadataLowqty = "LOW QUANTITY";
        public const string metadataDiscount = "DISCOUNT";
        public const string metadataDiscountType = "DISCOUNT TYPE";

        /* Metadata Employees */
        public const string metadataEmployeeId = "EMPLOYEE ID";
        public const string metadataMinit = "MIDDLE NAME INITIALS";
        public const string metadataJobId = "JOB ID";
        public const string metadataJobLvl = "JOB LEVEL";
        public const string metadataPubId = "PUB ID";
        public const string metadataHireDate = "DATE HIRED";
        public const string metadataPubName = "PUBLISHER NAME";

        /* Metadata Jobs */
        public const string metadataMinLvl = "MIN LEVEL";
        public const string metadataMaxLvl = "MAX LEVEL";
        public const string metadataJobDesc = "JOB DESCRIPTION";

        /* Metadata Publishers */
        public const string metadataCountry = "COUNTRY";
        public const string metadataPubInfo = "PUBLISHER INFO";

        /* Metadata Roysched */
        public const string metadataTitleId = "TITLE ID";
        public const string metadataTitle = "TITLE";
        public const string metadataRoyalty = "ROYALTY";
        public const string metadataHirange = "HIGH RANGE";
        public const string metadataLorange = "LOW RANGE";

        /* Metadata Sales */
        public const string metadataQuantity = "QUANTITY";
        public const string metadataPayTerms = "PAY TERMS";
        public const string metadataOrderDate = "ORDER DATE";
        public const string metadataOrderNumber = "ORDER NUMBER";

        /* Metadata Stores */
        public const string metadataStoreAddress = "STORE ADDRESS";
        public const string metadataStoreName = "STORE NAME";

        /* Metadata Title Authors */
        public const string metadataRoyaltyper = "ROYALTYPER";
        public const string metadataAuthorOrder = "AYTHOR ORDER";

        /* Metadata Titles */
        public const string metadataType = "TYPE";
        public const string metadataPrice = "PRICE";
        public const string metadataAdvance = "ADVANCE";
        public const string metadataYtdSales = "YTD SALES";
        public const string metadataNotes = "NOTES";
        public const string metadataPubDate = "PUBLISHER DATE";
        public const string metadataTitleID = "TITLE ID";

    /* Navigation Menu */
        public const string navBarTitle = "LIBRARY";
        public const string navBarReferences = "References";
        public const string navBarAdministration = "Administration";
        public const string navBarAdministrationDropdownAuthors = "Authors";
        public const string navBarAdministrationDropdownDiscounts = "Discounts";
        public const string navBarAdministrationDropdownEmployees = "Employees";
        public const string navBarAdministrationDropdownJobs = "Jobs";
        public const string navBarAdministrationDropdownPublishers = "Publishers";
        public const string navBarAdministrationDropdownRoysched = "Roysched";
        public const string navBarAdministrationDropdownStores = "Stores";
        public const string navBarAdministrationDropdownSales = "Sales";
        public const string navBarAdministrationDropdownTitles = "Titles";
        public const string navBarAdministrationDropdownTitleAuthors = "Title Authors";

        /* Footer */
        public const string footerHeaderLocation = "Location";
        public const string footerHeaderContactDetails = "Contact Details";
        public const string footerHeaderAboutUs = "About Us";
        public const string footerDescriptionLocation = "80, M. Karaoli & A. Dimitriou St.\nPiraeus 18534, Greece";
        public const string footerDescriptionContactDetails = "Tel: 210 4142022\nFax: 210 4142330\nEmail: library @unipi.gr";
        public const string footerDescriptionAboutUs = "Welcome to the new portal of the Library.";
    }
}