using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_1
{
    public partial class Converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Session обьектоос ArrayList-ийг авах, хэрэв байхгүй бол үүсгэнэ
        /// </summary>
        protected System.Collections.ArrayList HistoryList
        {
            get
            {
                if (Session["HistoryList"] == null)
                    Session["HistoryList"] = new System.Collections.ArrayList();

                return (System.Collections.ArrayList)Session["HistoryList"];
            }
        }
         protected void convertButton_Click(object sender, EventArgs e)
        {
            this.HistoryList.Add(new Conversion(display, result, convertSelectListBox.SelectedItem.Text));
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {

        }

        public double display { get; set; }

        public double result { get; set; }

        public void ShowHistoryList()
        {
            this.convertHistory.Rows.Clear();
            for (int i = 0; i < this.HistoryList.Count; i++)
            {
                Conversion temp = (Conversion)this.HistoryList[i];
                TableRow tr = new TableRow();
                TableCell tc = new TableCell();
                tc.Text = temp.Input.ToString();
                tr.Cells.Add(tc);
                tc = new TableCell();
                tc.Text = temp.Output.ToString();
                tr.Cells.Add(tc);
                tc = new TableCell();
                tc.Text = temp.Description;
                tr.Cells.Add(tc);
                this.convertHistory.Rows.Add(tr);
            }
        }
    }
}