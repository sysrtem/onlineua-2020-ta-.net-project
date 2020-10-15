using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.NET
{
    public static class Driver
    {
        private static IWebDriver driver;
        private const string BBC_URL = "https://www.bbc.com";

        public static IWebDriver DriverInstance
        {
            get
            {
                if(driver == null)
                {
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                    driver.Navigate().GoToUrl(BBC_URL);
                }
                return driver;
            }
            set
            {
                driver = value;
            }
        }
    }
}
