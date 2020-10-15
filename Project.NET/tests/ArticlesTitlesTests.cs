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


namespace Project.NET.tests //done by Artem Polishchuk 
{
    [TestClass]
    public class ArticlesTitlesTests : BaseTest
    {
        private readonly string EXPECTEDHEADLINEARTICLE = "Trump and Biden duel in chaotic, bitter debate";
        private readonly List<string> EXPECTEDARTICLESTITLES = new List<string>() {
                "Watch: Supreme Court confirmation hearing",
                "Smoke from US wildfires spreads across country",
                "The unexpected rise of Japan's new prime minister",
                "Self-driving car operator charged over fatal crash",
                "New Melania Trump statue replaces burnt original",
                "'Catastrophic flooding' as Hurricane Sally hits US",
                "Gaza violence flares after Israel-Gulf agreements",
                "India passes five million Covid cases amid spike",
                "Criminal inquiry opened into John Bolton's book",
                "UK seeks to reassure US politicians over Brexit",
                "Criminal inquiry opened into John Bolton's book",
                "UK seeks to reassure US politicians over Brexit",
                "City to pay Breonna Taylor family $12m settlement",
                "Apple to launch get-fit service alongside new kit",
                "Cardi B files for divorce from Offset"
            };

        [TestMethod]
        public void CheckHeadLineaArticleName()
        {
            BusinessLogicLayer logic = new BusinessLogicLayer(Driver.DriverInstance);
            logic.GoToTheNewsPage();
            Assert.AreEqual(EXPECTEDHEADLINEARTICLE, logic.GetArticleTitle());
        }
        
        [TestMethod]
        public void CheckArticlesTitlesList()
        {
            BusinessLogicLayer logic = new BusinessLogicLayer(Driver.DriverInstance);
            logic.GoToTheNewsPage();
            int i = 0;
            foreach (string element in logic.GetFirstArticlesTitles())
            {
                Assert.AreEqual(EXPECTEDARTICLESTITLES[i], element);
                i++;
            }
        }
    }
}
