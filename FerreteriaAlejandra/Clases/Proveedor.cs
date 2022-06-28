using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("proveedores")]
    public class Proveedor:Operaciones<Proveedor>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion{ get; set; }
        public string Telefono{ get; set; }
        public string Correo { get; set; }
        public Proveedor? ObtenerPorCorreo(string correo)
        {
            using (var conn = conexion)
            {
                try
                {
                   return conn.QuerySingle<Proveedor>("select * from proveedores where correo = @correo", new {correo});
                }
                catch (Exception)
                {
                    return null;
                }

            }
        }

    }
}
