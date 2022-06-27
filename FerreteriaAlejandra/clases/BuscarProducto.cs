using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaAlejandra.clases
{
    internal class BuscarProducto: conexion
    {
        /* public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT idProductos, nombre FROM productos ";
            }
            else
            {
                sql = "SELECT idProductos, nombre, descripcion,cantidad, precioCompra,precioVenta, tipoproducto_idTipoProducto FROM productos where idProductos LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR descripcion LIKE '%" + dato + "%' OR cantidad LIKE '%" + dato + "%' OR precioCompra LIKE '%" + dato + "%' OR precioVenta LIKE '%" + dato + "%'  OR  tipoproducto_idTipoProducto LIKE '%" + dato + "%' ";
            }
            try
            {
                MySqlConnection conexionBD = base.con;
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    BuscarP _busca = new BuscarP();
                    _busca.IdProductos = int.Parse(reader.GetString(0));
                    _busca.Nombre = reader[0].ToString();
                    _busca.Descripcion = reader[1].ToString();
                    _busca.Cantidad = int.Parse(reader.GetString(0));
                    _busca.PrecioCompra = decimal.Parse(reader.GetString(0));
                    _busca.PrecioVenta = decimal.Parse(reader.GetString(0));
                    
                    
                    _busca.IdTipoProducto = int.Parse(reader.GetString(0));
                    lista.Add(_busca);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }*/
    }
}
