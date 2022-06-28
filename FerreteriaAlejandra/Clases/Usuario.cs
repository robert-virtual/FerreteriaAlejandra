using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("usuarios")]
    public class Usuario:Operaciones<Usuario>
    {
        [ExplicitKey]
        public string usuario { get; set; }
        public string Password{ get; set; }
        public bool Estado { get; set; } = true;
        public int IdEmpleado { get; set; }

        [Write(false)]
        public Empleado Empleado { get; set; }
        public Usuario()
        {
            Empleado = new Empleado();
            usuario = "";
            Password = "";
        }
           
        public Usuario? ObtenerPorId(string usuario)
        {
            using (var conn = conexion)
            {
                var res = conn.Get<Usuario>(usuario);
                if (res == null) return null;
                res.Empleado = Empleado.ObtenerPorId(res.IdEmpleado);
                return res;
            }
        }

    }
}
