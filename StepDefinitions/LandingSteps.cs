using Ganss.Excel;
using NUnit.Framework;
using BDD_Specflow_Webdriver.Data;
using BDD_Specflow_Webdriver.Pages;
using System;
using TechTalk.SpecFlow;
using BDD_Specflow_Webdriver.framework;

namespace BDD_Specflow_Webdriver.Step_Definitions
{
    [Binding]
    public class LandingSteps : BaseSteps
    {
        LandingPage landingPage;
        TestData userContext;

        LandingSteps(TestData userContext, LandingPage landingPage)
        {
            this.landingPage = landingPage;
            this.userContext = userContext;
        }


        [Given(@"I navigate to LandingPage")]
        public void GivenINavigateToLandingPage()
        {
            landingPage.NavigateToLandingPage();
        }



        [Given(@"I navigate to Login Page")]
        public void GivenINavigateToLoginPage()
        {
            landingPage.NavigateToLandingPage();
            landingPage.ClickOnLogOnButton();
        }


        [Then(@"the user is successfully logged on and is on the Home Page")]
        public void ThenTheUserIsSuccessfullyLoggedOnAndIsOnTheHomePage()
        {
            Assert.AreEqual(userContext.UserData.DisplayName, landingPage.GetDisplayName());
        }

        [When(@"the user logs off")]
        public void WhenTheUserLogsOff()
        {
            landingPage.ClickOnLogOffButton();
        }


        



        


    }       
}
