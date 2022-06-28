using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("detalleventa")]
    public class DetalleVenta:Operaciones<DetalleVenta>
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        [Write(false)]
        public Producto Producto{ get; set; }
        public int IdProducto{ get; set; }


        [Write(false)]
        public Venta Venta{ get; set; }
        public long IdVenta{ get; set; }


    }
}
