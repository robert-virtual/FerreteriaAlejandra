using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("roles")]
    public class Rol:Operaciones<Rol>
    {
        public int Id { get; set; }

        public string Descripcion{ get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
