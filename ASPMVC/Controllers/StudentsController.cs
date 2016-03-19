using ASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC.Controllers
{
    public class StudentsController : Controller
    {
        private StudentsModel GetStudentModelFromSession()
        {

            StudentsModel theModel = (StudentsModel)Session["Students"];

            if (theModel == null)
            {

                theModel = new StudentsModel();

                Session["Students"] = theModel;

            }



            return theModel;

        }



        public ActionResult StudentList()
        {

            StudentsModel theModel = GetStudentModelFromSession();



            ViewData["Students"] = theModel.GetStudents();

            return View();

        }



        public ActionResult AddStudent()
        {

            return View();

        }



        public ActionResult AddStudentAction()
        {

            string Name = Request.Form["textName"];

            string Score = Request.Form["txtScore"];



            if ((Name == null) || (Name.Trim() == ""))
            {

                ViewData["ERROR"] = "Please provide a name for the student to add";

                return View("../Shared/Error");

            }



            if (Name.Length < 6)
            {

                ViewData["ERROR"]

                    = "The student's name should not be less than 6 characters.";

                return View("../Shared/Error");

            }



            int intScore;

            if (!Int32.TryParse(Score, out intScore))
            {

                ViewData["ERROR"]

                    = "Please provide a valid score to the student to add.";

                return View("../Shared/Error");

            }



            if ((intScore < 60) || (intScore > 100))
            {

                ViewData["ERROR"]

                    = "We only accept students with scores between 60 and 100.";

                return View("../Shared/Error");

            }



            StudentsModel theModel = GetStudentModelFromSession();

            theModel.AddStudent(Name, intScore);



            ViewData["Students"] = theModel.GetStudents();

            return View("StudentList");

        }



        public ActionResult DeleteStudent()
        {

            string ID = Request.QueryString["ID"];

            int intID;



            if (!Int32.TryParse(ID, out intID))
            {

                ViewData["ERROR"] = "Please provide a valid student ID";

                return View("../Shared/Error");

            }



            StudentsModel theModel = GetStudentModelFromSession();

            theModel.DeleteStudent(intID);



            return RedirectToAction("StudentList");

        }


    }
}
