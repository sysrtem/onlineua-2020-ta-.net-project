using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using SeleniumExtras.PageObjects;
using Project.NET.tests;
using Project.NET.Pages;

namespace Project.NET.tests
{
    [TestClass]
    public class ShareFormTests : BaseTest
    {
        private readonly Dictionary<string, string> INVALIDEMAIL = new Dictionary<string, string>()
        { {"Tell us your story. ", "Story"}, {"Name", "Name"}, {"Email address", "emailemail.com"}, {"Contact number ", "Number"}, {"Location ","Kyiv"} };

        private readonly Dictionary<string, string> VALIDDATA = new Dictionary<string, string>()
        { {"Tell us your story. ", "Story"}, {"Name", "Name"}, {"Email address", "email@email.com"}, {"Contact number ", "Number"}, {"Location ","Kyiv"} };

        private readonly Dictionary<string, string> EMPTYSTORY = new Dictionary<string, string>()
        { {"Name", "Name"}, {"Email address", "email@email.com"}, {"Contact number ", "Number"}, {"Location ","Kyiv"} };

        [TestMethod]
        public void CheckUserImposibilityToSubmitStoryWithoutTermsAccepted()
        {
            BusinessLogicLayer logic = new BusinessLogicLayer(Driver.DriverInstance);
            logic.GoToYourCoronavirusPageAndClickHowToShare();
            logic.FillInCheckboxes(true, false);
            logic.FillFormAndClickSubmit(VALIDDATA);
            Assert.Equals(logic.GetErrorMessage(), "must be accepted");
        }

        [TestMethod]
        public void CheckUserImposibilityToSubmitStoryWithInvalidEmail()
        {
            BusinessLogicLayer logic = new BusinessLogicLayer(Driver.DriverInstance);
            logic.GoToYourCoronavirusPageAndClickHowToShare();
            logic.FillInCheckboxes(true, true);
            logic.FillFormAndClickSubmit(INVALIDEMAIL);
            Assert.Equals(logic.GetErrorMessage(), "Email address is invalid");
        }

        [TestMethod]
        public void CheckUserImposibilityToSubmitEmptyStory()
        {
            BusinessLogicLayer logic = new BusinessLogicLayer(Driver.DriverInstance);
            logic.GoToYourCoronavirusPageAndClickHowToShare();
            logic.FillInCheckboxes(true, true);
            logic.FillFormAndClickSubmit(EMPTYSTORY);
            Assert.Equals(logic.GetErrorMessage(), "can't be blank");
        }

    }
}
