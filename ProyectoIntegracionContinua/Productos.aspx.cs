using CAD;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIntegracionContinua
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
 		protected void Insertar_Click(object sender, EventArgs e)
        {
            
            Producto vts = new Producto();
            vts.nombre = nombre.Text;
            vts.marca = apellido.Text;
            vts.precio = cedula.Text;
            vts.descripcion = correo.Text;

            CADproductos datos = new CADproductos();
            datos.insertarProducto(vts);
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            Producto vts = new Producto();

            vts.marca = apellido.Text;
            vts.precio = cedula.Text;
            vts.descripcion = correo.Text;


            CADproductos datos = new CADproductos();
            datos.modificarProducto(vts);
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            Producto vts = new Producto();
            vts.nombre = nombre.Text;


            CADproductos datos = new CADproductos();
            datos.eliminarProducto(vts);
        }

        protected void Consultar_Click(object sender, EventArgs e)
        {

        }

   

    }
}