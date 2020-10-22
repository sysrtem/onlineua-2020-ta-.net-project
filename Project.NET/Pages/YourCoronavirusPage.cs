using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using Project.NET.tests;
using Project.NET.Pages;

namespace Project.NET.Pages
{
    public class YourCoronavirusPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'share')]/..")]
        IWebElement howToShareButton { get; set; }
           
        public YourCoronavirusPage(IWebDriver driver) : base(driver)
        {

        }

        public void ClickHowToShareButton() => howToShareButton.Click();

    }
}
