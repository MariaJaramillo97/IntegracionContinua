using System;
using CAD;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyectoPruebasUnitariasTDD
{
    [TestClass]
    public class ProyectoPruebasUnitariasTDD
    {

        CADproductos cad = new CADproductos();
        CADClientes cadclientes = new CADClientes();
        Producto pr = new Producto();
        [TestMethod]
        public void PruebaIngresarProducto()
        {

            Exception lst = new Exception();

            Producto pr = new Producto();
            pr = null;
            lst = cad.insertarProducto(pr);
            string resultadoEsperado = (0).ToString();
            Exception resultadoObtenido = lst;

            Assert.AreNotEqual(resultadoEsperado, resultadoObtenido);
           
          

        }


        [TestMethod]
        public void PruebaModificarProducto()
        {

            Exception lst = new Exception();

            Producto pr = new Producto();
            pr = null;
            lst = cad.modificarProducto(pr);
            string resultadoEsperado = (0).ToString();
            Exception resultadoObtenido = lst;

            Assert.AreNotEqual(resultadoEsperado, resultadoObtenido);



        }
        [TestMethod]
        public void PruebaEliminarProducto()
        {

            Exception lst = new Exception();

            Producto pr = new Producto();
            pr = null;
            lst = cad.eliminarProducto(pr);
            string resultadoEsperado = (0).ToString();
            Exception resultadoObtenido = lst;

            Assert.AreNotEqual(resultadoEsperado, resultadoObtenido);



        }


        [TestMethod]
        public void PruebaIngresarCliente()
        {

            Exception lst = new Exception();

            Cliente cl = new Cliente();
            cl = null;
            lst = cadclientes.insertarClientes(cl);
            string resultadoEsperado = (0).ToString();
            Exception resultadoObtenido = lst;

            Assert.AreNotEqual(resultadoEsperado, resultadoObtenido);



        }


        [TestMethod]
        public void PruebaModificarCliente()
        {

            Exception lst = new Exception();

            Cliente cl = new Cliente();
            cl = null;
            lst = cadclientes.modificarClientes(cl);
            string resultadoEsperado = (0).ToString();
            Exception resultadoObtenido = lst;

            Assert.AreNotEqual(resultadoEsperado, resultadoObtenido);



        }
        [TestMethod]
        public void PruebaEliminarClientes()
        {

            Exception lst = new Exception();

            Cliente cl = new Cliente();
            cl = null;
            lst = cadclientes.eliminarCliente(cl);
            string resultadoEsperado = (0).ToString();
            Exception resultadoObtenido = lst;

            Assert.AreNotEqual(resultadoEsperado, resultadoObtenido);



        }


    }
}
