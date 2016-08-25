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
    public partial class Anasayfa : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection("Server=ASUS\\MYSERVER;Database=Northwnd;Trusted_Connection=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Categories", bag);
            DataTable dt = new DataTable();
            adtr.Fill(dt);

            grid.DataSource = dt;
            grid.DataBind();
        }

        protected void grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "arama")
            {
                int id = int.Parse(e.CommandArgument.ToString());

                GridViewRow kontrol = ((e.CommandSource as LinkButton).Parent as DataControlFieldCell).Parent as GridViewRow;

                string min=(kontrol.FindControl("min") as TextBox).Text;
                string max = (kontrol.FindControl("max") as TextBox).Text;

                Response.Redirect(string.Format("/detay.aspx?cid={0}&min={1}&max={2}",id,min,max));
            }
        }
    }
}