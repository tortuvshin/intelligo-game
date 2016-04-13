using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lib.Controllers
{
    public class Common : Controller
    { 
        //[Inject]
        //public ILogger Logger { get; set; }
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
        //        Logger.Error(e);
            }
            return filePath;
        }

    }
}
