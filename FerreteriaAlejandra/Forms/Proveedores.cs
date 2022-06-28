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

namespace FerreteriaAlejandra
{
    public partial class Proveedores: Form
    {
        Proveedor proveedor = new Proveedor();
        List<Proveedor> proveedores = new List<Proveedor>();
        public Proveedores()
        {
            InitializeComponent();
            CargarProveedores();
        }
        
        private void CargarProveedores()
        {
            dgv_proveedores.DataSource = null;
            proveedores = proveedor.ObtenerTodos().ToList();
            dgv_proveedores.DataSource = proveedores;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Limpiar()
        {

             txt_nombre.Clear();

             txt_direccion.Clear();
             txt_telefono.Clear();
             txt_correo.Clear();
             proveedor = new Proveedor();
        }
        private void AsignarCliente()
        {

            proveedor.Nombre = txt_nombre.Text;

            proveedor.Direccion= txt_direccion.Text;
            proveedor.Telefono= txt_telefono.Text;
            proveedor.Correo= txt_correo.Text;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (proveedor.Id != 0)
            {
                MessageBox.Show("No se puede crear un Proveedor porque tiene selecionado un proveedor existente.\nClick en Nuevo para crear un nuevo Proveedor", "Crear proveedor",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            };
            AsignarCliente();
            proveedor.Guardar(proveedor);
            Limpiar();
            CargarProveedores();
        }
        

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var id =  (int)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells[0].Value;
            var proveedor_ = proveedores.Find(p => p.Id == id);
            if (proveedor_ == null) return;
            proveedor = proveedor_;
            txt_nombre.Text = proveedor_.Nombre;
            txt_direccion.Text = proveedor_.Direccion;
            txt_correo.Text = proveedor_.Correo;
            txt_telefono.Text = proveedor_.Telefono;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if(proveedor.Id == 0)
            {
                MessageBox.Show("Seleccione un Proveedor", "No ha seleccionado un Proveedor",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            AsignarCliente();
            proveedor.Actualizar(proveedor);
            MessageBox.Show("Proveedor actualizado","Actualizar Proveedor",MessageBoxButtons.OK,MessageBoxIcon.Information);
            CargarProveedores();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            if(proveedor.Id == 0)
            {
                
                MessageBox.Show("Seleccione un proveedor", "No ha seleccionado un proveedor",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            var res = MessageBox.Show("Esta seguro que quiere eliminar este proveedor?","Eliminar proveedor",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;
            proveedor.Eliminar(proveedor);
            CargarProveedores();
            MessageBox.Show("Proveedor Eliminado","Eliminar Proveedor",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            var buscar = txt_buscar.Text.ToLower();
            var proveedoresFiltrados = proveedores.Where(c => c.Nombre.ToLower().Contains(buscar) || c.Direccion.ToLower().Contains(buscar) ).ToList();
            dgv_proveedores.DataSource = proveedoresFiltrados;

        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
