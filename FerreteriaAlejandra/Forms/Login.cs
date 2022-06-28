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

namespace FerreteriaAlejandra.Forms
{
    public partial class Login : Form
    {
        public static Usuario usuario = new Usuario();
        Empleado empleado = new Empleado();
        public Login()
        {
            InitializeComponent();
            VerificarEmpleqadoPorDefecto();
        }
        void VerificarEmpleqadoPorDefecto(){
            var empleado_ = empleado.ObtenerPorDni("0703199801011");
            if(empleado_ == null)
            {
                // registrar usuario por defecto
                empleado.IdRole = 1;
                empleado.Nombre = "Gabriela Alejandra";
                empleado.Apellidos= " ";
                empleado.Telefono= "94087670";
                empleado.Correo= "gabriela@gabriela.com";
                empleado.Direccion = "Danli El Paraiso";
                empleado.DNI = "0703199801011";
                empleado.Genero= 'F';
                empleado.FechaNacimiento = new DateTime(1998,01,01);
                empleado.Id  = (int)empleado.Guardar(empleado);
            }
            else
            {
                empleado.Id  = empleado_.Id;
            }
            var usuario_= usuario.ObtenerPorId("gabriela");
            if (usuario_ == null)
            {
                usuario.usuario = "gabriela";
                // encryptar clave
                usuario.Password = Argon2.Hash("clave123");
                usuario.IdEmpleado = empleado.Id;
                usuario.Guardar(usuario);

            }
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

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            var res =  usuario.ObtenerPorId(txt_usuario.Text);
            if (res == null)
            {
                MessageBox.Show("Credenciales incorrectas", "Inicio de session",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var valido = Argon2.Verify(res.Password, txt_clave.Text);
            if (!valido)
            {
                MessageBox.Show("Credenciales incorrectas", "Inicio de session",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            // asignar el usuario global
            usuario = res;
            // asignar el usuario global
            // Abrir el formulario principal
            var main = new Main();
            main.Show();
            this.Hide();


        }
    }
}
