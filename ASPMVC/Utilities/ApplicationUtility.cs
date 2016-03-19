using ASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ASPMVC.Utilities
{
    public class ApplicationUtility
    {
        public static string FormatURL(string PathWithoutVirtualDirectoryName)
        {
            ApplicationInformation appInfomation = ApplicationInformation.GetInstance();
            string DeploymentVirtualDirectory = appInfomation.DeploymentVirtualDirectory;

            if (DeploymentVirtualDirectory == "")
            {
               return PathWithoutVirtualDirectoryName;
            }

            StringBuilder SB = new StringBuilder();
            SB.Append("/");
            SB.Append(appInfomation.DeploymentVirtualDirectory);
            SB.Append("/");
            SB.Append(PathWithoutVirtualDirectoryName);
            return SB.ToString();
        }
    }
}