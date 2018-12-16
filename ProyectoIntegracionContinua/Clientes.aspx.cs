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
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insertar_Click(object sender, EventArgs e)
        {

            Cliente vts = new Cliente();
            vts.nombres = nombres.Text;
            vts.apellidos = apellidos.Text;
            vts.correo = correo.Text;
            vts.cedula = cedula.Text;


            CADClientes datos = new CADClientes();
            datos.insertarClientes(vts);
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            Cliente vts = new Cliente();

            vts.nombres = nombres.Text;
            vts.apellidos = apellidos.Text;
            vts.correo = correo.Text;


            CADClientes datos = new CADClientes();
            datos.modificarClientes(vts);
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            Cliente vts = new Cliente();
            vts.nombres = nombres.Text;


            CADClientes datos = new CADClientes();
            datos.eliminarCliente(vts);
        }

        protected void Consultar_Click(object sender, EventArgs e)
        {

        }




    }
}