using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace Project.NET.Pages
{
    public class BusinessLogicLayer
    {
        private IWebDriver driver;

        public BusinessLogicLayer(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public void GoToTheNewsPage()
        {
            new NewsPage(Driver.DriverInstance).ClosePopup(); // ubrat' ---------------------------------------------
            new HomePage(Driver.DriverInstance).clickNewsButton();
            Waiters.WaitForPageLoad();
            new NewsPage(Driver.DriverInstance).ClosePopup();
        }
        public string GetArticleTitle()
        {            
            return new NewsPage(Driver.DriverInstance).GetTextOfHeadLineArticleElement();            
        }
        
        public List<string> GetFirstArticlesTitles()
        {            
            List<string> actual = new List<string>();
            foreach (IWebElement element in new NewsPage(Driver.DriverInstance).GetActualArticlesTitlesList())
            {
                actual.Add(element.Text);
            }
            return actual;       
        }
        
        public void SearchByTheCategoryLink()
        {
            var newspage = new NewsPage(Driver.DriverInstance);
            newspage.InputSearch(newspage.GetCategotyLinkText());
        }
        public string GetFirstArticleTitle()
        {                   
            return new SearchResultPage(Driver.DriverInstance).GetFirstElementInTheListText();
        }
        
        public void GoToYourCoronavirusPageAndClickHowToShare()
        {
            var newspage = new NewsPage(Driver.DriverInstance);
            newspage.ClosePopup();
            new HomePage(Driver.DriverInstance).clickNewsButton();
            Waiters.WaitForPageLoad();            
            newspage.ClosePopup();
            newspage.ClickCoronavirusButton();
            Waiters.WaitForPageLoad();
            new CoronavirusPage(Driver.DriverInstance).ClickYourCoronavirusButton();
            Waiters.WaitForPageLoad();
            new YourCoronavirusPage(Driver.DriverInstance).ClickHowToShareButton();
            Waiters.WaitForPageLoad();
        }
        public void FillInCheckboxes(bool yearscheckbox, bool termscheckbox)
        {
            var howto = new HowToSharePage(Driver.DriverInstance);
            if (yearscheckbox == true)
                howto.ClickOver16Checkbox();
            if (termscheckbox == true)
                howto.ClickTermsOfServiseCheckbox();
        }
        public void FillFormAndClickSubmit(Dictionary<string, string> dict)
        {
            new Form(Driver.DriverInstance).FillForm(dict);            
            new HowToSharePage(Driver.DriverInstance).ClickSubmitButton();
            Waiters.WaitForPageLoad();
        }        
        public string GetErrorMessage()
        {                        
            return new HowToSharePage(Driver.DriverInstance).GetErrorMessageText(); 
        }
    }
}   
