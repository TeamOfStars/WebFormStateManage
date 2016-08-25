using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManage
{
    public partial class Detay : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection("Server=ASUS\\MYSERVER;Database=Northwnd;Trusted_Connection=true;");

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Products where CategoryID=@id and UnitPrice between @min and @max",bag);

            da.SelectCommand.Parameters.AddWithValue("id",Request.QueryString["cid"]);
            da.SelectCommand.Parameters.AddWithValue("min",Request.QueryString["min"]);
               da.SelectCommand.Parameters.AddWithValue("max",Request.QueryString["max"]);
            DataTable dt = new DataTable("urunler");

            da.Fill(dt);
            detay.DataSource = dt;
            detay.DataBind();

        }
    }
}