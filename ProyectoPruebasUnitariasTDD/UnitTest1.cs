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
        Productos pr = new Productos();
        [TestMethod]
        public void PruebaIngresarProducto()
        {

            Exception lst = new Exception();

            Productos pr = new Productos();
            pr = null;
            lst = cad.insertarProducto(pr);
            string resultadoEsperado = (0).ToString();
            Exception resultadoObtenido = lst;

            Assert.AreNotEqual(resultadoEsperado, resultadoObtenido);
           
          

        }



    }
}
