using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerreteriaAlejandra.clases;
using FerreteriaAlejandra.Clases;

namespace FerreteriaAlejandra
{
    public partial class Categorias : Form
    {

        Categoria categoria = new Categoria();
        public Categorias()
        {
            InitializeComponent();
            CargarCategorias();
        }



        private void CargarCategorias()
        {
            dgv_categorias.DataSource = null;
            dgv_categorias.DataSource = categoria.ObtenerTodos();
        }


        public void limpiar()
        {
            txtidcategoria.Text = "";
            txtnombre.Text = "";
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            categoria.Nombre = txtnombre.Text;
            categoria.Guardar(categoria);
            limpiar();
            CargarCategorias();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dgv_categorias.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtId.Text = (dgv_categorias.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNombre1.Text = (dgv_categorias.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("no hagas clic en el encabezado");
            }
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            if (txtnombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtnombre, "Introduce el nombre de la categoria");
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
                errorProvider1.SetError(txtNombre1, "Introduce el nombre de la categoria");
                txtNombre1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
