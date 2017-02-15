using BDD_Specflow_Webdriver.Data;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Specflow_Webdriver.Pages
{
    public class LoginPage : BasePage
    {
        By loginusername = By.Name("logonId");
        By loginpassword = By.Name("logonPassword");
        By loginsubmitbutton = By.CssSelector("#pageLoginForm input.btnAction[name=signIn]");
        By successMessageLocator = By.CssSelector(".flash.success");
        By failureMessageLocator = By.CssSelector(".errorMsg");
        By logOffMessage = By.CssSelector(".message");



        public LoginPage()
        {
        }


        public void LoginAs(UserData userData)
        {
            Type(userData.Username, loginusername);
            Type(userData.Password, loginpassword);
            WaitForElement(loginsubmitbutton);

        }

        public void EnterUserNameAndPassword(String username, String password)
        {
            Type(username, loginusername);
            Type(password, loginpassword);
        }

        

        public void Submit()
        {

            ClickAction(loginsubmitbutton);
        }

        public void SuccessMessagePresent()
        {
            Assert.True(IsDisplayed(successMessageLocator));
        }

        public string FailureMessagePresent()
        {
            if (IsDisplayed(failureMessageLocator))
            {
                return GetText(failureMessageLocator);
            }
            return "Not found";
        }

        internal string GetLogOffMessage()
        {
            if (IsDisplayed(logOffMessage))
            {
                return GetText(logOffMessage);
            }
            return "Not found";
        }


    }

}
