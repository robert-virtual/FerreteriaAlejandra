using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.clases
{
     class BuscarP
    {
        private string idProductos;
        private string nombre;
        private string descripcion;
        private float cantidad;
        private decimal precioCompra;
        private decimal precioVenta;
        private int idTipoProducto;

        public string IdProductos { get => idProductos; set => idProductos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }

        
        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
    }
}
