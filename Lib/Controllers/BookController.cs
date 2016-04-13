using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lib.Controllers
{
    public class BookController : Common
    {
        //
        // GET: /Book/

        public ActionResult Index()
        {
            return View();
        }

    }
}
