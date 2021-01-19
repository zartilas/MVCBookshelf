using System;

namespace MVCBookshelf.Content.Values
{
    public static class Lang
    {
        /* General */
        public static readonly string appName = "MVCBookshelf";
        /* Forms */
        public static readonly string formInputSuccess = "MVCBookshelf";

        /* Home/References Page*/
        public static readonly string homePageTitle = appName + " | Home Page";
        public static readonly string homePageButtonContactDetailsOfAuthors = "Contact details of authors";
        public static readonly string homePageButtonOrderID = "Order ID number";
        /* References - Search contact details of authors with top sellers */
        public static readonly string homePageModal1Header = "Search for contact details of authors:";
        public static readonly string homePageModal1Desc = "Find the contact details of authors depending on the top selling titles (date is optional).";
        public static readonly string homePageModal1ButtonSearch = "Search";
        public static readonly string homePageModal1ButtonClose = "Close";
        /* Labels */
        public static readonly string homePageModal1FormTopNumLabel = "Top sellers position:";
        public static readonly string homePageModal1FormDateFromLabel = "Date From:";
        public static readonly string homePageModal1FormDateToLabel = "Date To:";
        /* Field Placeholders */
        public static readonly string homePageModal1FormPlaceholderTopNum = "Enter top sellers number (Ex: 5).";
        public static readonly string homePageModal1FormPlaceholderDateFrom = "Enter date to start (Ex: 2019-01-15).";
        public static readonly string homePageModal1FormPlaceholderDateTo = "Enter date to finish between (Ex: 2019-02-18).";


        /* Error Page */
        public static readonly string error404PageTitle = "404: Page not found | " + appName;
        public static readonly string error404Header1 = "Oops!";
        public static readonly string error404Header2 = "We can't seem to find the page\nyou are looking for.";
        public static readonly string error404Header3 = "Error code: 404";

        /* Metadata */
        public const string metadataLastName = "LAST NAME";
        public const string metadataFirstName = "FIRST NAME";
        public const string metadataMiddleNameInitials = "MIDDLE NAME INITIALS";
        public const string metadataPhone = "PHONE NUMBER";
        public const string metadataAddress = "ADDRESS";
        public const string metadataCity = "CITY";
        public const string metadataState = "STATE";
        public const string metadataZip = "ZIP CODE";
        public const string metadataContract = "CONTRACT";

        /* Metadata Discounts*/
        public const string metadataHighqty= "HIGH QUANTITY ";
        public const string metadataLowqty = "LOW QUANTITY";
        public const string metadataStor_name = "STORE NAME";

        /* Metadata Employees*/
        public const string metadataMinit = "MIDDLE NAME INITIALS ";
        public const string metadataJob_lvl = "JOB LEVEL";
        public const string metadataHire_date = "DATE";
        public const string metadataJob_desc = "JOB";
        public const string metadataPub_name = "PUBLISHER NAME";

        /* Metadata Jobs*/
        public const string metadataMin_lvl = "MIN LEVEL";
        public const string metadataMax_lvl = "MAX LEVEL";

        /* Metadata Publishers*/
        public const string metadataCountry = "COUNTRY";
        public const string metadataPr_info = "PUBLISHERS INFO";

        /* Metadata Roysched*/
        public const string metadataTitle = "COUNTRY";
        public const string metadataRoyalty = "PUBLISHERS INFO";
        public const string metadataHirange = "COUNTRY";
        public const string metadataLorange = "PUBLISHERS INFO";

        /* Metadata Sales*/
        public const string metadataQty = "COUNTRY";
        public const string metadataPayterms = "PAY TERMS";
        public const string metadataOrd_date = "ORDER DATE";

        /* Metadata Store*/
        public const string metadataStor_address = "ADDRESS";

        /* Metadata Title Authors*/
        public const string metadataRoyaltyper = "ROYALTYPER";
        public const string metadataAu_ord = "AYTHOR ORDER";

