using FerreteriaAlejandra.Clases;
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
    public partial class Roles : Form
    {
        Rol rol = new Rol();
        List<Rol> roles = new List<Rol>();
        public Roles()
        {
            InitializeComponent();
            CargarRoles();
        }
        private void CargarRoles()
        {
            dgv_roles.DataSource = null;
            roles = rol.ObtenerTodos().ToList();
            dgv_roles.DataSource = roles;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            rol.Descripcion = txt_descripcion.Text;
            rol.Guardar(rol);
            txt_descripcion.Clear();
            CargarRoles();

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            if(rol.Id == 0)
            {
                
                MessageBox.Show("Seleccione un cliente", "No ha seleccionado un cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            rol.Descripcion = txt_descripcion.Text;
            rol.Actualizar(rol);
            CargarRoles();
            

        }

        private void dgv_roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id =  (int)dgv_roles.Rows[dgv_roles.CurrentRow.Index].Cells[0].Value;
            var rol_ = roles.Find(p => p.Id == id);
            if (rol_ == null) return;
            txt_descripcion.Text = rol_.Descripcion;
            rol = rol_;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if(rol.Id == 0)
            {
                
                MessageBox.Show("Seleccione un cliente", "No ha seleccionado un cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            rol.Eliminar(rol);
            CargarRoles();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_descripcion.Clear();
        }
        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            var buscar = txt_buscar.Text.ToLower();
            var rolesFiltrados = roles.Where(c => c.Descripcion.ToLower().Contains(buscar));
            dgv_roles.DataSource = rolesFiltrados;

        }
    }
}
