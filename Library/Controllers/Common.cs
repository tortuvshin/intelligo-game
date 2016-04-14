using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using Itera.Fagdag.November.Logging.Contract;
using Itera.Fagdag.November.Resources.Keys;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Ninject;
using Ninject.Web.Common;

namespace Itera.Fagdag.November.Controllers
{
    public class Common : Controller
    {
        [Inject]
        public ILogger Logger { get; set; }
        public string GetUserId()
        {
            return User.Identity.GetUserId();
        }

        public string GetUserName()
        {
            return User.Identity.GetUserName();
        }

        public string SaveOnServer(string fileName, string key)
        {
            var filePath = string.Empty;
            try
            {
                filePath = Path.Combine(Server.MapPath(Keys.PathUploads), Path.GetFileName(fileName));
                Request.Files[key].SaveAs(filePath);
            }
            catch (Exception e)
            {
                Logger.Error(e);
            }
            return filePath;
        }
    }
}