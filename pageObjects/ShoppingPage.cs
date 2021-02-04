using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestsByKonrad.testUtility;

namespace TestsByKonrad.pageObjects
{
    public class ShoppingPage : CommonPage

    {
        private By proceedToCheckoutBtn = By.XPath("//div//span[contains(text(),'Proceed to checkout')]/ancestor::button");
        private By proceedBtn = By.XPath("//*[text()='Proceed to checkout']" );
        private By checkoutBtn = By.XPath("//a[@title='Proceed to checkout']");
        private By termsOfServiceCbox = By.XPath("//input[@type='checkbox']");
        private By confirmOrderBtn = By.XPath("//span[text()='I confirm my order']");
        private By orderSuccessfullMessage = By.XPath("//*[@class='cheque-indent']/strong");
    public void clickAddToCart(String productName)
        {
            hoverOnElement(By.XPath("(//h5[@itemprop='name']/a[@title='" + productName + "' and @class='product-name'])[1]"));
            clickElement(By.XPath("(//*[@title='" + productName + "']/../following-sibling::div[@class='button-container']/a[@title='Add to cart'])[1]/span"));
        }

        public void clickProceedButton()
        {
            clickElement(proceedToCheckoutBtn);
        }

        public void clickProceedWithCart()
        {
            clickElement(proceedBtn);
        }

        public void goToCheckout()
        {
            clickElement(checkoutBtn);
        }

        public void setTermsServiceCbox()
        {
            setCheckbox(termsOfServiceCbox);
        }

        public void selectPaymentMethod(String paymentMethod)
        {
            clickElement(By.XPath("//a[contains(text(),'" + paymentMethod + "')]"));
        }

        public void clickConfirmOrderButton()
        {
            clickElement(confirmOrderBtn);
        }

        public String getOrderStatusMessage()
        {
            Console.WriteLine(getText(orderSuccessfullMessage));
            return getText(orderSuccessfullMessage);
        }
    }
}