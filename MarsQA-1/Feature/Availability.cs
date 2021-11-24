using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Availability
    {
        // Add avaiability to the profile page
        [Given(@"Add avaiability to the profile page")]
        public void GivenAddAvaiabilityToTheProfilePage()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated outline small write icon']")).Click();
            Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[2]")).Click();
        }
        //Add number of hours you can wook a week
        //[Given(@"Add number of hours you can wook a week")]
        //public void GivenAddNumberOfHoursYouCanWookAWeek()
        //{
        //    Driver.driver.FindElement(By.XPath("//*[@class='right floated outline small write icon']")).Click();
        //    Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[2]")).Click();
        //}
        //Add the taget earned in a month
        //[Then(@"Add the taget earned in a month")]
        //public void ThenAddTheTagetEarnedInAMonth()
        //{
        //    Driver.driver.FindElement(By.XPath("//*[@class='right floated outline small write icon']")).Click();
        //    Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[2]")).Click();
        //}
    }
}
