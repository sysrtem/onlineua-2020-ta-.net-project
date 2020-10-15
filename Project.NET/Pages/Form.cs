using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.NET.Pages
{
    public class Form : BasePage
    {        
        public Form(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement GetFormElement(string field) => driver.FindElement(By.XPath($"//*[contains(@placeholder,'{field}')]"));
        public void FillForm(Dictionary<string, string> fields)
        {
            foreach (var key in fields)
            {
                GetFormElement(key.Key).SendKeys(key.Value);
            }
        }
    }
}
