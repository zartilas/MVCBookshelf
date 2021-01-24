using System;

namespace MVCBookshelf.Content.Values
{
    public static class Lang
    {
    /* General - Global */
        public const string appName = "MVCBookshelf";
        public const string searchTextBox = "Search for something in table..";
        /* Forms */
        public const string formInputSuccess = "MVCBookshelf";
        public const string tablesNothingFoundHeader2 = "No data found.";
        public const string tablesNothingFoundHeader3 = "Click the button above to add a record.";
        /* Buttons */
        public const string buttonSearch = "Search";
        public const string buttonClose = "Close";
        public const string buttonCreate = "Add";
        public const string buttonEdit = "Update";
        public const string buttonCancel = "Cancel";
        public const string buttonDelete = "Delete";
        public const string buttonActionOk = "OK";

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
        public const string authorsPageCreateTitle = appName + " | Create Author";
        public const string authorsPageEditTitle = appName + " | Edit Author";
        public const string authorsPageDeleteTitle = appName + " | Delete Author";
        public const string authorsPageHeaderCreate = "Add a new author";
        public const string authorsPageHeaderEdit = "Edit author";
        public const string authorsPageHeaderDelete = "Delete author";
        public const string authorsPageHeaderDelete2 = "Are you sure you want to delete this author?";
        public const string authorsPageHeader = "Authors Table";
        /* Authors - ADD BUTTON */
        public const string authorsPageButtonCreate = "Add a new author";
        public const string authorsPageModalCreateHeader = "Add a new author:";
        public const string authorsPageModalCreateDesc = "Insert a new author to the database.";
        public const string authorsPageModalCreateButtonSearch = "Add";
        public const string authorsPageModalCreateButtonClose = "Close";
        /* Labels */
        public const string authorsPageModalFormFirstNameLabel = "First Name:";
        public const string authorsPageModalFormLastNameLabel = "Last Name:";
        public const string authorsPageModalFormPhoneLabel = "Phone Number:";
        public const string authorsPageModalFormAddressLabel = "Address:";
        public const string authorsPageModalFormCityLabel = "City:";
        public const string authorsPageModalFormStateLabel = "State:";
        public const string authorsPageModalFormZipCodeLabel = "Zip Code:";
        public const string authorsPageModalFormContractLabel = "On Contract:";
        /* Field Placeholders */
        public const string authorsPagePlaceholderSearch = "Enter author name.";
        public const string authorsPageModalFormPlaceholderFirstName = "Ex: John";
        public const string authorsPageModalFormPlaceholderLastName = "Ex: Smith";
        public const string authorsPageModalFormPlaceholderMiddleNameInitials = "Ex: K (without dot)";
        public const string authorsPageModalFormPlaceholderPhone = "Ex: 99567181";
        public const string authorsPageModalFormPlaceholderCity = "Ex: Piraeus";
        public const string authorsPageModalFormPlaceholderZipCode = "Ex: 18534";
        public const string authorsPageModalFormPlaceholderAddress = "Ex: Karaoli kai dimitriou";
        public const string authorsPageModalFormPlaceholderState = "Ex: Attiki";


    /* Discounts Page */
        public const string discountsPageTitle = appName + " | Discounts";
        public const string discountsPageCreateTitle = appName + " | Create Discount";
        public const string discountsPageEditTitle = appName + " | Edit Discount";
        public const string discountsPageDeleteTitle = appName + " | Delete Discount";
        public const string discountsPageHeader = "Discounts Table";
        /* BUTTONS */
        public const string discountsPageButtonCreate = "Add a new discount";
        /* Field Placeholders */
        public const string discountsPagePlaceholderSearch = "Enter discount type.";

    /* Employees Page */
        public const string employeesPageTitle = appName + " | Discounts";
        public const string employeesPageHeader = "Employees Table";
        /* BUTTONS */
        public const string employeePageButtonCreate = "Add a new employee";
        /* Field Placeholders */
        public const string employeesPagePlaceholderSearch = "Enter employee name.";

    /* Jobs Page */
        public const string jobsPageTitle = appName + " | Discounts";
        public const string jobsPageHeader = "Jobs Table";
        /* BUTTONS */
        public const string jobsPageButtonCreate = "Add a new job";
        /* Field Placeholders */
        public const string jobsPagePlaceholderSearch = "Enter job name.";

    /* Publishers Page */
        public const string publishersPageTitle = appName + " | Discounts";
        public const string publishersPageHeader = "Publishers Table";
        /* BUTTONS */
        public const string publishersPageButtonCreate = "Add a new publisher";
        /* Field Placeholders */
        public const string publishersPagePlaceholderSearch = "Enter publisher name.";

    /* Sales Page */
        public const string salesPageTitle = appName + " | Discounts";
        public const string salesPageHeader = "Sales Table";
        /* BUTTONS */
        public const string salesPageButtonCreate = "Add a new sale";
        /* Field Placeholders */
        public const string salesPagePlaceholderSearch = "Enter something.";

    /* Stores Page */
        public const string storesPageTitle = appName + " | Discounts";
        public const string storesPageHeader = "Stores Table";
        /* BUTTONS */
        public const string storePageButtonCreate = "Add a new store";
        /* Field Placeholders */
        public const string storesPagePlaceholderSearch = "Enter store name.";

    /* TitleAuthor Page */
        public const string titleAuthorPageTitle = appName + " | Discounts";
        public const string titleAuthorPageHeader = "Title Author Table";
        /* BUTTONS */
        public const string titleAuthorPageButtonCreate = "Add a new title author";
        /* Field Placeholders */
        public const string titleAuthorPagePlaceholderSearch = "Enter author name.";

    /* Titles Page */
        public const string titlesPageTitle = appName + " | Discounts";
        public const string titlesPageHeader = "Titles Table";
        /* BUTTONS */
        public const string titlesPageButtonCreate = "Add a new title";
        /* Field Placeholders */
        public const string titlesPagePlaceholderSearch = "Enter title name.";

    /* Roysched Page */
        public const string royschedPageTitle = appName + " | Discounts";
        public const string royschedPageHeader = "Roysched Table";
        /* BUTTONS */
        public const string royschedPageButtonCreate = "Add a new roysched";
        /* Field Placeholders */
        public const string royschedPagePlaceholderSearch = "Enter something.";

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