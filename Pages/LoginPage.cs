using BDD_Specflow_Webdriver.Data;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Specflow_Webdriver.Pages
{
    public class LoginPage : BasePage
    {
        By loginusername = By.Id("username");
        By loginpassword = By.Id("password");
        By loginsubmitbutton = By.Id("submit");
        By successMessageLocator = By.CssSelector(".flash.success");
        By failureMessageLocator = By.CssSelector(".flash.error");
        By logOffMessage = By.CssSelector(".message");



        public LoginPage()
        {
        }


        public void LoginAs(UserData userData)
        {
            Type(userData.Username, loginusername);
            Type(userData.Password, loginpassword);
            Click(loginsubmitbutton);

        }

        public void EnterUserNameAndPassword(String username, String password)
        {
            Type(username, loginusername);
            Type(password, loginpassword);
        }

        public void Submit()
        {
            Click(loginsubmitbutton);
        }

        public void SuccessMessagePresent()
        {
            Assert.True(IsDisplayed(successMessageLocator));
        }

        public void FailureMessagePresent()
        {
            Assert.True(IsDisplayed(failureMessageLocator));
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
