using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestsByKonrad.testUtility;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace TestsByKonrad.pageObjects
{
    public class CommonPage
    {
        public void clickElement(By element)
        {
            new WebDriverWait(Driver.getInstance(), TimeSpan.FromSeconds(15)).Until
                (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
            IWebElement clickedElement = Driver.getInstance().FindElement(element);
            clickedElement.Click();
        }

        public void setValue(By locator, String value)
        {
            new WebDriverWait(Driver.getInstance(), TimeSpan.FromSeconds(15)).Until
                (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            IWebElement inputElement = Driver.getInstance().FindElement(locator);
            inputElement.Click();
            inputElement.Clear();
            inputElement.SendKeys(value);
        }

        public void setPicklistValue(By picklist, String picklistValue)
        {
            SelectElement plist = new SelectElement(Driver.getInstance().FindElement(picklist));
            plist.SelectByValue(picklistValue);
        }

        public void setPicklistText(By picklist, String picklistText)
        {
            SelectElement plist = new SelectElement(Driver.getInstance().FindElement(picklist));
            plist.SelectByText(picklistText);
        }

        public String getText(By element)
        {
            new WebDriverWait(Driver.getInstance(), TimeSpan.FromSeconds(15)).Until
                (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
            IWebElement textContainer = Driver.getInstance().FindElement(element);
            Console.WriteLine(textContainer.Text);
            return textContainer.Text;
        }

        public void hoverOnElement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getInstance(), TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            Actions action = new Actions(Driver.getInstance());
            action.MoveToElement(element).Perform();
        }

        public void setCheckbox(By locator)
        {
            IWebElement cBox = Driver.getInstance().FindElement(locator);
            if (!cBox.Selected)
                cBox.Click();
        }
    }
}
