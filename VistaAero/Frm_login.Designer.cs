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
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(48, 28);
            this.txt_user.Name = "txt_user";
            this.txt_user.PlaceholderText = "Ingrese usuario";
            this.txt_user.Size = new System.Drawing.Size(117, 23);
            this.txt_user.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(48, 57);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "Ingrese contraseña";
            this.txt_password.Size = new System.Drawing.Size(117, 23);
            this.txt_password.TabIndex = 3;
            // 
            // btn_autocompletar
            // 
            this.btn_autocompletar.Location = new System.Drawing.Point(50, 115);
            this.btn_autocompletar.Name = "btn_autocompletar";
            this.btn_autocompletar.Size = new System.Drawing.Size(115, 23);
            this.btn_autocompletar.TabIndex = 4;
            this.btn_autocompletar.Text = "Autocompletar";
            this.btn_autocompletar.UseVisualStyleBackColor = true;
            this.btn_autocompletar.Click += new System.EventHandler(this.btn_autocompletar_Click);
            // 
            // btn_loguear
            // 
            this.btn_loguear.Location = new System.Drawing.Point(48, 86);
            this.btn_loguear.Name = "btn_loguear";
            this.btn_loguear.Size = new System.Drawing.Size(117, 23);
            this.btn_loguear.TabIndex = 5;
            this.btn_loguear.Text = "Loguear";
            this.btn_loguear.UseVisualStyleBackColor = true;
            this.btn_loguear.Click += new System.EventHandler(this.btn_loguear_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 165);
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
    }
}