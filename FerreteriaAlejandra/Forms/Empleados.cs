using FerreteriaAlejandra.Clases;
using FerreteriaAlejandra.Forms;
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
    public partial class Empleados : Form
    {
        Empleado empleado = new Empleado();
        List<Empleado> empleados = new List<Empleado>();
        Rol rol = new Rol();
        List<Rol> roles = new List<Rol>();
        public Empleados()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarRoles();
            dtp_fecha_nacimiento.MaxDate = new DateTime(DateTime.Now.Year-18,01,01);
        }
        void CargarEmpleados()
        {
            empleados = empleado.ObtenerTodos().ToList();
            dgv_empleados.DataSource = empleados;
        }
        void CargarRoles()
        {
            roles = rol.ObtenerTodos().ToList();
            cmb_rol.DataSource = roles;
            cmb_rol.DisplayMember = "Descripcion";
            cmb_rol.ValueMember = "Id";
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void AsignarEmpleado()
        {

            empleado.Nombre = txt_nombre.Text;
            empleado.Apellidos = txt_apellidos.Text;
            empleado.DNI= txt_dni.Text;
            empleado.Direccion= txt_direccion.Text;
            empleado.Telefono= txt_telefono.Text;
            empleado.Correo= txt_correo.Text;
            empleado.FechaNacimiento = dtp_fecha_nacimiento.Value;
            empleado.IdRole = (int)cmb_rol.SelectedValue;
            empleado.Genero = cmb_rol.Text[0];
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {

             txt_nombre.Clear();
             txt_apellidos.Clear();
             txt_dni.Clear();
             txt_direccion.Clear();
             txt_telefono.Clear();
             txt_correo.Clear();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            AsignarEmpleado();
            empleado.Guardar(empleado);
            Limpiar();
            CargarEmpleados();
        }

        private void btn_crear_rol_Click(object sender, EventArgs e)
        {

            var formRoles = new Roles();
            formRoles.ShowDialog();
            CargarRoles();
        }

        private void dgv_empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id =  (int)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells[0].Value;
            var empleado_ = empleados.Find(p => p.Id == id);
            if (empleado_ == null) return;
            txt_dni.Text = empleado_.DNI;
            empleado = empleado_;
            txt_nombre.Text = empleado_.Nombre;
            txt_apellidos.Text = empleado_.Apellidos;
            txt_direccion.Text = empleado_.Direccion;
            txt_correo.Text = empleado_.Correo;
            txt_telefono.Text = empleado_.Telefono;
            dtp_fecha_nacimiento.Value = empleado_.FechaNacimiento;
            cmb_genero.SelectedValue = empleado_.Genero;
            cmb_rol.SelectedValue = empleado_.IdRole;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            if(empleado.Id == 0)
            {
                
                MessageBox.Show("Seleccione un empleado", "No ha seleccionado un Empleado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            AsignarEmpleado();
            empleado.Actualizar(empleado);
            MessageBox.Show("Empleado actualizado","Actualizar Empleado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            CargarEmpleados();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if(empleado.Id == 0)
            {
                
                MessageBox.Show("Seleccione un empleado", "No ha seleccionado un Empleado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show("Esta seguro que quiere eliminar este Empleado ?","Eliminar Empleado",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;

            empleado.Eliminar(empleado);    
            CargarEmpleados();
            MessageBox.Show("Empleado Eliminado","Eliminar Empleado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
