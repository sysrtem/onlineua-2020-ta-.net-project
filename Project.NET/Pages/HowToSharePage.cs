using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using Project.NET.tests;
using Project.NET.Pages;

namespace Project.NET.Pages
{
    public class HowToSharePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'over 16')]/../../../input")] 
        IWebElement over16Checkbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        IWebElement submitButton { get; set; }        

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'accept')]/../../../input")] 
        IWebElement termsOfServiseCheckbox { get; set; }        

        [FindsBy(How = How.XPath, Using = "//div[@class='input-error-message']")]
        IWebElement errorMessage { get; set; }
        public HowToSharePage(IWebDriver driver) : base(driver)
        {

        }  

        public void ClickOver16Checkbox() => over16Checkbox.Click();
        public void ClickSubmitButton() => submitButton.Click();
        public void ClickTermsOfServiseCheckbox() => termsOfServiseCheckbox.Click();
        public string GetErrorMessageText() => errorMessage.Text;
    }
}
