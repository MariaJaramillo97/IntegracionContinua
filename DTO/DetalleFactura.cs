using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class DetalleFactura
    {
        private int idDetalleFactura { get; set; }
        private int idFactura { get; set; }
        private double precioUnitario { get; set; }
        private string idProducto { get; set; }
        private double precioTotal { get; set; }
        private string descripcion { get; set; }
        private int cantidad { get; set; }


    }
}
