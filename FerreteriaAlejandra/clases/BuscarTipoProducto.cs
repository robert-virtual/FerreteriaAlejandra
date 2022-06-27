using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.clases
{
    internal class BuscarTipoProducto : conexion
    {

        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT idTipoProducto, nombre FROM tipoproducto ";
            }
            else
            {
                sql = "SELECT idTipoProducto, nombre, categorias_idCategorias FROM tipoproducto where idTipoProducto LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR categorias_idCategorias LIKE '%" + dato + "%' ";
            }
            try
            {

                MySqlConnection conexionBD = base.con;
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    BuscarT _busca = new BuscarT();
                    _busca.IdTipoProducto = int.Parse(reader.GetString(0));
                    _busca.NombreProducto = reader[1].ToString();
                    //   _busca.CategoriaID = int.Parse(reader.GetString(1));
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
