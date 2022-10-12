namespace VistaAero
{
    partial class Frm_login
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_autocompletar = new System.Windows.Forms.Button();
            this.btn_loguear = new System.Windows.Forms.Button();
            this.lnk_ayuda = new System.Windows.Forms.LinkLabel();
            this.lbl_ayudauser = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(125, 59);
            this.txt_user.Name = "txt_user";
            this.txt_user.PlaceholderText = "Ingrese usuario";
            this.txt_user.Size = new System.Drawing.Size(115, 23);
            this.txt_user.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(125, 88);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "Ingrese contraseña";
            this.txt_password.Size = new System.Drawing.Size(115, 23);
            this.txt_password.TabIndex = 3;
            // 
            // btn_autocompletar
            // 
            this.btn_autocompletar.Location = new System.Drawing.Point(126, 146);
            this.btn_autocompletar.Name = "btn_autocompletar";
            this.btn_autocompletar.Size = new System.Drawing.Size(115, 25);
            this.btn_autocompletar.TabIndex = 4;
            this.btn_autocompletar.Text = "Autocompletar";
            this.btn_autocompletar.UseVisualStyleBackColor = true;
            this.btn_autocompletar.Click += new System.EventHandler(this.btn_autocompletar_Click);
            // 
            // btn_loguear
            // 
            this.btn_loguear.Location = new System.Drawing.Point(126, 115);
            this.btn_loguear.Name = "btn_loguear";
            this.btn_loguear.Size = new System.Drawing.Size(115, 25);
            this.btn_loguear.TabIndex = 5;
            this.btn_loguear.Text = "Loguear";
            this.btn_loguear.UseVisualStyleBackColor = true;
            this.btn_loguear.Click += new System.EventHandler(this.btn_loguear_Click);
            // 
            // lnk_ayuda
            // 
            this.lnk_ayuda.AutoSize = true;
            this.lnk_ayuda.Location = new System.Drawing.Point(12, 9);
            this.lnk_ayuda.Name = "lnk_ayuda";
            this.lnk_ayuda.Size = new System.Drawing.Size(106, 15);
            this.lnk_ayuda.TabIndex = 6;
            this.lnk_ayuda.TabStop = true;
            this.lnk_ayuda.Text = "Ayuda desactivada";
            this.lnk_ayuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ayuda_LinkClicked);
            // 
            // lbl_ayudauser
            // 
            this.lbl_ayudauser.AutoSize = true;
            this.lbl_ayudauser.Location = new System.Drawing.Point(246, 62);
            this.lbl_ayudauser.Name = "lbl_ayudauser";
            this.lbl_ayudauser.Size = new System.Drawing.Size(291, 15);
            this.lbl_ayudauser.TabIndex = 7;
            this.lbl_ayudauser.Text = "En esta casilla se puede ingresar el usuario por teclado";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 173);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(553, 208);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_ayudauser);
            this.Controls.Add(this.lnk_ayuda);
            this.Controls.Add(this.btn_loguear);
            this.Controls.Add(this.btn_autocompletar);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_autocompletar;
        private System.Windows.Forms.Button btn_loguear;
        private System.Windows.Forms.LinkLabel lnk_ayuda;
        private System.Windows.Forms.Label lbl_ayudauser;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btn_salir;
    }
}