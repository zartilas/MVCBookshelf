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

        /* Authors Page */
        public static string authorsPageTitle = appName + " | Authors";

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