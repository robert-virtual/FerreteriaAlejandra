using FerreteriaAlejandra.clases;
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
        CRUD crud = new CRUD();
        BuscarP pb = new BuscarP();
        Boolean ebc = false;

        int renglon = 0;
        public Productos()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            numeric1.Text = "";
            txtVenta.Text = "";
            txtCompra.Text = "";
            cmbTipo.Text = "";
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                pb.IdProductos = datalistado.Rows[renglon].Cells["idProductos"].Value.ToString();
                pb.Nombre = datalistado.Rows[renglon].Cells["nombre"].Value.ToString();
                pb.Descripcion = datalistado.Rows[renglon].Cells["descripcion"].Value.ToString();
                pb.Cantidad = float.Parse(datalistado.Rows[renglon].Cells["cantidad"].Value.ToString());
                pb.PrecioVenta = decimal.Parse(datalistado.Rows[renglon].Cells["precioVenta"].Value.ToString());
                pb.PrecioCompra = decimal.Parse(datalistado.Rows[renglon].Cells["precioCompra"].Value.ToString());
                pb.IdTipoProducto = int.Parse(datalistado.Rows[renglon].Cells["tipoproducto_idTipoProducto"].Value.ToString());

                txtID.Text = pb.IdProductos;
                txtNombre.Text = pb.Nombre;
                txtDescripcion.Text = pb.Descripcion;
                numeric1.Text = Convert.ToString(pb.Cantidad);
                txtVenta.Text = Convert.ToString(pb.PrecioVenta);
                txtCompra.Text = Convert.ToString(pb.PrecioCompra);
                cmbTipo.SelectedValue = pb.IdTipoProducto;
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            datalistado = crud.mostrarTipos(datalistado);
            // READ();
            //  cargarTabla(null);
            crud.llenarTipo(cmbTipo);
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pb.IdProductos = null;
            pb.Nombre = txtNombre.Text;
            pb.Descripcion = txtDescripcion.Text;
            pb.Cantidad = int.Parse(numeric1.Text);
            pb.PrecioVenta = decimal.Parse(txtVenta.Text);
            pb.PrecioCompra = decimal.Parse(txtCompra.Text);
            pb.IdTipoProducto = int.Parse(cmbTipo.SelectedValue.ToString());

            crud.guardarProducto(pb);

            limpiar();

            datalistado = crud.mostrarTipos(datalistado);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            pb.IdProductos = txtID.Text;
            pb.Nombre = txtNombre.Text;
            pb.Descripcion = txtDescripcion.Text;
            pb.Cantidad = int.Parse(numeric1.Text);
            pb.PrecioVenta = decimal.Parse(txtVenta.Text);
            pb.PrecioCompra = decimal.Parse(txtCompra.Text);
            pb.IdTipoProducto = int.Parse(cmbTipo.SelectedValue.ToString());



            crud.actualizarProducto(pb);

            datalistado = crud.mostrarTipos(datalistado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pb.IdProductos = txtID.Text;

            crud.deleteProducto(pb);

            limpiar();

            datalistado = crud.mostrarTipos(datalistado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Es necesario que ingrese el nombre del producto", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Focus();

                return;
            }

            ebc = crud.validarProducto(pb);

            if (ebc == true)
            {
                MessageBox.Show("El producto: " + pb.Nombre + "ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //crud.nombreProducto = txtBuscar.Text;

            datalistado = crud.MostrarProducto(datalistado, txtBuscar.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datalistado = crud.mostrarTipos(datalistado);
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
            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre, "Introduce el nombre del producto");
                txtNombre.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDescripcion, "Introduce la descripcion del producto");
                txtDescripcion.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void numeric1_Validated(object sender, EventArgs e)
        {
            if (numeric1.Text.Trim() == "")
            {
                errorProvider1.SetError(numeric1, "Introduce la cantidad del producto");
                numeric1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCompra_Validated(object sender, EventArgs e)
        {
            if (txtCompra.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCompra, "Introduce el precio de la compra del producto");
                txtCompra.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtVenta_Validated(object sender, EventArgs e)
        {
            if (txtVenta.Text.Trim() == "")
            {
                errorProvider1.SetError(txtVenta, "Introduce el precio de la venta del producto");
                txtVenta.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
