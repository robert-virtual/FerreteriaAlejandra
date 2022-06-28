namespace FerreteriaAlejandra
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.n_precio = new System.Windows.Forms.NumericUpDown();
            this.n_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_empleado = new System.Windows.Forms.Label();
            this.label_cliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.txt_dni_cliente = new System.Windows.Forms.TextBox();
            this.txt_dni_empleado = new System.Windows.Forms.TextBox();
            this.btn_terminar_venta = new System.Windows.Forms.Button();
            this.btn_quitar_producto = new System.Windows.Forms.Button();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.dgv_resumen = new System.Windows.Forms.DataGridView();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.n_precio);
            this.panel2.Controls.Add(this.n_cantidad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label_empleado);
            this.panel2.Controls.Add(this.label_cliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label_total);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.txt_dni_cliente);
            this.panel2.Controls.Add(this.txt_dni_empleado);
            this.panel2.Controls.Add(this.btn_terminar_venta);
            this.panel2.Controls.Add(this.btn_quitar_producto);
            this.panel2.Controls.Add(this.btn_agregar_producto);
            this.panel2.Controls.Add(this.dgv_resumen);
            this.panel2.Controls.Add(this.dgv_productos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 736);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // n_precio
            // 
            this.n_precio.Location = new System.Drawing.Point(209, 583);
            this.n_precio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.n_precio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_precio.Name = "n_precio";
            this.n_precio.Size = new System.Drawing.Size(150, 27);
            this.n_precio.TabIndex = 5;
            this.n_precio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // n_cantidad
            // 
            this.n_cantidad.Location = new System.Drawing.Point(36, 583);
            this.n_cantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.n_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_cantidad.Name = "n_cantidad";
            this.n_cantidad.Size = new System.Drawing.Size(150, 27);
            this.n_cantidad.TabIndex = 5;
            this.n_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_cantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(209, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(36, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // label_empleado
            // 
            this.label_empleado.AutoSize = true;
            this.label_empleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_empleado.Location = new System.Drawing.Point(518, 130);
            this.label_empleado.Name = "label_empleado";
            this.label_empleado.Size = new System.Drawing.Size(86, 20);
            this.label_empleado.TabIndex = 4;
            this.label_empleado.Text = "Empleado...";
            this.label_empleado.Visible = false;
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cliente.Location = new System.Drawing.Point(35, 130);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(64, 20);
            this.label_cliente.TabIndex = 4;
            this.label_cliente.Text = "Cliente...";
            this.label_cliente.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(36, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Buscar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(459, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Productos";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_total.Location = new System.Drawing.Point(891, 219);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(130, 20);
            this.label_total.TabIndex = 4;
            this.label_total.Text = "Resumen de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(519, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI empleado";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(94, 216);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(200, 27);
            this.txt_buscar.TabIndex = 3;
            this.txt_buscar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            // 
            // txt_dni_cliente
            // 
            this.txt_dni_cliente.Location = new System.Drawing.Point(35, 88);
            this.txt_dni_cliente.MaxLength = 13;
            this.txt_dni_cliente.Name = "txt_dni_cliente";
            this.txt_dni_cliente.Size = new System.Drawing.Size(200, 27);
            this.txt_dni_cliente.TabIndex = 3;
            this.txt_dni_cliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_dni_cliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dni_cliente_KeyUp);
            // 
            // txt_dni_empleado
            // 
            this.txt_dni_empleado.Location = new System.Drawing.Point(518, 88);
            this.txt_dni_empleado.MaxLength = 13;
            this.txt_dni_empleado.Name = "txt_dni_empleado";
            this.txt_dni_empleado.Size = new System.Drawing.Size(200, 27);
            this.txt_dni_empleado.TabIndex = 3;
            this.txt_dni_empleado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_dni_empleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dni_empleado_KeyUp);
            // 
            // btn_terminar_venta
            // 
            this.btn_terminar_venta.Location = new System.Drawing.Point(873, 583);
            this.btn_terminar_venta.Name = "btn_terminar_venta";
            this.btn_terminar_venta.Size = new System.Drawing.Size(148, 29);
            this.btn_terminar_venta.TabIndex = 2;
            this.btn_terminar_venta.Text = "Terminar Venta";
            this.btn_terminar_venta.UseVisualStyleBackColor = true;
            this.btn_terminar_venta.Click += new System.EventHandler(this.btn_terminar_venta_Click);
            // 
            // btn_quitar_producto
            // 
            this.btn_quitar_producto.Location = new System.Drawing.Point(575, 581);
            this.btn_quitar_producto.Name = "btn_quitar_producto";
            this.btn_quitar_producto.Size = new System.Drawing.Size(105, 29);
            this.btn_quitar_producto.TabIndex = 2;
            this.btn_quitar_producto.Text = "Quitar";
            this.btn_quitar_producto.UseVisualStyleBackColor = true;
            this.btn_quitar_producto.Click += new System.EventHandler(this.btn_quitar_producto_Click);
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Location = new System.Drawing.Point(429, 581);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(105, 29);
            this.btn_agregar_producto.TabIndex = 2;
            this.btn_agregar_producto.Text = "Agregar";
            this.btn_agregar_producto.UseVisualStyleBackColor = true;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // dgv_resumen
            // 
            this.dgv_resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resumen.Location = new System.Drawing.Point(575, 251);
            this.dgv_resumen.Name = "dgv_resumen";
            this.dgv_resumen.RowHeadersWidth = 51;
            this.dgv_resumen.RowTemplate.Height = 29;
            this.dgv_resumen.Size = new System.Drawing.Size(446, 296);
            this.dgv_resumen.TabIndex = 1;
            this.dgv_resumen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resumen_CellClick);
            this.dgv_resumen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resumen_CellContentClick);
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(35, 251);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 29;
            this.dgv_productos.Size = new System.Drawing.Size(499, 296);
            this.dgv_productos.TabIndex = 1;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 736);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Button btn_agregar_producto;
        private DataGridView dgv_productos;
        private Label label2;
        private TextBox txt_dni_empleado;
        private DataGridView dgv_resumen;
        private Label label3;
        private TextBox txt_dni_cliente;
        private NumericUpDown n_precio;
        private NumericUpDown n_cantidad;
        private Label label5;
        private Label label4;
        private Label label_total;
        private Button btn_terminar_venta;
        private Button btn_quitar_producto;
        private Label label7;
        private Label label8;
        private TextBox txt_buscar;
        private Label label_cliente;
        private Label label_empleado;
    }
}