using System;

namespace MVCBookshelf.Content.Values
{
    public static class Lang
    {
        /* General */
        public const string appName = "MVCBookshelf";
        /* Forms */
        public const string formInputSuccess = "MVCBookshelf";
        public const string tablesNothingFoundHeader2 = "No data found.";
        public const string tablesNothingFoundHeader3 = "Click the button above to add a record.";

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

/* Database Metadata */
        /* Metadata Authors */
        public const string metadataLastName = "LAST NAME";
        public const string metadataFirstName = "FIRST NAME";
        public const string metadataPhone = "PHONE NUMBER";
        public const string metadataAddress = "ADDRESS";
        public const string metadataCity = "CITY";
        public const string metadataState = "STATE";
        public const string metadataZip = "ZIP CODE";
        public const string metadataContract = "CONTRACT";

        /* Metadata Discounts */
        public const string metadataHighqty = "HIGH QUANTITY";
        public const string metadataLowqty = "LOW QUANTITY";
        public const string metadataDiscount = "DISCOUNT";
        public const string metadataDiscountType = "DISCOUNT TYPE";

        /* Metadata Employees */
        public const string metadataMinit = "MIDDLE NAME INITIALS ";
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

        /* Authors Page */
        public const string authorsPageTitle = appName + " | Authors";
        /* Authors - ADD BUTTON */
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

/* Employees Page */
        public const string employeesPageTitle = appName + " | Discounts";

/* Jobs Page */
        public const string jobsPageTitle = appName + " | Discounts";

/* Publishers Page */
        public const string publishersPageTitle = appName + " | Discounts";

/* Sales Page */
        public const string salesPageTitle = appName + " | Discounts";

/* Stores Page */
        public const string storesPageTitle = appName + " | Discounts";

        /* TitleAuthor Page */
        public const string titleauthorPageTitle = appName + " | Discounts";

        /* Titles Page */
        public const string titlesPageTitle = appName + " | Discounts";

        /* Roysched Page */
        public const string royschedPageTitle = appName + " | Discounts";

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