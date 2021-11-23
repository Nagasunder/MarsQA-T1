using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{

    // Education details feature
    [Binding]
    public class Education
    {
        // Click on education tab from profile page
        [Given(@"Click On Education")]
        public void GivenClickOnEducation()
        {
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Education']")).Click();
        }
        // Click on the add new button to enter details
        [Given(@"Click on Addnew to fill the education details")]
        public void GivenClickOnAddnewToFillTheEducationDetails()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui fixed table']/thead/tr/th[6]/div")).Click();
        }
        // Enter the College or university details in the text box
        [Given(@"Enter college or university")]
        public void GivenEnterCollegeOrUniversity()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ten wide field']/input")).SendKeys("NCI");
        }
        // Choose the coutry of college or university from the drop down list
        [Given(@"Country of college or university from dropdown")]
        public void GivenCountryOfCollegeOrUniversityFromDropdown()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown']/option[70]")).Click();
        }
        // Choose the type of degree from the drop down list
        [Given(@"Select degree type from the dropdown")]
        public void GivenSelectDegreeTypeFromTheDropdown()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='fields']/div/select/option[8][text()='M.Tech']")).Click();
        }
        // Enter the name of degree in the text box
        [Given(@"Enter name of the degree")]
        public void GivenEnterNameOfTheDegree()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='six wide field']/input")).SendKeys("Cyber Security");
        }
        
        // Choose the graduation year from drop down
        [Given(@"Select year of graduation from dropdown")]
        public void GivenSelectYearOfGraduationFromDropdown()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='fields']/div/select/option[2][text()='2021']")).Click();
        }
        
        // After entering all the details save the details of education filled
        [Then(@"Click on Add to save the education details")]
        public void ThenClickOnAddToSaveTheEducationDetails()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='sixteen wide field']/input[@class='ui teal button ']")).Click();
        }
    }
}
