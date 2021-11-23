using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SkillsSteps
    {
        /// <summary>
        ///  Add New  Skills to Profile
        /// </summary>

        [Given(@"CLick on Skills")]
        public void GivenCLickOnSkills()
        {
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Skills']")).Click();
        }
        //Click on Add New for Adding New Skills
        [Given(@"Click on Add New for Adding New Skills")]
        public void GivenClickOnAddNewForAddingNewSkills()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui teal button'][text()='Add New']")).Click();
        }
        //Add Skill
        [Given(@"Add Skill")]
        public void GivenAddSkill()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='fields']/div/input")).SendKeys("Testing");
        }
        //Choose skill level from dropdown list
        [Given(@"Choose skill level from dropdown list")]
        public void GivenChooseSkillLevelFromDropdownList()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']/option[2]")).Click();
        }
        //Click on Add For Adding new Skill
        [Then(@"Click on Add For Adding new Skill")]
        public void ThenClickOnAddForAddingNewSkill()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='buttons-wrapper']/input")).Click();
        }


    }
}
