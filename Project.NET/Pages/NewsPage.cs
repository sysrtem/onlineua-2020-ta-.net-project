using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using Project.NET.tests;
using Project.NET.Pages;


namespace Project.NET.Pages
{
    public class NewsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@data-entityid,'top-stories')]//a/h3[contains(@class,'heading__title')]")]
        private IWebElement headLineArticleElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'top-stories')]//h3[contains(@class,'gel-pica-bold')]")]
        private IList<IWebElement> actualArticlesTitlesList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#1']//a/span[@aria-hidden]")]
        private IWebElement categotyLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement searchInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'wide')]//span[text()='Coronavirus']")] 
        private IWebElement coronavirusButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@aria-label,'close')]")]
        private IList<IWebElement> popup { get; set; }

        public NewsPage(IWebDriver driver) : base(driver)
        {

        }

        public string GetTextOfHeadLineArticleElement() => headLineArticleElement.Text;
        public IList<IWebElement> GetActualArticlesTitlesList() => actualArticlesTitlesList;
        public string GetCategotyLinkText() => categotyLink.Text;
        public void InputSearch(string input) { searchInputField.SendKeys(input); searchInputField.SendKeys(Keys.Enter); }
        public void ClickCoronavirusButton() => coronavirusButton.Click();
        public void ClosePopup() {
            if (popup.Count > 0 && popup[0].Displayed) 
             popup[0].Click();
        }
    }
}
