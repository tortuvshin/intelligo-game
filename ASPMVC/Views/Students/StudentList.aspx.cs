using ASPMVC.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace ASPMVC.Views.Students
{
    public class StudentList : System.Web.Mvc.ViewPage
    {

        protected Literal litStudentDetail;

        protected HyperLink linkAddStudent;



        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Cache.SetCacheability(HttpCacheability.NoCache);



            linkAddStudent.NavigateUrl =

            ApplicationUtility.FormatURL("/Students/AddStudent");



            DataTable StudentsTable = (DataTable)ViewData["Students"];

            DataView StudentsView = StudentsTable.DefaultView;

            StudentsView.Sort = "ID Desc";



            StringBuilder SB = new StringBuilder();



            SB.Append("<table style=\"width: 99%;\" ");

            SB.Append("rules=\"all\" border=\"1px\" ");

            SB.Append("cellspacing=\"0px\" cellpadding=\"4px\">");



            SB.Append("<tr style=\"background-color: Silver; color: white; ");

            SB.Append("font-weight: bold\">");

            foreach (DataColumn aColumn in StudentsTable.Columns)
            {

                SB.Append("<td>");

                SB.Append(aColumn.ColumnName);

                SB.Append("</td>");

            }

            SB.Append("<td>&nbsp;</td>");

            SB.Append("</tr>");



            foreach (DataRowView aRowView in StudentsView)
            {

                SB.Append("<tr>");

                foreach (DataColumn aColumn in StudentsTable.Columns)
                {

                    SB.Append("<td>");

                    SB.Append(aRowView[aColumn.ColumnName].ToString());

                    SB.Append("</td>");

                }



                string ID = aRowView["ID"].ToString();

                SB.Append("<td>");

                SB.Append("<a href=\"");

                SB.Append(ApplicationUtility.FormatURL("/Students/DeleteStudent"));

                SB.Append("?ID=");

                SB.Append(ID);

                SB.Append("\">Delete this student</a>");

                SB.Append("</td>");

                SB.Append("</tr>");

            }



            SB.Append("</table>");



            litStudentDetail.Text = SB.ToString();

        }

    }


}