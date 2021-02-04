using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TestsByKonrad.automationFramework;
using TestsByKonrad.testUtility;

namespace TestsByKonrad.pageObjects
{
    public class SignInPage : CommonPage
    {
        private By createAccEmailInput = By.XPath("//input[@id='email_create']");
        private By createAnAccountBtn = By.XPath("//button[@id='SubmitCreate']");
        private By emailLoginInput = By.XPath("//*[@id='email']");
        private By passInput = By.XPath("//*[@id='passwd']");
        private By signInBtn = By.XPath("//*[@id='SubmitLogin']");
        private By profileHeader = By.XPath("//h1[@class='page-heading']");
        public void enterEmailAddressAndProceed(String emailAddress)
        {
            setValue(createAccEmailInput, emailAddress);
            clickElement(createAnAccountBtn);
        }

        public void logIn(String email, String password)
        {
            setValue(emailLoginInput, email);
            setValue(passInput, password);
            clickElement(signInBtn);
            waitUntilLoggedIn(profileHeader, 10);
        }

        public void waitUntilLoggedIn(By element, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getInstance(), TimeSpan.FromSeconds(timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }
    }
}
