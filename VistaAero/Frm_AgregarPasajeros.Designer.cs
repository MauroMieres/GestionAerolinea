namespace VistaAero
{
    partial class Frm_AgregarPasajeros
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
            this.dtg_vuelo = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_agregarPasajero = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_tipoPasajero = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.num_dni = new System.Windows.Forms.NumericUpDown();
            this.num_edad = new System.Windows.Forms.NumericUpDown();
            this.cbo_tipoPasajero = new System.Windows.Forms.ComboBox();
            this.chk_comida = new System.Windows.Forms.CheckBox();
            this.chk_wifi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_vuelo
            // 
            this.dtg_vuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_vuelo.Location = new System.Drawing.Point(12, 12);
            this.dtg_vuelo.Name = "dtg_vuelo";
            this.dtg_vuelo.ReadOnly = true;
            this.dtg_vuelo.RowTemplate.Height = 25;
            this.dtg_vuelo.Size = new System.Drawing.Size(893, 105);
            this.dtg_vuelo.TabIndex = 0;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(12, 303);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_agregarPasajero
            // 
            this.btn_agregarPasajero.Location = new System.Drawing.Point(785, 303);
            this.btn_agregarPasajero.Name = "btn_agregarPasajero";
            this.btn_agregarPasajero.Size = new System.Drawing.Size(123, 23);
            this.btn_agregarPasajero.TabIndex = 2;
            this.btn_agregarPasajero.Text = "Agregar Pasajero";
            this.btn_agregarPasajero.UseVisualStyleBackColor = true;
            this.btn_agregarPasajero.Click += new System.EventHandler(this.btn_agregarPasajero_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(725, 138);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(725, 168);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(749, 197);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 15);
            this.lbl_dni.TabIndex = 5;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(743, 222);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(36, 15);
            this.lbl_edad.TabIndex = 6;
            this.lbl_edad.Text = "Edad:";
            // 
            // lbl_tipoPasajero
            // 
            this.lbl_tipoPasajero.AutoSize = true;
            this.lbl_tipoPasajero.Location = new System.Drawing.Point(699, 251);
            this.lbl_tipoPasajero.Name = "lbl_tipoPasajero";
            this.lbl_tipoPasajero.Size = new System.Drawing.Size(80, 15);
            this.lbl_tipoPasajero.TabIndex = 7;
            this.lbl_tipoPasajero.Text = "Tipo Pasajero:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(785, 134);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(120, 23);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(785, 164);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(120, 23);
            this.txt_apellido.TabIndex = 9;
            // 
            // num_dni
            // 
            this.num_dni.Location = new System.Drawing.Point(785, 193);
            this.num_dni.Name = "num_dni";
            this.num_dni.Size = new System.Drawing.Size(120, 23);
            this.num_dni.TabIndex = 10;
            // 
            // num_edad
            // 
            this.num_edad.Location = new System.Drawing.Point(785, 220);
            this.num_edad.Name = "num_edad";
            this.num_edad.Size = new System.Drawing.Size(120, 23);
            this.num_edad.TabIndex = 11;
            // 
            // cbo_tipoPasajero
            // 
            this.cbo_tipoPasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipoPasajero.FormattingEnabled = true;
            this.cbo_tipoPasajero.Location = new System.Drawing.Point(784, 249);
            this.cbo_tipoPasajero.Name = "cbo_tipoPasajero";
            this.cbo_tipoPasajero.Size = new System.Drawing.Size(121, 23);
            this.cbo_tipoPasajero.TabIndex = 12;
            // 
            // chk_comida
            // 
            this.chk_comida.AutoSize = true;
            this.chk_comida.Location = new System.Drawing.Point(782, 278);
            this.chk_comida.Name = "chk_comida";
            this.chk_comida.Size = new System.Drawing.Size(68, 19);
            this.chk_comida.TabIndex = 13;
            this.chk_comida.Text = "Comida";
            this.chk_comida.UseVisualStyleBackColor = true;
            // 
            // chk_wifi
            // 
            this.chk_wifi.AutoSize = true;
            this.chk_wifi.Location = new System.Drawing.Point(858, 278);
            this.chk_wifi.Name = "chk_wifi";
            this.chk_wifi.Size = new System.Drawing.Size(47, 19);
            this.chk_wifi.TabIndex = 14;
            this.chk_wifi.Text = "Wifi";
            this.chk_wifi.UseVisualStyleBackColor = true;
            // 
            // Frm_AgregarPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 337);
            this.Controls.Add(this.chk_wifi);
            this.Controls.Add(this.chk_comida);
            this.Controls.Add(this.cbo_tipoPasajero);
            this.Controls.Add(this.num_edad);
            this.Controls.Add(this.num_dni);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_tipoPasajero);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_agregarPasajero);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dtg_vuelo);
            this.Name = "Frm_AgregarPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Pasajeros";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_vuelo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_agregarPasajero;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_tipoPasajero;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.NumericUpDown num_dni;
        private System.Windows.Forms.NumericUpDown num_edad;
        private System.Windows.Forms.ComboBox cbo_tipoPasajero;
        private System.Windows.Forms.CheckBox chk_comida;
        private System.Windows.Forms.CheckBox chk_wifi;
    }
}