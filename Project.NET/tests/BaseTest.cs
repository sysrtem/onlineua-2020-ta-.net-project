using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using Project.NET.tests;
using Project.NET.Pages;

namespace Project.NET.tests
{
    [TestClass]
    public class BaseTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUP()
        {
            driver = Driver.DriverInstance;
        }

        [TestCleanup]
        public void TearDown()
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("test screenshot.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }
    }
}
