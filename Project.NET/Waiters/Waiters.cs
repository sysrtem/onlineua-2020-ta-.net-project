using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Project.NET.Pages
{
    public static class Waiters 
    {
        private static readonly int timeOut = 30; 
        
        public static void WaitForElementClickable(By xpath) 
        {
            WebDriverWait wait = new WebDriverWait(Driver.DriverInstance, new TimeSpan(0, 0, timeOut));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(xpath));
        }

        public static void WaitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(Driver.DriverInstance, new TimeSpan(0, 0, timeOut));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }        
    }
}
