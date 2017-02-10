using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Specflow_Webdriver.Utils
{
    /// <summary>
    /// Subclasses RemoteWebDriver in order to return the session id for sauce labs use
    /// </summary>
    class CustomRemoteDriver : RemoteWebDriver 
    {
        CustomRemoteDriver(ICapabilities desiredCapabilities) : base(desiredCapabilities)
        {
        }

        public CustomRemoteDriver(ICommandExecutor commandExecutor, ICapabilities desiredCapabilities):base(commandExecutor, desiredCapabilities)
    {
        }

        public CustomRemoteDriver(Uri remoteAddress, ICapabilities desiredCapabilities):base(remoteAddress, desiredCapabilities)
    {
        }

        public CustomRemoteDriver(Uri remoteAddress, ICapabilities desiredCapabilities, TimeSpan commandTimeout):base(remoteAddress, desiredCapabilities, commandTimeout)
    {
        }

        /// <summary>
        /// Method to return the webdriver session id
        /// </summary>
        /// <returns>webdriver sessionid</returns>
        public string GetSessionId()
        {
            return base.SessionId.ToString();
        }

    }


}
