using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace ISProjects
{
    public partial class Default : System.Web.UI.Page
    {
     
        private string _selectedTab = "main";

        public string SelectedTab
        {
            get { return _selectedTab; }
            set { _selectedTab = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink sT = null;

            switch (_selectedTab)
            {
                case "default":
                    sT = _mainLink;
                    break;
                case "Home":
                    sT = _page2Link;
                    break;
                default:
                    sT = _mainLink;
                    break;
            }

            sT.Font.Bold = true;
            sT.ForeColor = Color.OrangeRed;

        }

        protected void signUpButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}