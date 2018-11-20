using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CAD
{
  public   class CADproductos
    {

        public Exception insertarProducto(Productos vt)
 {
       
            try
            {

                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionVentas";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@nombre", vt.nombre);
                cmd.Parameters.AddWithValue("@marca", vt.marca);
                cmd.Parameters.AddWithValue("@precio", vt.precio);
                cmd.Parameters.AddWithValue("@descripcion", vt.descripcion);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

            }
            return null;


        }



        public void modificarProducto(Productos vt)
        {
            string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand();
            //sentencia que se ejecutara
            cmd.Connection = con;
            // sentencia que se ejecutara
            cmd.CommandText = "GestionProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "update");
            cmd.Parameters.AddWithValue("@nombre", vt.nombre);
            cmd.Parameters.AddWithValue("@marca", vt.marca);
            cmd.Parameters.AddWithValue("@precio", vt.precio);
            cmd.Parameters.AddWithValue("@descripcion", vt.descripcion);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();



        }

        public void eliminarProducto(Productos vt)
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionVentas";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "delete");
                cmd.Parameters.AddWithValue("@nombre", vt.nombre);

                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                // MessageBox.Show("El registro se ha eliminado");

            }

        }



    }
}
