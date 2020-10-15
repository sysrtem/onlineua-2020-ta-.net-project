using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using Project.NET.tests;
using Project.NET.Pages;

namespace Project.NET.Pages
{
    public class SearchResultPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'Stack')]/li[1]//a/span")]
        private IWebElement firstElementInTheList { get; set; }

        public SearchResultPage(IWebDriver driver) : base(driver)
        {

        }

        public string GetFirstElementInTheListText() => firstElementInTheList.Text;

    }
}
