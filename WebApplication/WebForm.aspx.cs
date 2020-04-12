using WebApplication.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MyRecord> myRecordList = new List<MyRecord>();

            myRecordList.Add(new MyRecord() { Id = 1, Name = "Kim" });
            myRecordList.Add(new MyRecord() { Id = 2, Name = "Travis" });
            myRecordList.Add(new MyRecord() { Id = 3, Name = "Christian" });
            myRecordList.Add(new MyRecord() { Id = 4, Name = "Maddie" });

            DropDownList1.DataSource = myRecordList;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }
    }
}