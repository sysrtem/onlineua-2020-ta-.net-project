using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.NET
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'links')]//a[text()='News']")]
        private IWebElement newsButton { get; set; }

        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        public void clickNewsButton () => newsButton.Click();

    }
}