        /* Metadata Title */
        public const string metadataType = "TYPE";
        public const string metadataPrice= "PRICE";
        public const string metadataAdvance = "ADVANCE";
        public const string metadataYtd_sales = "YTD SALES";
        public const string metadataNotes = "NOTES";
        public const string metadataPubdate = "PUBLISHER DATE";
        public const string metadataTitle_id = "TITLE ID";

/* Authors Page */
        public static string authorsPageTitle = appName + " | Authors";
        /* Authors - ADD BUTTON */
        public static readonly string authorsPageModalCreateHeader = "Add a new author:";
        public static readonly string authorsPageModalCreateDesc = "Insert a new author to the database.";
        public static readonly string authorsPageModalCreateButtonSearch = "Add";
        public static readonly string authorsPageModalCreateButtonClose = "Close";
        /* Labels */
        public static readonly string authorsPageModalCreateFormFirstNameLabel = "First Name:";
        public static readonly string authorsPageModalCreateFormLastNameLabel = "Last Name:";
        public static readonly string authorsPageModalCreateFormMiddleNameInitLabel = "Middle Name Initials:";
        /* Field Placeholders */
        public static readonly string authorsPageModalCreateFormPlaceholderFirstName = "Ex: John";
        public static readonly string authorsPageModalCreateFormPlaceholderLastName = "Ex: Smith";
        public static readonly string authorsPageModalCreateFormPlaceholderMiddleNameInitials = "Ex: K (without dot)";
        public static readonly string authorsPageModalCreateFormPlaceholderPhone = "Ex: 99567181";
        public static readonly string authorsPageModalCreateFormPlaceholderCity = "Ex: Piraeus";
        public static readonly string authorsPageModalCreateFormPlaceholderZipCode = "Ex: 18534";
        public static readonly string authorsPageModalCreateFormPlaceholderAddress = "Ex: Karaoli kai dimitriou";
        public static readonly string authorsPageModalCreateFormPlaceholderState = "Ex: Attiki";
        public static readonly string authorsPageModalCreateFormPlaceholderContract = "Ex: ";


/* Discounts Page */
        public static string discountsPageTitle = appName + " | Discounts";

/* Employees Page */
        public static string employeesPageTitle = appName + " | Discounts";

/* Jobs Page */
        public static string jobsPageTitle = appName + " | Discounts";

/* Publishers Page */
        public static string publishersPageTitle = appName + " | Discounts";

/* Sales Page */
        public static string salesPageTitle = appName + " | Discounts";

/* Stores Page */
        public static string storesPageTitle = appName + " | Discounts";

        /* TitleAuthor Page */
        public static string titleauthorPageTitle = appName + " | Discounts";

        /* Titles Page */
        public static string titlesPageTitle = appName + " | Discounts";

        /* Roysched Page */
        public static string royschedPageTitle = appName + " | Discounts";

        /* Navigation Menu */
        public static string navBarTitle = "LIBRARY";
        public static string navBarReferences = "References";
        public static string navBarAdministration = "Administration";
        public static string navBarAdministrationDropdownAuthors = "Authors";
        public static string navBarAdministrationDropdownDiscounts = "Discounts";
        public static string navBarAdministrationDropdownEmployees = "Employees";
        public static string navBarAdministrationDropdownJobs = "Jobs";
        public static string navBarAdministrationDropdownPublishers = "Publishers";
        public static string navBarAdministrationDropdownRoysched = "Roysched";
        public static string navBarAdministrationDropdownStores = "Stores";
        public static string navBarAdministrationDropdownSales = "Sales";
        public static string navBarAdministrationDropdownTitles = "Titles";
        public static string navBarAdministrationDropdownTitleAuthors = "Title Authors";

        /* Footer */
        public static string footerHeaderLocation = "Location";
        public static string footerHeaderContactDetails = "Contact Details";
        public static string footerHeaderAboutUs = "About Us";
        public static string footerDescriptionLocation = "80, M. Karaoli & A. Dimitriou St.\nPiraeus 18534, Greece";
        public static string footerDescriptionContactDetails = "Tel: 210 4142022\nFax: 210 4142330\nEmail: library @unipi.gr";
        public static string footerDescriptionAboutUs = "Welcome to the new portal of the Library.";
    }
}