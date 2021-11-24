using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Hours
    {
        //Add number of hours you can wook a week
        [Given(@"Add number of hours avaliable per week")]
        public void GivenAddNumberOfHoursAvaliablePerWeek()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui list']/div[3]/div/span/i")).Click();
           Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[4]")).Click();
        }
    }
}
