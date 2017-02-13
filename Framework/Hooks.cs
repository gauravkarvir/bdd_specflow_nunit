using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.IE;
using BDD_Specflow_Webdriver.framework;


/*
Purpose of this class is to 
-Define actions to perform before and after feature/Scenario
-Define local and remote test execution, sauce lab settings and local host browser setting are defined

*/
namespace BDD_Specflow_Webdriver.Utils
{
    [Binding]
    public sealed class Hooks
    {
        /// <summary>
        ///  Purupse of this Hooks class is to 
        ///  Maintain shared objects across the feature scenarios
        ///  Declare any standard actions required to run pre and post scneario and feature
        ///  Declare and instantiate driver object which is shared across all features.
        /// </summary>


        static IWebDriver localDriver;
        static RemoteWebDriver driver; // used to run test on saucelabs or browserstack tool.
        //load from app.config
        static string host =  Properties.Settings("host").Value;
        static string baseurl =  Properties.Settings("baseUrl").Value; 
        static string browser =  Properties.Settings("browser").Value; 
        static string testExecution = Properties.Settings("testExecutionType").Value;
        static string platform =  Properties.Settings("platform").Value;  
        static string browserVersion = Properties.Settings("browserVersion").Value;
        static string saucelabsAccountName =  Properties.Settings("sauce_labs_account_name").Value;
        static string saucelabsAccountKey = Properties.Settings("sauce_labs_account_key").Value;  
        static string browserStackKey =  Properties.Settings("browserstack_key").Value;
        static string browserStacUser =  Properties.Settings("browserstack_user").Value;


        //public static CustomRemoteDriver driver { get; private set; }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        [BeforeFeature]
        public static void BeforeFeatureRun()
        {
            if (host == "local")
            {
                Console.Write("####### Feature : " + FeatureContext.Current.FeatureInfo.Title);
               
                if (testExecution == "headless") // headlessrun is performed on deployment server.
                {
                    localDriver = new PhantomJSDriver();
                    FeatureContext.Current["driver"] = localDriver;
                }

              else  if (testExecution == "firefox") // headlessrun is performed on deployment server.
                {
                    FirefoxDriverService _firefoxDriverService = FirefoxDriverService.CreateDefaultService(@"C:\Projects\bdd-specflow-automation\packages\Selenium.Firefox.WebDriver.0.13.0\driver", "geckodriver.exe");
                    localDriver = new FirefoxDriver(_firefoxDriverService);

                    FeatureContext.Current["driver"] = localDriver;
                }
                else if (testExecution == "internetExplorer") 
                {
                    localDriver = new InternetExplorerDriver(@"C:\Projects\bdd-specflow-automation\packages\WebDriver.IEDriverServer.win32.3.0\content");
                    FeatureContext.Current["driver"] = localDriver;
                }

                else if (testExecution == "chrome")
                {
                    localDriver = new ChromeDriver(@"C:\Projects\bdd-specflow-automation\packages\Selenium.WebDriver.ChromeDriver.2.27.0\driver");
                    FeatureContext.Current["driver"] = localDriver;
                }


            }

            /*
           Tests can be run on below devices available on browserstack tool. 
            Android - Samsung Galaxy S5,Google Nexus 5,Samsung Galaxy Tab 4 10.1
            IOS-iPhone 6S Plus,iPhone 6S,iPad Air,iPhone 5S
             

            */

            else if (host == "browserstack")
            {
                DesiredCapabilities desiredCap = new DesiredCapabilities();
                desiredCap.SetCapability("platform", "android");// these values will be moved to app config.
                desiredCap.SetCapability("browserName", "Android");
                desiredCap.SetCapability("device", "Samsung Galaxy Tab 4 10.1");
                desiredCap.SetCapability("browserVersion", "4.4");
                desiredCap.SetCapability("browserstack.key", browserStackKey);
                desiredCap.SetCapability("browserstack.user", browserStacUser);
                desiredCap.SetCapability("browserstack.debug", "true");
                driver = new RemoteWebDriver(new Uri("http://hub.browserstack.com/wd/hub/"), desiredCap);
                FeatureContext.Current["driver"] = driver;

            }

            /* TestS can be run on below devices available in sauce labs tool
            Andriod 4.4  : Google Nexus 7 HD Emulator, Samsung Galaxy S4 Emulator,Samsung Galaxy Tab 3 Emulator.
            IOS 9.2 : iPad Air, iPhone 5, iPhone 6, iPhone 6 plus

     */

            else if (host == "saucelabs")
            {
                DesiredCapabilities desiredCap = new DesiredCapabilities();
                desiredCap.SetCapability("platform", "MAC");
                desiredCap.SetCapability("browserName", "iPhone");
                desiredCap.SetCapability("device", "iPhone 6 Plus");
                desiredCap.SetCapability("browserVersion", "9.2");
                desiredCap.SetCapability("username", saucelabsAccountName);
                desiredCap.SetCapability("accessKey", saucelabsAccountKey);
                //desiredCap.SetCapability("browserstack.debug", "true");
                driver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub/"), desiredCap, TimeSpan.FromSeconds(600));
                FeatureContext.Current["driver"] = driver;

            }

          

        }

