using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.NET.Pages;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Project.NET.Features
{
    [Binding]
    public class ShareFormSteps
    {        
        private readonly BusinessLogicLayer logic = new BusinessLogicLayer(Driver.DriverInstance);

        [Given(@"user navigates to HowToShare page")]
        public void GivenUserNavigatesToHowToSharePage()
        {
            logic.GoToYourCoronavirusPageAndClickHowToShare();
        }
        
        [When(@"user confirm age ""(.*)"" and terms of cervice ""(.*)""")]
        public void WhenUserConfirmAgeAndTermsOfCervice(bool age, bool terms)
        {
            logic.FillInCheckboxes(age, terms);
        }
        
        [When(@"submit the story")]
        public void WhenSubmitTheStory(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            logic.FillFormAndClickSubmit(dictionary);

        }

        [When(@"submit the story with invalid email")]
        public void WhenSubmitTheStoryWithInvalidEmail(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            logic.FillFormAndClickSubmit(dictionary);
        }
        
        [When(@"submit the story with empty story field")]
        public void WhenSubmitTheStoryWithEmptyStoryField(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            logic.FillFormAndClickSubmit(dictionary);
        }

        [Then(@"the error message ""(.*)"" should appear")]
        public void ThenTheErrorMessageShouldAppear(string expectedErrorMessage)
        {
            Assert.AreEqual(logic.GetErrorMessage(), expectedErrorMessage);
        }

    }
}
