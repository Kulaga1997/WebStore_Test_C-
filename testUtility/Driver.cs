using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.Collections.Generic;
using System.Text;

namespace TestsByKonrad.testUtility
{
    class Driver : setUpTests
    {
        public static void initialize(String browser)
        {
        switch(browser)
            {
                case "Chrome":
                    {
                        Console.WriteLine("Initializing ChromeDriver");
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        setDriver(new ChromeDriver());
                        break;
                    }
                case "Firefox":
                    {
                        setDriver(new FirefoxDriver());
                        break;
                    }
                case "Opera":
                    {
                        setDriver(new OperaDriver());
                        break;
                    }
            }
        }

        public static IWebDriver getInstance()
        {
            return driver;
        }

        public static void setDriver(IWebDriver driverType)
        {
            driver = driverType;
        }
    }
}