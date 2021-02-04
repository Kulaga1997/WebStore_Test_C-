using NUnit.Framework;
using System;
using TestsByKonrad.automationFramework;
using TestsByKonrad.testUtility;

namespace TestsByKonrad
{
    public class Tests : setUpTests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("Step 1\t Open Automation practice website");

            Console.WriteLine("Step 2\t Click Sign in button");
            homePage.clickSignInButton();

            Console.WriteLine("Step 3\t Enter Email address and click 'Create an account' button");
            signInPage.enterEmailAddressAndProceed(TestData.emailAddress);

            Console.WriteLine("Step 4\t Enter mandatory data for account creation");
            registrationPage.setAccountRequiredValues();

            Console.WriteLine("Step 5\t Click \"Register >\" button");
            registrationPage.clickRegisterButton();

            Console.WriteLine("Step 6\t Click \"Sign out >\" button");
            mainPage.clickSignOutButton();

            Console.WriteLine("Step 7\t Use previously created credentials to log into store");
            signInPage.logIn(TestData.emailAddress, TestData.password);

            Console.WriteLine("Step 8\t Use previously created credentials to log into store");
            Assert.AreEqual(TestData.profileHeader, mainPage.getAccountHeader());

            Console.WriteLine("Step 9\t SUCCESS");
        }
    }
}