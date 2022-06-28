namespace FerreteriaAlejandra
{
    partial class Empleados
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
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmb_rol = new System.Windows.Forms.ComboBox();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.btn_crear_rol = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_buscar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.dtp_fecha_nacimiento);
            this.panel2.Controls.Add(this.cmb_rol);
            this.panel2.Controls.Add(this.cmb_genero);
            this.panel2.Controls.Add(this.dgv_empleados);
            this.panel2.Controls.Add(this.btn_crear_rol);
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.btn_refrescar);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label_buscar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.birthday);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_apellidos);
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.txt_direccion);
            this.panel2.Controls.Add(this.txt_correo);
            this.panel2.Controls.Add(this.txt_telefono);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.txt_dni);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 768);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(784, 226);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(250, 27);
            this.dtp_fecha_nacimiento.TabIndex = 29;
            // 
            // cmb_rol
            // 
            this.cmb_rol.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F",
            "O"});
            this.cmb_rol.FormattingEnabled = true;
            this.cmb_rol.Location = new System.Drawing.Point(781, 144);
            this.cmb_rol.Name = "cmb_rol";
            this.cmb_rol.Size = new System.Drawing.Size(151, 28);
            this.cmb_rol.TabIndex = 28;
            // 
            // cmb_genero
            // 
            this.cmb_genero.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F",
            "O"});
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cmb_genero.Location = new System.Drawing.Point(40, 227);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(151, 28);
            this.cmb_genero.TabIndex = 28;
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(28, 388);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.RowTemplate.Height = 29;
            this.dgv_empleados.Size = new System.Drawing.Size(1006, 500);
            this.dgv_empleados.TabIndex = 27;
            this.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellClick);
            // 
            // btn_crear_rol
            // 
            this.btn_crear_rol.Location = new System.Drawing.Point(948, 143);
            this.btn_crear_rol.Name = "btn_crear_rol";
            this.btn_crear_rol.Size = new System.Drawing.Size(123, 29);
            this.btn_crear_rol.TabIndex = 26;
            this.btn_crear_rol.Text = "Crear Rol";
            this.btn_crear_rol.UseVisualStyleBackColor = true;
            this.btn_crear_rol.Click += new System.EventHandler(this.btn_crear_rol_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(475, 290);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(123, 29);
            this.btn_nuevo.TabIndex = 26;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(621, 290);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(123, 29);
            this.btn_eliminar.TabIndex = 25;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(772, 290);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(123, 29);
            this.btn_actualizar.TabIndex = 24;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Location = new System.Drawing.Point(911, 355);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(123, 29);
            this.btn_refrescar.TabIndex = 23;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(911, 290);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 29);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(224, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Apellidos";
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_buscar.Location = new System.Drawing.Point(28, 332);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(52, 20);
            this.label_buscar.TabIndex = 19;
            this.label_buscar.Text = "Buscar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(420, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(600, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(420, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefono";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthday.Location = new System.Drawing.Point(781, 193);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(149, 20);
            this.birthday.TabIndex = 15;
            this.birthday.Text = "Fecha de Nacimiento";
            this.birthday.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(780, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rol";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(224, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Genero";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "DNI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(224, 228);
            this.txt_apellidos.MaxLength = 255;
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(152, 27);
            this.txt_apellidos.TabIndex = 12;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(28, 355);
            this.txt_buscar.MaxLength = 50;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(332, 27);
            this.txt_buscar.TabIndex = 11;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(420, 228);
            this.txt_direccion.MaxLength = 255;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(332, 27);
            this.txt_direccion.TabIndex = 10;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(600, 146);
            this.txt_correo.MaxLength = 320;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(152, 27);
            this.txt_correo.TabIndex = 9;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(420, 145);
            this.txt_telefono.MaxLength = 8;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(152, 27);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(224, 145);
            this.txt_nombre.MaxLength = 255;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(152, 27);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(39, 146);
            this.txt_dni.MaxLength = 13;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(152, 27);
            this.txt_dni.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(306, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 768);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label label1;
        private ComboBox cmb_genero;
        private DataGridView dgv_empleados;
        private Button btn_nuevo;
        private Button btn_eliminar;
        private Button btn_actualizar;
        private Button btn_refrescar;
        private Button btn_guardar;
        private Label label5;
        private Label label_buscar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txt_apellidos;
        private TextBox txt_buscar;
        private TextBox txt_direccion;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_nombre;
        private TextBox txt_dni;
        private Label label2;
        private DateTimePicker dtp_fecha_nacimiento;
        private ComboBox cmb_rol;
        private Label birthday;
        private Label label9;
        private Button btn_crear_rol;
    }
}