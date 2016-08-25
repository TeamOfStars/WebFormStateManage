using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace StateManage
{
    public partial class QueryString : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection("Server=ASUS\\MYSERVER;Database=Northwnd;Trusted_Connection=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Categories", bag);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            repeater.DataSource = dt;
            repeater.DataBind();
            if (Request.QueryString["cId"]!=null)
            {
                SqlDataAdapter adtr2 = new SqlDataAdapter("Select * From Products Where CategoryID=@cId", bag);
                adtr2.SelectCommand.Parameters.AddWithValue("cId", Request.QueryString["cId"]);
                DataTable dt2 = new DataTable();
                adtr2.Fill(dt2);
                grid.DataSource = dt2;
                grid.DataBind();
            }
        }
    }
}