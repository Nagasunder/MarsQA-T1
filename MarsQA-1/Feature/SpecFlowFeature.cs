using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"sign out")]
        public void GivenSignOut()
        {
            // Driver.driver.FindElement(By.XPath("//BUTTON[@class='ui green basic button'][text()='Sign Out']")).Click();
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Education']")).Click();
            
            // Driver.driver.FindElement(By.XPath("//*/th[3]/div[@class='ui teal button ']")).Click();
           // Driver.driver.FindElement(By.XPath("//BUTTON[@class='ui green basic button'][text()='Sign Out']")).Click();
            //manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
            // Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Skills']")).Click();
        }

        [Then(@"click on Add new")]
        public void ThenClickOnAddNew()
        {
            // Driver.driver.FindElement(By.XPath("//table/thead/tr/th[@class='ui teal button'][text()='Add New']")).Click();
            // Driver.driver.FindElement(By.XPath("//*[@class='form-wrapper']/table/thead/tr/th[3]/div[@class='ui teal button']")).Click();
            Driver.driver.FindElement(By.XPath("//*[@class='form-wrapper']/table/thead/tr/th[6]/div[text()='Add New']")).Click();
        }

    }
}
