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
    public partial class TipoProducto : Form
    {
        public TipoProducto()
        {
            InitializeComponent();
        }



        //cargar tabla
        private void cargarTabla(string dato)
        {
        }

        //leer
        public void READ()
        {
            datalistado.DataSource = null;
        }
        //guardar
        public void Guardar()
        {
        }
        public void actualizar()
        {
        }
        public void eliminar()
        {
        }

        public void limpiar()
        {
            txtidcategoria.Text = "";
            txtnombre.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            READ();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
            READ();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            READ();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            cargarTabla(dato);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            READ();
            cargarTabla(null);
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (datalistado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtId.Text = (datalistado.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNombre1.Text = (datalistado.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmbCategoria1.Text = (datalistado.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("no hagas clic en el encabezado");
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            if (txtnombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtnombre, "Introduce el nombre del tipo de producto");
                txtnombre.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNombre1_Validated(object sender, EventArgs e)
        {
            if (txtNombre1.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre1, "Introduce el nombre del tipo de producto");
                txtNombre1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
