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
    public class BaseSteps
    {

        public UserData GetUserData(string userType)
        {
            var userData = Properties.GetUserType(userType);
            return userData;
        }


        


        

        public void LoginAs(string userType)
        {
            Controls.LandingPage.NavigateToLandingPage();
            Controls.LoginPage.LoginAs(GetUserData(userType));
        }

      
        

        
        

        public bool IsLogOffSuccessfull() { 
            var logOffMessage = "You have successfully logged off";
            return Controls.LoginPage.GetLogOffMessage().Contains(logOffMessage);
        }

        

    }
}