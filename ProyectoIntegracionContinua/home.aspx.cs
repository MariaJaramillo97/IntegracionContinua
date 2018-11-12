using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CAD;
namespace EjercicioResponsive
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

        protected void Insertar_Click(object sender, EventArgs e)
        {

            Productos vts = new Productos();
            vts.nombre = nombre.Text;
            vts.marca = marca.Text;
            vts.precio =precio.Text;
            vts.descripcion = descripcion.Text;

            CADproductos datos = new CADproductos();
            datos.insertarProducto(vts);



        }

        protected void Modificar_Click(object sender, EventArgs e)
        {

            Productos vts = new Productos();
 
            vts.marca = marca.Text;
            vts.precio = precio.Text;
            vts.descripcion = descripcion.Text;


            CADproductos datos = new CADproductos();
            datos.modificarProducto(vts);
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            Productos vts = new Productos();
            vts.nombre = nombre.Text;


            CADproductos datos = new CADproductos();
            datos.eliminarProducto(vts);
        }

        protected void Consultar_Click(object sender, EventArgs e)
        {

        }
    }
}