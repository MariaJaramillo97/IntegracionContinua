using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class DetalleFactura
    {
        public int idDetalleFactura { get; set; }
        public int idFactura { get; set; }
        public double precioUnitario { get; set; }
        public string idProducto { get; set; }
        public double precioTotal { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }


    }
}
