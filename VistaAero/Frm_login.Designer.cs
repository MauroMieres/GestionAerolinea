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
            this.btn_salir = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pic_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.helpProvider1.SetHelpString(this.txt_user, "Ingrese por teclado el usuario");
            this.txt_user.Location = new System.Drawing.Point(63, 120);
            this.txt_user.Name = "txt_user";
            this.txt_user.PlaceholderText = "Ingrese usuario";
            this.helpProvider1.SetShowHelp(this.txt_user, true);
            this.txt_user.Size = new System.Drawing.Size(112, 23);
            this.txt_user.TabIndex = 2;
            // 
            // txt_password
            // 
            this.helpProvider1.SetHelpString(this.txt_password, "Ingrese por teclado la contraseña");
            this.txt_password.Location = new System.Drawing.Point(63, 148);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "Ingrese contraseña";
            this.helpProvider1.SetShowHelp(this.txt_password, true);
            this.txt_password.Size = new System.Drawing.Size(112, 23);
            this.txt_password.TabIndex = 3;
            // 
            // btn_autocompletar
            // 
            this.helpProvider1.SetHelpString(this.btn_autocompletar, "Autocompleta los campos los datos de un vendedor ya existente");
            this.btn_autocompletar.Location = new System.Drawing.Point(63, 202);
            this.btn_autocompletar.Name = "btn_autocompletar";
            this.helpProvider1.SetShowHelp(this.btn_autocompletar, true);
            this.btn_autocompletar.Size = new System.Drawing.Size(112, 24);
            this.btn_autocompletar.TabIndex = 4;
            this.btn_autocompletar.Text = "Autocompletar";
            this.btn_autocompletar.UseVisualStyleBackColor = true;
            this.btn_autocompletar.Click += new System.EventHandler(this.btn_autocompletar_Click);
            // 
            // btn_loguear
            // 
            this.helpProvider1.SetHelpString(this.btn_loguear, "Si el usuario y contraseña son correctos hace login");
            this.btn_loguear.Location = new System.Drawing.Point(63, 175);
            this.btn_loguear.Name = "btn_loguear";
            this.helpProvider1.SetShowHelp(this.btn_loguear, true);
            this.btn_loguear.Size = new System.Drawing.Size(112, 24);
            this.btn_loguear.TabIndex = 5;
            this.btn_loguear.Text = "Loguear";
            this.btn_loguear.UseVisualStyleBackColor = true;
            this.btn_loguear.Click += new System.EventHandler(this.btn_loguear_Click);
            // 
            // btn_salir
            // 
            this.helpProvider1.SetHelpString(this.btn_salir, "Permite salir del programa");
            this.btn_salir.Location = new System.Drawing.Point(63, 264);
            this.btn_salir.Name = "btn_salir";
            this.helpProvider1.SetShowHelp(this.btn_salir, true);
            this.btn_salir.Size = new System.Drawing.Size(112, 24);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pic_login
            // 
            this.pic_login.Image = global::VistaAero.Properties.Resources.avion_login;
            this.pic_login.Location = new System.Drawing.Point(-2, -5);
            this.pic_login.Name = "pic_login";
            this.pic_login.Size = new System.Drawing.Size(249, 117);
            this.pic_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_login.TabIndex = 9;
            this.pic_login.TabStop = false;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 296);
            this.Controls.Add(this.pic_login);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_loguear);
            this.Controls.Add(this.btn_autocompletar);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_autocompletar;
        private System.Windows.Forms.Button btn_loguear;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pic_login;
    }
}