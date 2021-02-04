using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestsByKonrad.automationFramework;

namespace TestsByKonrad.pageObjects
{
    public class RegistrationPage : CommonPage
    {
        By firstNameInput = By.XPath("//*[@id='customer_firstname']");
        By lastNameInput = By.XPath("//*[@id='customer_lastname']");
        By passwordInput = By.XPath("//*[@id='passwd']");
        By daysPlist = By.XPath("//*[@id='days']");
        By monthPlist = By.CssSelector("#months");
        By yearsPlist = By.CssSelector("#years");
        By firstNameAddressInput = By.XPath("//*[@id='firstname']");
        By lastNameAddressInput = By.XPath("//*[@id='lastname']");
        By companyInput = By.CssSelector("#company");
        By addressInput = By.CssSelector("#address1");
        By cityInput = By.CssSelector("#city");
        By statePlist = By.CssSelector("#id_state");
        By postCodeInput = By.XPath("//*[contains(@id,'postcode')]");
        By countryPlist = By.XPath("//*[contains(@id,'uniform-id_country')]//select");
        By mobilePhoneInput = By.Id("phone_mobile");
        By aliasInput = By.Name("alias");
        By registerBtn = By.XPath("//*[text()='Register']");
        
        public void setAccountRequiredValues()
        {
            setValue(firstNameInput, TestData.firstName);
            setValue(lastNameInput, TestData.lastName);
            setValue(passwordInput, TestData.password);
            setValue(firstNameAddressInput, TestData.firstName);
            setValue(lastNameAddressInput, TestData.lastName);
            setValue(companyInput, TestData.company);
            setValue(addressInput, TestData.address);
            setValue(cityInput, TestData.city);
            setValue(postCodeInput, TestData.postCode);
            setValue(mobilePhoneInput, TestData.mobilePhone);
            setValue(aliasInput, TestData.addressAlias);
            setPicklistValue(daysPlist, TestData.birthDay);
            setPicklistValue(monthPlist, TestData.birthMonth);
            setPicklistValue(yearsPlist, TestData.birthYear);
            setPicklistText(statePlist, TestData.state);
            setPicklistText(countryPlist, TestData.country);
        }

        public void clickRegisterButton()
        {
            clickElement(registerBtn);
        }
    }
}
