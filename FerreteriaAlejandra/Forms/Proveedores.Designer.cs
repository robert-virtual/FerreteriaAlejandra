namespace FerreteriaAlejandra
{
    partial class Proveedores 
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
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label_buscar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.dgv_proveedores);
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.btn_refrescar);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.label_buscar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.txt_direccion);
            this.panel2.Controls.Add(this.txt_correo);
            this.panel2.Controls.Add(this.txt_telefono);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 575);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Location = new System.Drawing.Point(38, 375);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.RowHeadersWidth = 51;
            this.dgv_proveedores.RowTemplate.Height = 29;
            this.dgv_proveedores.Size = new System.Drawing.Size(724, 500);
            this.dgv_proveedores.TabIndex = 5;
            this.dgv_proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(203, 286);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(123, 29);
            this.btn_nuevo.TabIndex = 4;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(349, 286);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(123, 29);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(500, 286);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(123, 29);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Location = new System.Drawing.Point(639, 340);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(123, 29);
            this.btn_refrescar.TabIndex = 4;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(639, 286);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 29);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_buscar.Location = new System.Drawing.Point(38, 319);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(52, 20);
            this.label_buscar.TabIndex = 3;
            this.label_buscar.Text = "Buscar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(40, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(416, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(236, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(38, 342);
            this.txt_buscar.MaxLength = 50;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(332, 27);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(40, 221);
            this.txt_direccion.MaxLength = 255;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(332, 27);
            this.txt_direccion.TabIndex = 2;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(416, 140);
            this.txt_correo.MaxLength = 320;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(152, 27);
            this.txt_correo.TabIndex = 2;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(236, 139);
            this.txt_telefono.MaxLength = 8;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(152, 27);
            this.txt_telefono.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(40, 139);
            this.txt_nombre.MaxLength = 255;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(152, 27);
            this.txt_nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedores";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 575);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Clientes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Label label1;
        private DataGridView dgv_proveedores;
        private Button btn_guardar;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_nombre;
        private Button btn_actualizar;
        private Button btn_refrescar;
        private Label label_buscar;
        private TextBox txt_buscar;
        private Button btn_nuevo;
        private Button btn_eliminar;
        private Label label8;
        private TextBox txt_direccion;
    }
}