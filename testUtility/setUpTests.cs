using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestsByKonrad.pageObjects;

namespace TestsByKonrad.testUtility
{
    public class setUpTests
    {
        protected HomePage homePage = new HomePage();
        protected SignInPage signInPage = new SignInPage();
        protected RegistrationPage registrationPage = new RegistrationPage();
        protected MainPage mainPage = new MainPage();
        protected ShoppingPage shoppingPage = new ShoppingPage();

        protected static IWebDriver driver;
        [SetUp]
        public void openBrowser()
        {
            Driver.initialize("Chrome");
            driver.Url = "http://automationpractice.com/index.php";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}
