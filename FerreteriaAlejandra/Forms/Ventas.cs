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
    public partial class Ventas : Form
    {
        Producto producto = new Producto();
        Empleado empleado = new Empleado();
        Cliente cliente = new Cliente();
        Venta venta = new Venta();
        DetalleVenta detalleVenta = new DetalleVenta();
        List<Producto> productos = new List<Producto>();
        public Ventas()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarProductos()
        {
            //dgv_productos.DataSource = null;
            productos = producto.ObtenerTodos().ToList();
            dgv_productos.DataSource = productos;
        }
        private void CargarDetalles()
        {
            dgv_resumen.DataSource = null;
            dgv_resumen.DataSource = venta.Detalles;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {
            txt_dni_cliente.Clear();
            txt_dni_empleado.Clear();
            venta = new Venta();
            CargarDetalles();
            label_cliente.Visible = false;
            label_empleado.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_terminar_venta_Click(object sender, EventArgs e)
        {
            if (empleado.Id == 0 && cliente.Id == 0)
            {
                MessageBox.Show("Debe proporcionar doatos de cliente y empleado","Terminar Venta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            venta.IdCliente = cliente.Id;
            venta.IdEmpleado = empleado.Id;
            venta.Cliente = cliente;
            venta.Empleado = empleado;
            venta.Guardar();
            MessageBox.Show($"Venta terminada con exito.\nTotal a pagar: {venta}","Venta Terminada",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            limpiar();
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id =  (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[0].Value;
            var prod = productos.Find(p => p.Id == id);
            if (prod == null) return;
            producto = prod;
            n_cantidad.Value = prod.Cantidad;
            n_precio.Value = prod.PrecioVenta;
            n_cantidad.Maximum = prod.Cantidad;
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {

            var prodFiltrados = productos.Where(p => p.Nombre.ToLower().Contains(txt_buscar.Text.ToLower())).ToList();
            if(prodFiltrados.Count > 0)
            {
                dgv_productos.DataSource = prodFiltrados;
                return;
            }
            dgv_productos.DataSource = productos;
        }

        private void txt_dni_cliente_KeyUp(object sender, KeyEventArgs e)
        {

            if (txt_dni_cliente.Text.Trim().Length != 13)
            {
                label_cliente.Visible = false;
                return;
            }
            var res = cliente.ObtenerPorDni(txt_dni_cliente.Text.Trim());

            label_cliente.Visible = true;
            if (res == null)
            {
                label_cliente.ForeColor = Color.Red;
                label_cliente.Text = "No se encontro ningun Cliente con el dni proporcionado";
                return;
            }
            cliente = res; 
            label_cliente.ForeColor = Color.White;
            label_cliente.Text = cliente.Nombre ;
        }

        private void txt_dni_empleado_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_dni_empleado.Text.Trim().Length != 13)
            {
                label_empleado.Visible = false;
                return;
            }
            var res = empleado.ObtenerPorDni(txt_dni_empleado.Text.Trim());
            label_empleado.Visible = true;
            if (res == null)
            {
                label_empleado.ForeColor = Color.Red;
                label_empleado.Text = "No se encontro ningun Empleado con el dni proporcionado";
                return;
            }
            empleado = res;
            label_empleado.ForeColor = Color.White;
            label_empleado.Text = empleado.Nombre;

        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            var detalle = new DetalleVenta();
            detalle.Id = venta.Detalles.Count+1;
            detalle.Cantidad = (int)n_cantidad.Value;
            detalle.Precio= (int)n_precio.Value;
            detalle.IdProducto = producto.Id;
            detalle.Producto = producto;
            venta.Detalles.Add(detalle);
            CargarDetalles();
            label_total.Text = $"Total: {venta}";
        }

        private void btn_quitar_producto_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro que quiere eliminar Este producto de la venta?","Remover Producto de venta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;
            venta.Detalles.Remove(detalleVenta);
            CargarDetalles();
            label_total.Text = $"Total: {venta}";
        }

        private void dgv_resumen_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id =  (int)dgv_resumen.Rows[dgv_resumen.CurrentRow.Index].Cells[0].Value;
            var detalle = venta.Detalles.Find(d => d.Id == id);
            if (detalle == null) return;
            detalleVenta = detalle;

        }
    }
}
