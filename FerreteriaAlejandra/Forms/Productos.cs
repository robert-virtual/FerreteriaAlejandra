using FerreteriaAlejandra.clases;
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
    public partial class Productos : Form
    {
        Producto producto = new Producto();
        List<Producto> productos = new List<Producto>();
        Categoria categoria = new Categoria();

        public Productos()
        {
            InitializeComponent();
            CargarCategorias();
            CargarProductos();
        }
        private void CargarProductos()
        {
            dgv_productos.DataSource = null;
            productos = producto.ObtenerTodos().ToList();
            dgv_productos.DataSource = productos;
        }
        private void CargarCategorias()
        {
            cmb_categoria.DataSource = categoria.ObtenerTodos();
            cmb_categoria.DisplayMember = "Nombre";
            cmb_categoria.ValueMember = "Id";

        }
        public void limpiar()
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            n_cantidad.Text = "";
            n_pventa.Value = 0;
            n_pcompra.Value= 0;
            cmb_categoria.Text = "";
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
        private void AsignarProducto()
        {

            producto.Nombre = txt_nombre.Text;
            producto.Descripcion = txt_descripcion.Text;

            producto.Cantidad = (int)n_cantidad.Value;
            producto.PrecioVenta = n_pventa.Value;
            producto.PrecioCompra = n_pcompra.Value;
            producto.IdCategoria = (int)cmb_categoria.SelectedValue;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AsignarProducto();
            producto.Guardar(producto);
            limpiar();
            CargarProductos();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if(txt_id.Text == "")
            {
                MessageBox.Show("Seleccione un producto", "No ha seleccionado un producto");
                return;
            }
            AsignarProducto();
            producto.Actualizar(producto);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txt_id.Text == "")
            {
                MessageBox.Show("Seleccione un producto", "No ha seleccionado un producto");
                return;
            }
            producto.Eliminar(producto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Es necesario que ingrese el nombre del producto", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Focus();

                return;
            }

            if (true)
            {
                //MessageBox.Show("El producto: " + pb.Nombre + "ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //crud.nombreProducto = txtBuscar.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void numeric1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_nombre, "Introduce el nombre del producto");
                txt_nombre.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            if (txt_descripcion.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_descripcion, "Introduce la descripcion del producto");
                txt_descripcion.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void numeric1_Validated(object sender, EventArgs e)
        {
            if (n_cantidad.Text.Trim() == "")
            {
                errorProvider1.SetError(n_cantidad, "Introduce la cantidad del producto");
                n_cantidad.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCompra_Validated(object sender, EventArgs e)
        {
            if (n_pcompra.Value == 0)
            {
                errorProvider1.SetError(n_pcompra, "Introduce el precio de la compra del producto");
                n_pcompra.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtVenta_Validated(object sender, EventArgs e)
        {
            if (n_pventa.Value == 0)
            {
                errorProvider1.SetError(n_pventa, "Introduce el precio de la venta del producto");
                n_pventa.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            var prodFiltrados = productos.Where(p => p.Nombre.ToLower().Contains(txtBuscar.Text.ToLower())).ToList();
            if(prodFiltrados.Count > 0)
            {
                dgv_productos.DataSource = prodFiltrados;
                return;
            }
            dgv_productos.DataSource = productos;

        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var id =  (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[0].Value;
            var prod = productos.Find(p => p.Id == id);
            if (prod == null) return;
            txt_id.Text = prod.Id.ToString();
            txt_id.Enabled = false;
            producto = prod;
            txt_nombre.Text = prod.Nombre;
            txt_descripcion.Text = prod.Descripcion;
            n_cantidad.Value = prod.Cantidad;
            n_pventa.Value = prod.PrecioVenta;
            n_pcompra.Value = prod.PrecioCompra;
            cmb_categoria.SelectedValue = prod.IdCategoria;
        }
    }
}
