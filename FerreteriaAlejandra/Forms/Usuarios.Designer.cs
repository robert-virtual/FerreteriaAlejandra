namespace FerreteriaAlejandra
{
    partial class Usuarios
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
            this.cb_ver_clave = new System.Windows.Forms.CheckBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.Des = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.cb_ver_clave);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.txt_clave);
            this.panel2.Controls.Add(this.Des);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_empleado);
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.dgv_empleados);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 621);
            this.panel2.TabIndex = 3;
            // 
            // cb_ver_clave
            // 
            this.cb_ver_clave.AutoSize = true;
            this.cb_ver_clave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_ver_clave.Location = new System.Drawing.Point(541, 190);
            this.cb_ver_clave.Name = "cb_ver_clave";
            this.cb_ver_clave.Size = new System.Drawing.Size(92, 24);
            this.cb_ver_clave.TabIndex = 32;
            this.cb_ver_clave.Text = "Ver Clave";
            this.cb_ver_clave.UseVisualStyleBackColor = true;
            this.cb_ver_clave.CheckedChanged += new System.EventHandler(this.cb_ver_clave_CheckedChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(715, 110);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(150, 29);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(541, 158);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(2);
            this.txt_clave.Multiline = true;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '●';
            this.txt_clave.Size = new System.Drawing.Size(150, 27);
            this.txt_clave.TabIndex = 30;
            // 
            // Des
            // 
            this.Des.AutoSize = true;
            this.Des.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Des.Location = new System.Drawing.Point(432, 161);
            this.Des.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Des.Name = "Des";
            this.Des.Size = new System.Drawing.Size(45, 20);
            this.Des.TabIndex = 29;
            this.Des.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(432, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(541, 114);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(150, 27);
            this.txt_usuario.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(33, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar";
            // 
            // txt_empleado
            // 
            this.txt_empleado.Enabled = false;
            this.txt_empleado.Location = new System.Drawing.Point(134, 113);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(220, 27);
            this.txt_empleado.TabIndex = 3;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(134, 224);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(220, 27);
            this.txt_buscar.TabIndex = 3;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(33, 259);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.RowTemplate.Height = 29;
            this.dgv_empleados.Size = new System.Drawing.Size(798, 307);
            this.dgv_empleados.TabIndex = 2;
            this.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(308, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 621);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txt_buscar;
        private DataGridView dgv_empleados;
        private Label label3;
        private TextBox txt_empleado;
        private CheckBox cb_ver_clave;
        private Button btn_guardar;
        private TextBox txt_clave;
        private Label Des;
        private Label label4;
        private TextBox txt_usuario;
    }
}