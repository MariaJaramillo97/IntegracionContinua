using CAD;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIntegracionContinua
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            //el dto captura los datos del formularios y los guarda en el objeto usuario

            user us = new user();
            us.usuario = txtUser.Text;
            us.contra = txtPass.Text;
            //el cad contiene el metodo o la accion que va a ejecutar  en la base de datos 
            CADuser datos = new CADuser();
            DataTable dt = datos.validarUsuario(us);
            if (dt.Rows.Count != 0)
            {
                Session["usuario"] = txtUser.Text;
                Response.Redirect("home.aspx");
            }
            else
            {
                Panel1.Visible = true;
              
            }
        }
    }
}
