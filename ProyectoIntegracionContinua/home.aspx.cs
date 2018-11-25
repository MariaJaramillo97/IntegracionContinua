using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CAD;
namespace ProyectoIntegracionContinua
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"] == string.Empty)
            {
                Response.Redirect("login.aspx");
                

            }
            

        }

    }
}