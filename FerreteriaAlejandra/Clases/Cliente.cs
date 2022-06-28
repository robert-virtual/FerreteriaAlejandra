using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("clientes")]
    public class Cliente:Operaciones<Cliente>
    {
        public int Id { get; set; }
        public string Identidad { get; set; }
        public string RTN{ get; set; }
        public string Nombre { get; set; }
        public string Direccion{ get; set; }
        public string Apellidos{ get; set; }
        public string Telefono{ get; set; }
        public string Correo { get; set; }
        public Cliente? ObtenerPorDni(string dni)
        {
            using (var conn = conexion)
            {
                try
                {
                   return conn.QuerySingle<Cliente>("select * from clientes where identidad = @dni", new {dni});
                }
                catch (Exception)
                {
                    return null;
                }

            }
        }

    }
}
