using System;

namespace MVCBookshelf.Content.Values
{
    public static class Lang
    {
        public static String appName = "MVCBookshelf";

        /* Home/References Page*/
        public static String homePageTitle = appName + " | Home Page";
        public static String homePageButtonContactDetailsOfAuthors = "Contact details of authors";
        public static String homePageButtonOrderID = "Order ID number";
            public static string homePageModalContactDetailsOfAuthorsHeader = "Search for contact details of authors:";
            public static string homePageModalContactDetailsOfAuthorsFormPosNumLabel = "Position in leaderboards:";
            public static string homePageModalContactDetailsOfAuthorsFormPlaceholderPosNum = "Enter position number.";

        /* Error Page */
        public static String error404PageTitle = "404: Page not found | " + appName;
        public static String error404Header1 = "Oops!";
        public static String error404Header2 = "We can't seem to find the page\nyou are looking for.";
        public static String error404Header3 = "Error code: 404";

        /* Metadata */
        public const String metadataLastName = "LAST NAME";
        public const String metadataFirstName = "FIRST NAME";
        public const String metadataPhone = "PHONE NUMBER";
        public const String metadataAddress = "ADDRESS";
        public const String metadataCity = "CITY";
        public const String metadataState = "STATE";
        public const String metadataZip = "ZIP CODE";
        public const String metadataContract = "CONTRACT";

        /* Metadata Discounts*/
        public const String metadataHighqty= "HIGH ";
        public const String metadataLowqty = "LOW";
        public const String metadataStor_name = "STORE NAME";

        /* Metadata Employees*/
        public const String metadataMinit = "MINIT ";
        public const String metadataJob_lvl = "JOB LEVEL";
        public const String metadataHire_date = "DATE";
        public const String metadataJob_desc = "JOB";
        public const String metadataPub_name = "PUB NAME";

        /* Metadata Jobs*/
        public const String metadataMin_lvl = "MIN LEVEL";
        public const String metadataMax_lvl = "MAX LEVEL";

        /* Metadata Publishers*/
        public const String metadataCountry = "COUNTRY";
        public const String metadataPr_info = "PUBLISHERS INFO";

        /* Metadata Roysched*/
        public const String metadataTitle = "COUNTRY";
        public const String metadataRoyalty = "PUBLISHERS INFO";
        public const String metadataHirange = "COUNTRY";
        public const String metadataLorange = "PUBLISHERS INFO";

        /* Metadata Sales*/
        public const String metadataQty = "COUNTRY";
        public const String metadataPayterms = "PAY";
        public const String metadataOrd_date = "ORD";

        /* Metadata Store*/
        public const String metadataStor_address = "ADDRESS";

        /* Metadata Title Authors*/
        public const String metadataRoyaltyper = "ROYAL";
        public const String metadataAu_ord = "ORD";

        /* Metadata Title */
        public const String metadataType = "ROYAL";
        public const String metadataPrice= "ORD";
        public const String metadataAdvance = "ROYAL";
        public const String metadataYtd_sales = "ORD";
        public const String metadataNotes = "ROYAL";
        public const String metadataPubdate = "ORD";
        public const String metadataTitle_id = "ORD";

        /* Authors Page */
        public static String authorsPageTitle = appName + " | Authors";

        /* Discounts Page */
        public static String discountsPageTitle = appName + " | Discounts";

        /* Employees Page */
        public static String employeesPageTitle = appName + " | Discounts";

        /* Jobs Page */
        public static String jobsPageTitle = appName + " | Discounts";

        /* Publishers Page */
        public static String publishersPageTitle = appName + " | Discounts";

        /* Sales Page */
        public static String salesPageTitle = appName + " | Discounts";

        /* Stores Page */
        public static String storesPageTitle = appName + " | Discounts";

        /* TitleAuthor Page */
        public static String titleauthorPageTitle = appName + " | Discounts";

        /* Titles Page */
        public static String titlesPageTitle = appName + " | Discounts";

        /* Roysched Page */
        public static String royschedPageTitle = appName + " | Discounts";

        /* Navigation Menu */
        public static String navBarTitle = "LIBRARY";
        public static String navBarReferences = "References";
        public static String navBarAdministration = "Administration";
            public static String navBarAdministrationDropdownAuthors = "Authors";
            public static String navBarAdministrationDropdownDiscounts = "Discounts";
            public static String navBarAdministrationDropdownEmployees = "Employees";
            public static String navBarAdministrationDropdownJobs = "Jobs";
            public static String navBarAdministrationDropdownPublishers = "Publishers";
            public static String navBarAdministrationDropdownRoysched = "Roysched";
            public static String navBarAdministrationDropdownStores = "Stores";
            public static String navBarAdministrationDropdownSales = "Sales";
            public static String navBarAdministrationDropdownTitles = "Titles";
            public static String navBarAdministrationDropdownTitleAuthors = "Title Authors";

        /* Footer */
        public static String footerHeaderLocation = "Location";
        public static String footerHeaderContactDetails = "Contact Details";
        public static String footerHeaderAboutUs = "About Us";
        public static String footerDescriptionLocation = "80, M. Karaoli & A. Dimitriou St.\nPiraeus 18534, Greece";
        public static String footerDescriptionContactDetails = "Tel: 210 4142022\nFax: 210 4142330\nEmail: library @unipi.gr";
        public static String footerDescriptionAboutUs = "Welcome to the new portal of the Library.";
    }
}