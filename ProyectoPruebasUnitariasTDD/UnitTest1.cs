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



    }
}
