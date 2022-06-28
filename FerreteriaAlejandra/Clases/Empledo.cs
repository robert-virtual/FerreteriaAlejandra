using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("empleados")]
    public class Empleado:Operaciones<Empleado>
    {
        public int Id { get; set; }
        public string DNI{ get; set; }
        public string Nombre { get; set; }
        public string Direccion{ get; set; }
        public string Apellidos{ get; set; }
        public string Telefono{ get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public char Genero { get; set; }
        public int IdRole { get; set; }
        [Write(false)]
        public Rol Rol { get; set; }
        public Empleado? ObtenerPorDni(string dni)
        {
            using (var conn = conexion)
            {
                try
                {
                    return conn.QueryFirst<Empleado>("select * from empleados where dni = @dni", new {dni});
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

    }
}
