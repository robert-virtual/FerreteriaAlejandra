using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("productos")]
    public class Producto:Operaciones<Producto>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta{ get; set; }
        public int IdCategoria{ get; set; }

        public new IEnumerable<Producto> ObtenerTodos()
        {
            using (var conn= conexion)
            {
                var sql = @"SELECT * FROM productos p INNER JOIN categorias c on c.id = p.idCategoria";
                var products = conn.Query<Producto, Categoria, Producto>(sql, (p, c) => {
                    p.Categoria = c;
                    return p;
                });
                return products;
            }
        }

        [Write(false)]
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return Nombre;
        }


    }
}
