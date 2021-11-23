using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LanguagesSteps
    {

        /// <summary>
        ///  Add New  Languages to Profile
        /// </summary>
        /// 
        // Select language from profile page
        [Given(@"CLick on Languages")]
        public void GivenCLickOnLanguages()
        {
            Driver.driver.FindElement(By.XPath("//A[@class='item active'][text()='Languages']")).Click();
        }
        // Click on add new button 
        [Given(@"Click on Add New for Adding languages and choose languages")]
        public void GivenClickOnAddNewForAddingLanguagesAndChooseLanguages()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='form-wrapper']/table/thead/tr/th[3]/div[text()='Add New']")).Click();
        }
        // Enter the language in textbox
        [Given(@"Add language")]
        public void GivenAddLanguage()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='fields']/div/input")).SendKeys("English");
        }
        // Choose language level from dropdown list
        [Given(@"Choose language level from dropdown list")]
        public void GivenChooseLanguageLevelFromDropdownList()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown']/option[2]")).Click();
        }
        // Click on add button to update the details 
        [Then(@"Click on Add button")]
        public void ThenClickOnAddButton()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='six wide field']/input[@class='ui teal button']")).Click();
        }

        
    }
}
