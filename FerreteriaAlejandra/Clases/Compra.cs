using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("compra")]
    public class Compra:Operaciones<Compra>
    {
        public long Id { get; set; }
        public int IdProveedor{ get; set; }
        public string Descripcion{ get; set; }

        [Write(false)]
        public Proveedor Proveedor{ get; set; }


        [Write(false)]
        public DateTime FechaIngreso { get; set; }

        [Write(false)]
        public List<DetalleCompra> Detalles { get; set; } = new List<DetalleCompra>();

        public bool Guardar()
        {
            using (var conn = conexion)
            {
                Id = conn.Insert(this);

                for (int i = 0; i < Detalles.Count; i++)
                {
                    Detalles[i].IdCompra = Id;
                }
                var totalInsertados = Detalles[0].Guardar(Detalles);

                for (int i = 0; i < Detalles.Count; i++)
                {
                    // aumentar productos
                    Detalles[i].Producto.Actualizar(Detalles[i].Producto);
                }

                return totalInsertados == Detalles.Count;

            }

        }

        public override string ToString()
        {
            decimal total = 0;
            foreach (var item in Detalles)
            {
                total += item.Precio * item.Cantidad;
            }
            return total.ToString();
        }

    }
}
