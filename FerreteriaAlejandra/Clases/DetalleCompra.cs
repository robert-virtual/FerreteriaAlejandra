using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("detallecompra")]
    public class DetalleCompra:Operaciones<DetalleCompra>
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        [Write(false)]
        public Producto Producto{ get; set; }
        public int IdProducto{ get; set; }


        [Write(false)]
        public Compra Compra{ get; set; }
        public long IdCompra{ get; set; }
        
        
    }
}
