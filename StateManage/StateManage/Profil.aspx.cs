using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManage
{
    public partial class Profil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["sifre"]!=null && Session["kullanici"]!=null){

                lblKullanici.Text = Session["kullanici"].ToString();
                lblSifre.Text = Session["sifre"].ToString();
                Session.RemoveAll();
                //session açıldıktan sonra 15 dk boyunca aktif olmama durumunda oturumu kapat
               // Session.Timeout = 15;
            }
            else
            {
                Response.Redirect("Session1.aspx");
            }
        }

        protected void btnyonlendir_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Hakkımızda.aspx");
        }
    }
}