using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ASPMVC.Models
{
    public class StudentsModel
    {
        private DataTable Students;

        public StudentsModel()
        {
            Students = new DataTable();
            DataColumn IDColumn = Students.Columns.Add ("ID", Type.GetType("System.Int32"));
            IDColumn.AutoIncrement = true;
            IDColumn.AutoIncrementSeed = 1;
            IDColumn.AutoIncrementStep = 1;

            Students.Columns.Add("Name", Type.GetType("System.String"));
            Students.Columns.Add("Score", Type.GetType("System.Int32"));
            Students.Columns.Add("Time Added", Type.GetType("System.DateTime"));

            DataColumn[] keys = new DataColumn[1];
            keys[0] = IDColumn;
            Students.PrimaryKey = keys;

            Random rd = new Random();
            for (int Idex = 1; Idex <= 5; Idex++)
            {
                DataRow row = Students.NewRow();
                Students.Rows.Add(row);
                row["Name"] = "Student Name No. " + Idex.ToString();
                row["Score"] = 60 + rd.NextDouble() * 40;
                row["Time Added"] = System.DateTime.Now;
            }
        }

        public void AddStudent(string Name, int Score)
        {
            DataRow row = Students.NewRow();
            Students.Rows.Add(row);
            row["Name"] = Name;
            row["Score"] = Score;
            row["Time Added"] = System.DateTime.Now;
        }

        public void DeleteStudent(int ID)
        {
            DataRow RowToDelete = Students.Rows.Find(ID);
            if (RowToDelete != null)
            {
                Students.Rows.Remove(RowToDelete);
            }
        }

        public DataTable GetStudents()
        {
            return Students;
        }

    }
}