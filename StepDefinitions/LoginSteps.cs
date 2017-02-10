using Ganss.Excel;
using NUnit.Framework;
using BDD_Specflow_Webdriver.Data;
using BDD_Specflow_Webdriver.Pages;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using BDD_Specflow_Webdriver.framework;

namespace BDD_Specflow_Webdriver.Step_Definitions
{
    [Binding]
    public class LoginSteps 
    {
        LoginPage loginPage;
        TestData testData;


        LoginSteps(TestData testData, LoginPage loginPage)
        {
            this.testData = testData;
            this.loginPage = loginPage;

        }


        [When(@"I enter login details for (.*)")]
        public void WhenIEnterLoginDetailsFor(string userType)
        {   testData.UserData = Properties.GetUserType(userType);
            UserData userData = testData.UserData;
            loginPage.EnterUserNameAndPassword(userData.Username, userData.Password);
            loginPage.Submit();
        }


        [Then(@"the user is successfully logged off")]
        public void ThenTheUserIsSuccessfullyLoggedOff()
        {
            var logOffMessage = "You have successfully logged off";

            Assert.That(loginPage.GetLogOffMessage().Contains(logOffMessage)); }

    }

}



