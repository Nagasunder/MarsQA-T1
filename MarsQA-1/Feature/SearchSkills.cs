using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SearchSkills
    {
        // Enter the skill which you want to search
        [Given(@"Enter the skill which you want to search")]
        public void GivenEnterTheSkillWhichYouWantToSearch()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui small icon input search-box']/input")).SendKeys("Testing");
        }
        // Click on search to find related details
        [Given(@"Click on serach icon")]
        public void GivenClickOnSerachIcon()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='search link icon']")).Click();
        }
         // Choose the recent test result from list
        [Given(@"Click on recent search result")]
        public void GivenClickOnRecentSearchResult()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui card']/a[1]")).Click();
        }
        // Write message to seller
        [Given(@"Write message to seller")]
        public void GivenWriteMessageToSeller()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui teal  button']")).Click();
        }
        // Click OK to sent request
        [Then(@"Confirm the request sent")]
        public void ThenConfirmTheRequestSent()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui button ui teal button']")).Click();
        }

    }
}
