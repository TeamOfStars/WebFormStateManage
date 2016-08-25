using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManage
{
    public partial class Session1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            //1. Session.Add("sessionAdı","value");
            //2. Session["sessionAdı"]="value";
            if(txtSifre.Text!="" & txtKullanici.Text!=""){

            Session.Add("kullanici", txtKullanici.Text);
            Session["sifre"] = txtSifre.Text;
            Response.Redirect("Profil.aspx");
            }
            else
            {
                Response.Redirect("Session1.aspx");
            }
        }
    }
}