using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("ventas")]
    public class Venta:Operaciones<Venta>
    {
        public long Id { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }

        [Write(false)]
        public Cliente Cliente{ get; set; }

        [Write(false)]
        public Empleado Empleado{ get; set; }

        [Write(false)]
        public DateTime FechaVenta { get; set; }

        [Write(false)]
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        public bool Guardar()
        {
            using (var conn = conexion)
            {
                Id = conn.Insert(this);

                for (int i = 0; i < Detalles.Count; i++)
                {
                    Detalles[i].IdVenta = Id;
                }
                var totalInsertados = Detalles[0].Guardar(Detalles);

                for (int i = 0; i < Detalles.Count; i++)
                {
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
