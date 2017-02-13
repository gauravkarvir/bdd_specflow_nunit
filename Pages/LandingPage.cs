
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Specflow_Webdriver.Pages
{
    public class LandingPage : BasePage
    {
        By logonButton = By.CssSelector(".iLock");
        By logOffButton = By.CssSelector(".logout>a");
        By displayName = By.CssSelector(".user strong");
        

        private string pageTitle = "Online Pharmacy, Prescriptions, Chemists and Health | LloydsPharmacy";

        public LandingPage()
        {
        }

        public void NavigateToLandingPage()
        {
            base.NavigateTo("", pageTitle);
        }

        internal void ClickOnLogOnButton()
        {
            Click(logonButton);
        }

        internal void ClickOnLogOffButton()
        {
            Click(logOffButton);
        }

        internal string GetDisplayName()
        {
            if (IsDisplayed(displayName))
            {
                return GetText(displayName);
            }
            return "Not found";
        }
        

    }
}
