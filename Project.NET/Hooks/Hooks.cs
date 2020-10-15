using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project.NET.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Project.NET.Hooks
{
    [Binding]
    class Hooks
    {
        private static IWebDriver driver;
        private const string BBC_URL = "https://www.bbc.com";
        private readonly ScenarioContext _scenatioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenatioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp()
        {            
            driver = Driver.DriverInstance;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl(BBC_URL);            
        }

        [AfterScenario]
        public void TearDown()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}
