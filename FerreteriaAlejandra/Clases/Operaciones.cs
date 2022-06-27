using Dapper.Contrib.Extensions;
using FerreteriaAlejandra.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.Clases
{
    public class Operaciones<T>:Conexion where T:class
    {
        public IEnumerable<T> ObtenerTodos()
        {
            using (var conn = conexion)
            {
                return conn.GetAll<T>();
            }
        }
        public T ObtenerPorId(int id)
        {
            using (var conn = conexion)
            {
                return conn.Get<T>(id);
            }
        }
        public bool Eliminar(T entity)
        {
            using (var conn = conexion)
            {
                return conn.Delete(entity);
            }
        }
        public bool Actualizar(T entity)
        {
            using (var conn = conexion)
            {
                return conn.Update(entity);
            }
        }
        public long Guardar(T entity)
        {
            using (var conn = conexion)
            {
                return conn.Insert(entity);
            }
        }
    }
}
