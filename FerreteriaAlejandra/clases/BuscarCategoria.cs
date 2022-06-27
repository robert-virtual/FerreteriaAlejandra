using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.clases
{
     class BuscarCategoria: conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT idCategorias, nombre FROM categorias ";
            }
            else
            {
                sql = "SELECT idCategorias, nombre FROM categorias where idCategorias LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' ";
            }
            try
            {

                MySqlConnection conexionBD = base.con;
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Buscar _busca = new Buscar();
                    _busca.IdCategorias = int.Parse(reader.GetString(0));
                    _busca.Nombre = reader[1].ToString();
                    lista.Add(_busca);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
    }
}