        [BeforeScenario]

        public static void BeforeWebScenario()
        {
            if (host == "local")
            {

                ScenarioContext.Current["driver"] = localDriver;
                Console.Write("----- Test Scenario : " + ScenarioContext.Current.ScenarioInfo.Title);
            }
            else if (host == "saucelabs")
            {

               ScenarioContext.Current["driver"] = driver;
                Console.Write("Test Scenario ######: " + ScenarioContext.Current.ScenarioInfo.Title);
            }

            else if ( host == "browserstack")
            {
                ScenarioContext.Current["driver"] = driver;
                Console.Write("Test Scenario ###### : " + ScenarioContext.Current.ScenarioInfo.Title);

            }
        }

        [AfterScenario]
        public static void AfterWebScenario()
        {
            if (host == "local")
            {

                if (ScenarioContext.Current.TestError != null)
                {
                    IWebDriver driver = null;
                    // TakeScreenshot(driver); // this is throwing some warning , need to fix.
                }
                // localDriver.Quit(); //no need to kill driver after each scenario
            }


        }

        [AfterFeature()]
        public static void AfterFeatureRun()
        {

            if (host == "local")
            {

            // Console.Write("Feature Run-Ended #######################");

                localDriver.Quit(); // kill driver after feature run.

            }

            if (host== "browserstack")
            {
                driver.Quit();
            }

            else if (host == "saucelabs")
            {
                
                driver.Quit();
            }

        }

        
        private static void TakeScreenshot(IWebDriver driver)
        {
            try
            {
                string fileNameBase = string.Format("error_{0}_{1}_{2}",
                    FeatureContext.Current.FeatureInfo.Title,
                    ScenarioContext.Current.ScenarioInfo.Title,
                    DateTime.Now.ToString("yyyyMMdd_HHmmss"));

                var artifactDirectory = Path.Combine(Directory.GetCurrentDirectory(), "testresults");
                if (!Directory.Exists(artifactDirectory))
                    Directory.CreateDirectory(artifactDirectory);

                string pageSource = driver.PageSource;
                string sourceFilePath = Path.Combine(artifactDirectory, fileNameBase + "_source.html");
                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
                Console.WriteLine("Page source: {0}", new Uri(sourceFilePath));

                ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;

                if (takesScreenshot != null)
                {
                    var screenshot = takesScreenshot.GetScreenshot();
                    string screenshotFilePath = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");
                    screenshot.SaveAsFile(screenshotFilePath, ImageFormat.Png);
                    Console.WriteLine("Screenshot: {0}", new Uri(screenshotFilePath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }
    }
}
