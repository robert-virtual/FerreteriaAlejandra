using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.clases
{
     class BuscarT
    {
        private int idTipoProducto;
        private string nombreProducto;
        private int categoriaID;

        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CategoriaID { get => categoriaID; set => categoriaID = value; }
    }
}
