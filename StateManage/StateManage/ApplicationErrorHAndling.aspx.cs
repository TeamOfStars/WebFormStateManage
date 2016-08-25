using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManage
{
    public partial class ApplicationErrorHAndling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

  

        protected void btnRast_Click(object sender, EventArgs e)
        {
            throw new DivideByZeroException();
        }

        protected void btnSql_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
        }
    }
}