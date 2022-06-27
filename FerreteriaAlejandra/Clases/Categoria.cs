using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    [Table("categorias")]
    public class Categoria:Operaciones<Categoria>
    {
        public int Id { get; set; }

        public string Nombre{ get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
