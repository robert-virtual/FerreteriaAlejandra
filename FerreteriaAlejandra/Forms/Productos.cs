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
        Categoria categoria = new Categoria();

        public Productos()
        {
            InitializeComponent();
            CargarTiposProductos();
            CargarProductos();
        }
        private void CargarProductos()
        {
            dgv_productos.DataSource = producto.ObtenerTodos();
        }
        private void CargarTiposProductos()
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
            //if (e.RowIndex > -1 && e.ColumnIndex > -1)
            //{
            //    pb.IdProductos = datalistado.Rows[renglon].Cells["idProductos"].Value.ToString();
            //    pb.Nombre = datalistado.Rows[renglon].Cells["nombre"].Value.ToString();
            //    pb.Descripcion = datalistado.Rows[renglon].Cells["descripcion"].Value.ToString();
            //    pb.Cantidad = float.Parse(datalistado.Rows[renglon].Cells["cantidad"].Value.ToString());
            //    pb.PrecioVenta = decimal.Parse(datalistado.Rows[renglon].Cells["precioVenta"].Value.ToString());
            //    pb.PrecioCompra = decimal.Parse(datalistado.Rows[renglon].Cells["precioCompra"].Value.ToString());
            //    pb.IdTipoProducto = int.Parse(datalistado.Rows[renglon].Cells["tipoproducto_idTipoProducto"].Value.ToString());

            //    txtID.Text = pb.IdProductos;
            //    txtNombre.Text = pb.Nombre;
            //    txtDescripcion.Text = pb.Descripcion;
            //    numeric1.Text = Convert.ToString(pb.Cantidad);
            //    txtVenta.Text = Convert.ToString(pb.PrecioVenta);
            //    txtCompra.Text = Convert.ToString(pb.PrecioCompra);
            //    cmbTipo.SelectedValue = pb.IdTipoProducto;
            //}
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            producto.Nombre = txt_nombre.Text;
            producto.Descripcion = txt_descripcion.Text;

            producto.Cantidad = (int)n_cantidad.Value;
            producto.PrecioVenta = n_pventa.Value;
            producto.PrecioCompra = n_pcompra.Value;
            producto.IdCategoria = (int)cmb_categoria.SelectedValue;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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
    }
}
