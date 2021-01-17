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

        /* Authors Page */
        public static String authorsPageTitle = appName + " | Authors";

        /* Discounts Page */
        public static String discountsPageTitle = appName + " | Discounts";

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