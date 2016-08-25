using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManage
{
    public partial class Hakkımızda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if(Session["kullanici"]!=null && Session["sifre"]!=null){

              lblKullnici.Text = Session["kullanici"].ToString();
              lblSifre.Text = Session["sifre"].ToString();
          }
          else
          {
              Response.Redirect("Profil.aspx");
          }
        }
    }
}