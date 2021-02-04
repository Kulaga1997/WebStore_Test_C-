using NUnit.Framework;
using System;
using TestsByKonrad.automationFramework;
using TestsByKonrad.testUtility;

namespace TestsByKonrad.testsContainer
{
    class Webstore_Test2__Placing_Order : setUpTests
    {
        [Test]
        public void placeAnOrder()
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

            Console.WriteLine("Step 6\t Search for a product using search bar");
            mainPage.searchPhrase(TestData.productName);

            Console.WriteLine("Step 7\t Verify number of products found");
            Assert.AreEqual(7, mainPage.getNumberOfProductsFound());

            Console.WriteLine("Step 8 \t Hover over one of products found and click Add to Cart button");
            shoppingPage.clickAddToCart(TestData.productFullName);

            Console.WriteLine("Step 8\t Proceed with the process until payment method selection");
            shoppingPage.goToCheckout();
            shoppingPage.clickProceedWithCart();
            shoppingPage.clickProceedWithCart();
            shoppingPage.setTermsServiceCbox();
            shoppingPage.clickProceedButton();

            Console.WriteLine("Step 9\t Select one of two payment methods");
            shoppingPage.selectPaymentMethod(TestData.paymentMethodCheck);

            Console.WriteLine("Step 10\t Click Confirm Order button");
            shoppingPage.clickConfirmOrderButton();

            Console.WriteLine("Step 11\t Validate Order Status message");
            Assert.AreEqual(TestData.orderStatusMessage, shoppingPage.getOrderStatusMessage());

        }
    }
}
