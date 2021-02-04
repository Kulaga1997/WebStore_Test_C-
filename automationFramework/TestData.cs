using System;
using System.Collections.Generic;
using System.Text;

namespace TestsByKonrad.automationFramework
{
    public static class TestData
    {
        //ACCOUNT DATA
        public static readonly String emailAddress = "test" + GetTimestamp(DateTime.Now) + "@gmail.com";
        public static readonly String firstName = "testName";
        public static readonly String lastName = "lastName";
        public static readonly String password = "qwer1234";
        public static readonly String company = "Company";
        public static readonly String address = "Address";
        public static readonly String city = "City";
        public static readonly String state = "Alabama";
        public static readonly String country = "United States";
        public static readonly String postCode = "11111";
        public static readonly String mobilePhone = "123456789";
        public static readonly String birthDay = "1";
        public static readonly String birthMonth = "1";
        public static readonly String birthYear = "2010";
        public static readonly String addressAlias = "testAlias";
        public static readonly String profileHeader = "MY ACCOUNT";
        public static readonly String paymentMethodCheck = "bank wire";
        public static readonly String paymentMethodBankWire = "Pay by check";
        public static readonly String orderStatusMessage = "Your order on My Store is complete.";

        //PRODUCT DATA
        public static readonly String productName = "Dress";
        public static readonly String productFullName = "Printed Summer Dress";

        public static String GetTimestamp(this DateTime value)
        {
            return value.ToString("yyyyMMddHHmmss");
        }
    }
    
}
