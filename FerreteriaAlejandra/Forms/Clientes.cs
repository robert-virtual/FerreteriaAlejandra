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
    public partial class Clientes : Form
    {
        Cliente cliente = new Cliente();
        List<Cliente> clientes = new List<Cliente>();
        public Clientes()
        {
            InitializeComponent();
            CargarClientes();
        }
        
        private void CargarClientes()
        {
            dgv_clientes.DataSource = null;
            clientes = cliente.ObtenerTodos().ToList();
            dgv_clientes.DataSource = clientes;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Limpiar()
        {

             txt_nombre.Clear();
             txt_apellidos.Clear();
             txt_identidad.Clear();
             txt_rtn.Clear();

             txt_direccion.Clear();
             txt_telefono.Clear();
             txt_correo.Clear();
        }
        private void AsignarCliente()
        {

            cliente.Nombre = txt_nombre.Text;
            cliente.Apellidos = txt_apellidos.Text;
            cliente.Identidad= txt_identidad.Text;
            cliente.RTN= txt_rtn.Text;

            cliente.Direccion= txt_direccion.Text;
            cliente.Telefono= txt_telefono.Text;
            cliente.Correo= txt_correo.Text;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (cliente.Id != 0) return;
            AsignarCliente();
            cliente.Guardar(cliente);
            Limpiar();
            CargarClientes();
        }
        

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var id =  (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells[0].Value;
            var cliente_ = clientes.Find(p => p.Id == id);
            if (cliente_ == null) return;
            txt_identidad.Text = cliente_.Identidad;
            txt_rtn.Text = cliente_.RTN;
            cliente = cliente_;
            txt_nombre.Text = cliente_.Nombre;
            txt_apellidos.Text = cliente_.Apellidos;
            txt_direccion.Text = cliente_.Direccion;
            txt_correo.Text = cliente_.Correo;
            txt_telefono.Text = cliente_.Telefono;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if(cliente.Id == 0)
            {
                
                MessageBox.Show("Seleccione un cliente", "No ha seleccionado un cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            AsignarCliente();
            cliente.Actualizar(cliente);
            MessageBox.Show("Cliente actualizado","Actualizar Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
            CargarClientes();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            if(cliente.Id == 0)
            {
                
                MessageBox.Show("Seleccione un cliente", "No ha seleccionado un cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            var res = MessageBox.Show("Esta seguro que quiere eliminar este cliente?","Eliminar Cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;
            cliente.Eliminar(cliente);
            CargarClientes();
            MessageBox.Show("Cliente Eliminado","Eliminar Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            var buscar = txt_buscar.Text.ToLower();
            var clientesFiltrados = clientes.Where(c => c.Nombre.ToLower().Contains(buscar) || c.Apellidos.ToLower().Contains(buscar) || c.Direccion.ToLower().Contains(buscar) ).ToList();
            dgv_clientes.DataSource = clientesFiltrados;

        }
    }
}
