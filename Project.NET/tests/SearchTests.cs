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
    public class SearchTests : BaseTest
    {
        private readonly string EXPECTEDARTICLENAME = "US election 2020: What do polls say about Trump v Biden?";
        [TestMethod]
        public void CheckSearchCategoryLink()
        {
            BusinessLogicLayer logic = new BusinessLogicLayer(Driver.DriverInstance);
            logic.GoToTheNewsPage();
            logic.SearchByTheCategoryLink();
            Assert.AreEqual(EXPECTEDARTICLENAME, logic.GetFirstArticleTitle());
        }
    }
}
