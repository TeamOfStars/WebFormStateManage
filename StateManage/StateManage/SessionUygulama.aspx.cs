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
    public partial class SessionUygulama : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=ASUS\\MYSERVER;Database=OBS;Trusted_Connection=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Text = "online kişi sayısı :" + Application["kullaniciSayisi"].ToString();

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {


            SqlDataAdapter da = new SqlDataAdapter("select u_id,kullanici_ad,sifre from Uye where kullanici_ad=@ad and sifre=@sifre", con);
            da.SelectCommand.Parameters.AddWithValue("ad", txt_kullanici.Text);
            da.SelectCommand.Parameters.AddWithValue("sifre", txt_sifre.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Session.Add("uyeId", item[0]);
                    Response.Redirect("ProfilDetay.aspx");
                }
            }
            else
            {
                lbl.Text = "böyle bir kayıt yoktur";
            }
        }
    }
}