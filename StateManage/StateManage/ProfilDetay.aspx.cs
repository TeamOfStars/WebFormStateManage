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
    public partial class ProfilDetay : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=ASUS\\MYSERVER;Database=OBS;Trusted_Connection=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uyeId"]!=null)
            {
           
                SqlDataAdapter da = new SqlDataAdapter("select * from Uye u join [Not] n on n.u_id=u.u_id where u.u_id=@id", con);
                //int a = Convert.ToInt32(Session["uyeId"]);
                da.SelectCommand.Parameters.AddWithValue("id", Session["uyeId"].ToString());
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridBilgi.DataSource = dt;
                gridBilgi.DataBind();
            }
            else
            {
                Response.Redirect("SessionUygulama.aspx");
            }
        }
    }
}