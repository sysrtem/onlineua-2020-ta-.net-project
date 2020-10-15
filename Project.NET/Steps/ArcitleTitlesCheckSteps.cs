using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.NET.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Project.NET.Features
{
    [Binding]
    public class ArcitleTitlesCheckSteps
    {
        private readonly ScenarioContext _scenatioContext;
        private readonly BusinessLogicLayer logic = new BusinessLogicLayer(Driver.DriverInstance);

        public ArcitleTitlesCheckSteps(ScenarioContext scenatioContext)
        {
            _scenatioContext = scenatioContext;            
        }

        [Given(@"user navigate to the NewsPage")]
        public void GivenUserNavigateToTheNewsPage()
        {
            logic.GoToTheNewsPage();
        }
        
        [When(@"user get the headline article's title")]
        public void WhenUserGetTheHeadlineArticleSTitle()
        {
            _scenatioContext.Add("headlineArticleTitle", logic.GetArticleTitle());
        }
        
        [When(@"user get a list of secondary articles titles")]
        public void WhenUserGetAListOfSecondaryArticlesTitles()
        {
            _scenatioContext.Add("secondaryArticlesTitles", logic.GetFirstArticlesTitles()); 
        }

        [When(@"user search by category link")]
        public void WhenUserSearchByCategoryLink()
        {
            logic.SearchByTheCategoryLink();
        }        
        
        [Then(@"the headline article's title is ""(.*)""")]
        public void ThenTheHeadlineArticleSTitleIs(string title)
        {
            Assert.IsTrue(_scenatioContext.Get<string>("headlineArticleTitle").Contains(title), "The head article's title is incorrect");
        }
        
        [Then(@"secondary articles titles correspond")]
        public void ThenSecondaryArticlesTitlesCorrespond(Table articles)
        {
            List<string> secondaryArticlesTitles = _scenatioContext.Get<List<string>>("secondaryArticlesTitles");
            List<string> expectedArticles = new List<string>();
            foreach (var article in articles.Rows)
            {                
                expectedArticles.Add(article[0]);
            }
            //Assert.IsTrue(secondaryArticlesTitles.SequenceEqual(expectedArticles));
            int i = 0;
            foreach (string element in secondaryArticlesTitles)
            {
                Assert.AreEqual(expectedArticles[i], element);
                i++;
            }
        }
        
        [Then(@"the first article's title is ""(.*)""")]
        public void ThenTheFirstArticleSTitleIs(string expectedTitle)
        {
            Assert.IsTrue(logic.GetFirstArticleTitle().Contains(expectedTitle), "The first article's title is incorrect");
        }
    }
}
