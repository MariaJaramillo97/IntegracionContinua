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
       
             string resultadoEsperado;
             string resultadoObtenido;
           

             cad.insertarProducto(pr);




        }



    }
}
