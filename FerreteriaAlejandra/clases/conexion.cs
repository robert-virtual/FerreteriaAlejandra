using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FerreteriaAlejandra.clases
{
    class conexion
    {
        public MySqlConnection con;

        public  conexion()
        {
            string host = "localhost";
            string db = "ferreteria";
            string user = "gabriela";
            string pass = "P@ass0rd";
            string constring = $"server={host};uid={user};pwd={pass};database={db}";
            con = new MySqlConnection(constring);

        }



    }






    class CRUD : conexion
    {
        //Categorias
        public string nombre { set; get; }
        public string idCategorias { set; get; }

        //Tipo Producto
        public string idTipoProducto { set; get; }
        public string nombreTipo { set; get; }
        public int idTipoCategoria { set; get; }



        //Producto
        public string idProductos { set; get; }
        public string nombreProducto { set; get; }

        public string descripcion { set; get; }
        public float cantidad { set; get; }
        public string precioCompra { set; get; }
        public string precioVenta { set; get; }

        public int idTipo { set; get; }



        Boolean ebc = false;


        //READ PROPERTIES
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        //insertar
        public void guardarCategoria()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `categorias`(`nombre`) VALUES(@nombre)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //actualizar 
        public void actualizarCategoria()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE categorias SET nombre=@nombre where idCategorias=@idCategorias";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre;

                cmd.Parameters.Add("@idCategorias", MySqlDbType.Int64).Value = idCategorias;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //eliminar
        public void eliminarCategoria()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM categorias where idCategorias=@idCategorias";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;



                cmd.Parameters.Add("@idCategorias", MySqlDbType.Int64).Value = idCategorias;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }








        //READ FUNCTION 
        public void leer()
        {
            dt.Clear();
            string query = "SELECT * from `categorias`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }

        public ComboBox llenarCategoria(ComboBox combo1)
        {
            MySqlCommand cm = new MySqlCommand("ListarCategorias", con);

            cm.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);


            combo1.ValueMember = "idCategorias";
            combo1.DisplayMember = "nombre";

            combo1.DataSource = dt;
            return combo1;
        }








        //-------------------------------- TIPO PRODUCTO ----------------------------------//
        //insertar
        public void guardarTipo()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `tipoproducto`(`nombre`, categorias_idCategorias) VALUES(@nombre, @categorias_idCategorias)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombreTipo;
                cmd.Parameters.Add("@categorias_idCategorias", MySqlDbType.VarChar).Value = idTipoCategoria;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //actualizar 
        public void actualizarTipo()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE tipoproducto SET nombre=@nombre, categorias_idCategorias=@categorias_idCategorias  where idTipoProducto=@idTipoProducto";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombreTipo;
                cmd.Parameters.Add("@categorias_idCategorias", MySqlDbType.VarChar).Value = idTipoCategoria;
                cmd.Parameters.Add("@idTipoProducto", MySqlDbType.VarChar).Value = idTipoProducto;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //eliminar
        public void eliminarTipo()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM tipoproducto where idTipoProducto=@idTipoProducto";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;



                cmd.Parameters.Add("@idTipoProducto", MySqlDbType.VarChar).Value = idTipoProducto;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //READ FUNCTION 
        public void leerTipo()
        {
            dt.Clear();
            string query = "SELECT * from `tipoproducto`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }





        //--------------------------------  PRODUCTO ----------------------------------//
        //insertar
        /*  public void guardarProducto()
          {
              con.Open();
              using (MySqlCommand cmd = new MySqlCommand())
              {
                  cmd.CommandText = "INSERT INTO `productos`(`nombre`,`descripcion`,`cantidad`,`precioCompra`,`precioVenta`,  `tipoproducto_idTipoProducto`) VALUES(@nombre,@descripcion, @cantidad, @precioCompra, @precioVenta, @tipoproducto_idTipoProducto)";
                  cmd.CommandType = CommandType.Text;
                  cmd.Connection = con;

                  cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombreProducto;
                  cmd.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = descripcion;
                  cmd.Parameters.Add("@cantidad", MySqlDbType.Int64).Value = cantidad;
                  cmd.Parameters.Add("@precioCompra", MySqlDbType.Decimal).Value = precioCompra;
                  cmd.Parameters.Add("@precioVenta", MySqlDbType.Decimal).Value = precioVenta;


                  cmd.Parameters.Add("@tipoproducto_idTipoProducto", MySqlDbType.VarChar).Value = idTipo;


                  cmd.ExecuteNonQuery();
                  con.Close();
              }
          }*/


        public void guardarProducto(BuscarP bp)
        {
            MySqlConnection conn = con;
            conn.Open();

            try
            {
                MySqlCommand comand = new MySqlCommand("guardarProducto", conn);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add(new MySqlParameter("_idProductos", bp.IdProductos));
                comand.Parameters.Add(new MySqlParameter("_nombre", bp.Nombre));
                comand.Parameters.Add(new MySqlParameter("_descripcion", bp.Descripcion));
                comand.Parameters.Add(new MySqlParameter("_cantidad", bp.Cantidad));
                comand.Parameters.Add(new MySqlParameter("_precioCompra", bp.PrecioCompra));
                comand.Parameters.Add(new MySqlParameter("_precioVenta", bp.PrecioVenta));
                comand.Parameters.Add(new MySqlParameter("_tipoproducto_idTipoProducto", bp.IdTipoProducto));

                MySqlDataReader read = comand.ExecuteReader();

                MessageBox.Show("Producto registado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("guardarProducto", ex.ToString());

            }

            conn.Close();
        }


        public void actualizarProducto(BuscarP bp)
        {
            MySqlConnection conn = con;
            conn.Open();

            try
            {
                MySqlCommand comand = new MySqlCommand("actualizarProducto", conn);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add(new MySqlParameter("_idProductos", bp.IdProductos));
                comand.Parameters.Add(new MySqlParameter("_nombre", bp.Nombre));
                comand.Parameters.Add(new MySqlParameter("_descripcion", bp.Descripcion));
                comand.Parameters.Add(new MySqlParameter("_cantidad", bp.Cantidad));
                comand.Parameters.Add(new MySqlParameter("_precioVenta", bp.PrecioVenta));
                comand.Parameters.Add(new MySqlParameter("_precioCompra", bp.PrecioCompra));
                comand.Parameters.Add(new MySqlParameter("_tipoproducto_idTipoProducto", bp.IdTipoProducto));

                MySqlDataReader read = comand.ExecuteReader();


                MessageBox.Show("Producto actualizado", "Exito", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("actualizarProducto", ex.ToString());
            }

            conn.Close();
        }

        public void deleteProducto(BuscarP bp)
        {
            MySqlConnection conn = con;
            conn.Open();

            try
            {
                MySqlCommand comand = new MySqlCommand("deleteProducto", conn);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add(new MySqlParameter("_idProductos", bp.IdProductos));

                MySqlDataReader read = comand.ExecuteReader();

                MessageBox.Show("Producto Eliminado", "Exito", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("deleteProducto", ex.ToString());
            }

            conn.Close();
        }

        public Boolean validarProducto(BuscarP bp)
        {
            MySqlConnection conn = con;
            conn.Open();

            try
            {
                MySqlCommand comand = new MySqlCommand("deleteProducto", conn);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add(new MySqlParameter("_idProductos", bp.IdProductos));

                MySqlDataReader read = comand.ExecuteReader();

                if (read.Read())
                {
                    ebc = true;
                }
                else
                {
                    ebc = false;
                }


                MessageBox.Show("Producto no existe", "Exito", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("deleteProducto", ex.ToString());
            }

            conn.Close();

            return ebc;
        }








        //actualizar 
        public void actualizarProducto()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE productos SET nombre=@nombre, @descripcion, @cantidad, @precioCompra, @precioVenta, @tipoproducto_idTipoProducto where idProductos=@idProductos";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombreProducto;
                cmd.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = descripcion;
                cmd.Parameters.Add("@cantidad", MySqlDbType.Float).Value = cantidad;
                cmd.Parameters.Add("@precioCompra", MySqlDbType.Decimal).Value = precioCompra;
                cmd.Parameters.Add("@precioVenta", MySqlDbType.Decimal).Value = precioVenta;


                cmd.Parameters.Add("@tipoproducto_idTipoProducto", MySqlDbType.VarChar).Value = idTipo;




                cmd.Parameters.Add("@idProductos", MySqlDbType.VarChar).Value = idProductos;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //eliminar
        public void eliminarProducto()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM productos where idProductos=@idProductos";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;



                cmd.Parameters.Add("@idProductos", MySqlDbType.VarChar).Value = idProductos;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //READ FUNCTION 
        /* public void leerProducto()
         {
             dt.Clear();
             string query = "SELECT * from `productos`";
             MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
             MDA.Fill(ds);
             dt = ds.Tables[0];
         }*/


        public DataGridView mostrarTipos(DataGridView data)
        {
            MySqlConnection conn = con;
            conn.Open();
            try
            {
               
                MySqlCommand comand = new MySqlCommand("mostrarTipo", conn);
                comand.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(comand);
                DataTable dt = new DataTable();

                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mostrar Tipos", ex.ToString());
            }

            conn.Close();

            return data;
        }


        public void llenarTipo(ComboBox combo1)
        {
            MySqlCommand cm = new MySqlCommand("ListarTipos", con);

            cm.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);


            combo1.ValueMember = "idTipoProducto";
            combo1.DisplayMember = "nombre";

            combo1.DataSource = dt;
        }


        public DataGridView MostrarProducto(DataGridView data, string nombrePr)
        {
            MySqlConnection conn = con;
            conn.Open();

            try
            {
                MySqlCommand comand = new MySqlCommand("buscarProducto", conn);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add(new MySqlParameter("_nombre", nombrePr));

                MySqlDataAdapter da = new MySqlDataAdapter(comand);
                DataTable dt = new DataTable();

                da.Fill(dt);

                data.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("MostrarProducto" + ex.ToString());
            }

            conn.Close();

            return data;
        }
    }
}




