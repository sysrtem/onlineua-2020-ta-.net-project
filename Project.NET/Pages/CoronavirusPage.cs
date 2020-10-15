using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using Project.NET.tests;
using Project.NET.Pages;
using OpenQA.Selenium;

namespace Project.NET.Pages
{
    public class CoronavirusPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'secondary')]//span[contains(text(),'Coronavirus')]")]
        private IWebElement yourCoronavirusButton { get; set; }        

        public CoronavirusPage(IWebDriver driver) : base(driver) 
        {  }

        public void ClickYourCoronavirusButton() => yourCoronavirusButton.Click();
        
    }
}
