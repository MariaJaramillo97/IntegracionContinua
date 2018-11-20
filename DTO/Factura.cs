using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Factura
    {


        private int idFactura { get; set; }
        private string observaciones { get; set; }
        private double totalPeso { get; set; }
        private double iva { get; set; }
        private double subtotal { get; set; }
        private double total { get; set; }
        private string cliente { get; set; }
        private DateTime fecha { get; set; }



    }
}
