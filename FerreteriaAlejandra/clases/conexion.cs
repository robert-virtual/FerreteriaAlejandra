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
    public class Conexion
    {
        public MySqlConnection conexion;

        public  Conexion()
        {
            string host = "localhost";
            string db = "ferreteria";
            string user = "gabriela";
            string pass = "P@ass0rd";
            string constring = $"server={host};uid={user};pwd={pass};database={db}";
            conexion = new MySqlConnection(constring);
        }
    }
}




