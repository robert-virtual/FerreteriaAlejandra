using FerreteriaAlejandra.Clases;
using Isopoh.Cryptography.Argon2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaAlejandra
{
    public partial class Usuarios : Form
    {
        Empleado empleado = new Empleado();
        Usuario usuario = new Usuario();
        List<Empleado> empleados = new List<Empleado>();
        public Usuarios()
        {
            InitializeComponent();
            CargarEmpleados();

        }
        void CargarEmpleados()
        {
            empleados = empleado.ObtenerTodos().ToList();
            dgv_empleados.DataSource = empleados;
        }

        private void dgv_empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id =  (int)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells[0].Value;
            var empleado_ = empleados.Find(e => e.Id == id);
            if (empleado_ == null) return;
            empleado = empleado_;
            txt_empleado.Text = empleado.Nombre;
        }

        private void cb_ver_clave_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_ver_clave.Checked)
            {
                txt_clave.PasswordChar = '\0';
                return;
            }
            txt_clave.PasswordChar = '●';
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(empleado.Id == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado", "Guadar Usuario");
                return;
            }
            usuario.usuario = txt_usuario.Text;
            var passwordEncryptada = Argon2.Hash(txt_clave.Text);
            usuario.Password= passwordEncryptada;
            usuario.IdEmpleado = empleado.Id;
            usuario.Guardar(usuario);
            MessageBox.Show("Usuario creado con exito", "Guadar Usuario");
            Limpiar();
        }
        void Limpiar()
        {
            empleado = new Empleado();
            txt_clave.Clear();
            txt_usuario.Clear();
            txt_empleado.Clear();

        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
