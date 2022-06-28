namespace FerreteriaAlejandra.Forms
{
    partial class Roles
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
            this.dgv_roles = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.label_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_roles
            // 
            this.dgv_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_roles.Location = new System.Drawing.Point(52, 321);
            this.dgv_roles.Name = "dgv_roles";
            this.dgv_roles.RowHeadersWidth = 51;
            this.dgv_roles.RowTemplate.Height = 29;
            this.dgv_roles.Size = new System.Drawing.Size(563, 285);
            this.dgv_roles.TabIndex = 28;
            this.dgv_roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_roles_CellClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(56, 189);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(123, 29);
            this.btn_nuevo.TabIndex = 32;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(202, 189);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(123, 29);
            this.btn_eliminar.TabIndex = 31;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(353, 189);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(123, 29);
            this.btn_actualizar.TabIndex = 30;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(492, 189);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 29);
            this.btn_guardar.TabIndex = 29;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Location = new System.Drawing.Point(492, 269);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(123, 29);
            this.btn_refrescar.TabIndex = 33;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_buscar.Location = new System.Drawing.Point(52, 248);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(52, 20);
            this.label_buscar.TabIndex = 35;
            this.label_buscar.Text = "Buscar";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(52, 271);
            this.txt_buscar.MaxLength = 50;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(332, 27);
            this.txt_buscar.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(52, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(52, 144);
            this.txt_descripcion.MaxLength = 255;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(152, 27);
            this.txt_descripcion.TabIndex = 36;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(680, 618);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_roles);
            this.Name = "Roles";
            this.Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_roles;
        private Button btn_nuevo;
        private Button btn_eliminar;
        private Button btn_actualizar;
        private Button btn_guardar;
        private Button btn_refrescar;
        private Label label_buscar;
        private TextBox txt_buscar;
        private Label label4;
        private TextBox txt_descripcion;
    }
}