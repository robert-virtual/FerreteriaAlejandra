namespace FerreteriaAlejandra.Forms
{
    partial class Login
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
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.Des = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.cb_ver_clave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(346, 166);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(2);
            this.txt_clave.Multiline = true;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '●';
            this.txt_clave.Size = new System.Drawing.Size(150, 27);
            this.txt_clave.TabIndex = 24;
            // 
            // Des
            // 
            this.Des.AutoSize = true;
            this.Des.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Des.Location = new System.Drawing.Point(237, 169);
            this.Des.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Des.Name = "Des";
            this.Des.Size = new System.Drawing.Size(45, 20);
            this.Des.TabIndex = 23;
            this.Des.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(237, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(346, 122);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(150, 27);
            this.txt_usuario.TabIndex = 21;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(346, 248);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(150, 29);
            this.btn_entrar.TabIndex = 25;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // cb_ver_clave
            // 
            this.cb_ver_clave.AutoSize = true;
            this.cb_ver_clave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_ver_clave.Location = new System.Drawing.Point(346, 198);
            this.cb_ver_clave.Name = "cb_ver_clave";
            this.cb_ver_clave.Size = new System.Drawing.Size(92, 24);
            this.cb_ver_clave.TabIndex = 26;
            this.cb_ver_clave.Text = "Ver Clave";
            this.cb_ver_clave.UseVisualStyleBackColor = true;
            this.cb_ver_clave.CheckedChanged += new System.EventHandler(this.cb_ver_clave_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_ver_clave);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.Des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usuario);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_clave;
        private Label Des;
        private Label label3;
        private TextBox txt_usuario;
        private Button btn_entrar;
        private CheckBox cb_ver_clave;
    }
}