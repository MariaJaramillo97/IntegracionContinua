using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Factura
    {


        public int idFactura { get; set; }
        public string observaciones { get; set; }
        public double iva { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public string cliente { get; set; }
        public DateTime fecha { get; set; }



    }
}
