using OpenQA.Selenium;
using System;
using TestsByKonrad.testUtility;

namespace TestsByKonrad.pageObjects
{
    public class MainPage : CommonPage
    {
        private By signOutBtn = By.XPath("//*[@title='Log me out']");
        private By profileHeader = By.XPath("//h1[@class='page-heading']");
        private By searchInput = By.XPath("//*[@name='search_query']");
        private By foundProducts = By.XPath("//div[@class='product-container']");

        public void clickSignOutButton()
        {
            clickElement(signOutBtn);
        }

        public String getAccountHeader()
        {
            return getText(profileHeader);
        }

        public void searchPhrase(String phrase)
        {
            setValue(searchInput, phrase);
            IWebElement searchBar = Driver.getInstance().FindElement(searchInput);
            searchBar.SendKeys(Keys.Enter);
        }

        public int getNumberOfProductsFound()
        {
            var listOfProducts = Driver.getInstance().FindElements(foundProducts);
            return listOfProducts.Count;
        }
    }
}
