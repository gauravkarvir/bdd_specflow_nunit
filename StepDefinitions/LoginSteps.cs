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

        [Then(@"i can see the validation error message")]
        public void ThenICanSeeTheValidationErrorMessage()
        {
            var invalidUserMessage = "The password field cannot be empty.";
            Assert.That(loginPage.FailureMessagePresent().Contains(invalidUserMessage));
        }



        [Then(@"the user is successfully logged off")]
        public void ThenTheUserIsSuccessfullyLoggedOff()
        {
            var logOffMessage = "Either username or password entered is incorrect. Please check your details and try again. If you are trying to login to our Online Doctor service please login here.";

            Assert.That(loginPage.GetLogOffMessage().Contains(logOffMessage)); }

    }

}



