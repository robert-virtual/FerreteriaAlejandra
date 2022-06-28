using FerreteriaAlejandra.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaAlejandra
{
    public partial class Compras: Form
    {
        Producto producto = new Producto();
        Proveedor proveedor = new Proveedor();
        Compra compra = new Compra();
        DetalleCompra detalleCompra = new DetalleCompra();
        List<Producto> productos = new List<Producto>();
        public Compras()
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
            dgv_resumen.DataSource = compra.Detalles;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {
            txt_correo_proveedor.Clear();
            txt_descripcion.Clear();
            compra = new Compra();
            CargarDetalles();
            label_cliente.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_terminar_venta_Click(object sender, EventArgs e)
        {
            if (proveedor.Id == 0)
            {
                MessageBox.Show("Debe proporcionar datos de Proveedor ","Terminar Compra",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            compra.IdProveedor = proveedor.Id;
            compra.Proveedor = proveedor;
            compra.Descripcion = txt_descripcion.Text.Trim();
            compra.Guardar();
            MessageBox.Show($"Compra terminada con exito.\nTotal : {compra}","Compra Terminada",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            limpiar();
            CargarProductos();
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id =  (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[0].Value;
            var prod = productos.Find(p => p.Id == id);
            if (prod == null) return;
            producto = prod;
            n_precio.Value = prod.PrecioCompra;
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
        bool validarCorreo()
        {
            try
            {
                var email = new MailAddress(txt_correo_proveedor.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void txt_dni_cliente_KeyUp(object sender, KeyEventArgs e)
        {

            if (!validarCorreo())
            {
                label_cliente.Visible = false;
                return;
            }
            var res = proveedor.ObtenerPorCorreo(txt_correo_proveedor.Text.Trim());

            label_cliente.Visible = true;
            if (res == null)
            {
                label_cliente.ForeColor = Color.Red;
                label_cliente.Text = "No se encontro ningun Cliente con el dni proporcionado";
                return;
            }
            proveedor = res; 
            label_cliente.ForeColor = Color.White;
            label_cliente.Text = proveedor.Nombre ;
        }

        private void txt_dni_empleado_KeyUp(object sender, KeyEventArgs e)
        {
        }
        void ActualizarProductos()
        {
            dgv_productos.DataSource = null;
            dgv_productos.DataSource = productos;

        }
        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            if (producto.Id == 0) 
            {
                //MessageBox.Show("De click en el Producto que desea agregar","Agregar a la Compra",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var detalle = new DetalleCompra();
            detalle.Id = compra.Detalles.Count+1;
            detalle.Cantidad = (int)n_cantidad.Value;
            detalle.Precio= (int)n_precio.Value;
            detalle.IdProducto = producto.Id;
            detalle.Producto = producto;
            compra.Detalles.Add(detalle);
            CargarDetalles();
            label_total.Text = $"Total: {compra}";
            productos = productos.ConvertAll(p =>
            {
                if (p.Id == producto.Id) p.Cantidad += detalle.Cantidad;
                return p;
            });
            ActualizarProductos();
            producto = new Producto();

        }

        private void btn_quitar_producto_Click(object sender, EventArgs e)
        {
            if (detalleCompra.Id == 0) 
            {
                MessageBox.Show("De click en el Producto que desea Remover de la Compra","Remover de la Compra",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var res = MessageBox.Show("Esta seguro que quiere eliminar Este producto de la Compra?","Remover Producto de Compra",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;
            compra.Detalles.Remove(detalleCompra);
            CargarDetalles();
            label_total.Text = $"Total: {compra}";
            productos = productos.ConvertAll(p =>
            {
                if (p.Id == detalleCompra.Producto.Id) p.Cantidad -= detalleCompra.Cantidad;
                return p;
            });
            ActualizarProductos();
            detalleCompra = new DetalleCompra();  
        }

        private void dgv_resumen_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id =  (int)dgv_resumen.Rows[dgv_resumen.CurrentRow.Index].Cells[0].Value;
            var detalle = compra.Detalles.Find(d => d.Id == id);
            if (detalle == null) return;
            detalleCompra = detalle;

        }

        private void dgv_resumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
