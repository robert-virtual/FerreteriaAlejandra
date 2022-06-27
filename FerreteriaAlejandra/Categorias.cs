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
//using CRUD = mysql.clases;
using MySql.Data.MySqlClient;

namespace FerreteriaAlejandra
{
    public partial class Categorias : Form
    {
        CRUD crud = new CRUD();
        public Categorias()
        {
            InitializeComponent();
        }



        private void cargarTabla(string dato)
        {
            List<BuscarCategoria> lista = new List<BuscarCategoria>();
            BuscarCategoria buscarCategoria = new BuscarCategoria();
            datalistado.DataSource = buscarCategoria.consulta(dato);
        }

        //leer
        public void READ()
        {
            datalistado.DataSource = null;
            crud.leer();
            datalistado.DataSource = crud.dt;
        }
        //guardar
        public void Guardar()
        {

            crud.nombre = txtnombre.Text;
            crud.guardarCategoria();
        }
        public void actualizar()
        {
            crud.nombre = txtNombre1.Text;
            crud.idCategorias = txtId.Text;
            crud.actualizarCategoria();
        }
        public void eliminar()
        {

            crud.idCategorias = txtId.Text;
            crud.eliminarCategoria();
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
            Guardar();
            READ();
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
                if (datalistado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtId.Text = (datalistado.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNombre1.Text = (datalistado.Rows[e.RowIndex].Cells[1].Value.ToString());
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
