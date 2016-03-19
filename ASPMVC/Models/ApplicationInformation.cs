using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ASPMVC.Models
{
    public class ApplicationInformation
    {
        private static ApplicationInformation _thisInstance = null;
        private static object _threadLock = new Object();
        public string ApplicationName { get; private set; }
        public string Author { get; private set; }
        public string DevelopmentTime { get; private set; }
        public string DeploymentVirtualDirectory { get; private set; }

        public ApplicationInformation()
        {
            ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];
            Author = ConfigurationManager.AppSettings["Author"];
            DevelopmentTime = ConfigurationManager.AppSettings["DevelopmentTime"];
            DeploymentVirtualDirectory = ConfigurationManager.AppSettings["DeploymentVirtualDirectory"];
        }

        public static ApplicationInformation GetInstance()
        {
            lock (_threadLock)
            {
                if (_thisInstance == null)
                {
                    _thisInstance = new ApplicationInformation();
                }
            }
            return _thisInstance;
        }
    }
}