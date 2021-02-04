using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestsByKonrad.pageObjects
{
    public class HomePage : CommonPage
    {
        private By signInBtn = By.XPath("//a[contains(text(),'Sign in')]");

        public void clickSignInButton()
        {
            clickElement(signInBtn);
        }
    }
}