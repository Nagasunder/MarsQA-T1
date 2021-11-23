using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ViewTheSentRequest
    {

        //Click on Manage request
        [Given(@"Click on Manage request")]
        public void GivenClickOnManageRequest()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown link item']")).Click();
        }
        //Choose Sent request
        [Given(@"Choose Sent request")]
        public void GivenChooseSentRequest()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='menu transition visible']/a[2]")).Click();
        }
        //Withdraw the request sent
        [Then(@"Withdraw the request sent")]
        public void ThenWithdrawTheRequestSent()
        {
            Driver.driver.FindElement(By.XPath("//Button[@class='ui negative basic button']")).Click();
        }
    }
}
