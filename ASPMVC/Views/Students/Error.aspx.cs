using ASPMVC.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ASPMVC.Views.Students
{
    public class Error : System.Web.Mvc.ViewPage
    {

        protected Literal litErrorMessage;

        protected HyperLink linkBackToMainPage;



        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Cache.SetCacheability(HttpCacheability.NoCache);



            linkBackToMainPage.NavigateUrl

                = ApplicationUtility.FormatURL("/Students/StudentList");

            string ErrorMessage = ViewData["ERROR"].ToString();

            litErrorMessage.Text = ErrorMessage;

        }

    }


}