using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISProjects
{
    public partial class CacheExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["MyCacheDataset"] == null)
            {
                DataSet1.ReadXml(Server.MapPath("Authors.xml"));
                Cache.Insert("MyCacheDataset", DataSet1, new System.Web.Caching.CacheDependency(Server.MapPath("Authors.xml")));
                Label1.Text = "Cache Generated";
                //Жинхэнэ өгөгдөлд өөрчлөлт ороход кээш flush хийгдэхийг 3-р праметр дээр заан өгөв.
            }

            else
            {
                Label1.Text = "Using pre-generated Cache";
            }
            GridView1.DataSource = Cache["MyCacheDataset"];
            GridView1.DataBind();
        }

        DataSet DataSet1 = new DataSet();
    }
}