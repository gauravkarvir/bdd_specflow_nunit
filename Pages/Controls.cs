namespace BDD_Specflow_Webdriver.Pages
{
    public static class Controls
    {

        //private static IWebDriver driver = (IWebDriver)ScenarioContext.Current["driver"];
        private static LoginPage _loginPage;
        private static LandingPage _landingPage;
        


        public static LoginPage LoginPage
        {
            //get { return _loginPage ?? (_loginPage = new LoginPage()); }
            get { return new LoginPage(); }
        }

        public static LandingPage LandingPage
        {
            //get { return _landingPage ?? (_landingPage = new LandingPage()); }
            get {return new LandingPage(); }
        }

        
    }
}
