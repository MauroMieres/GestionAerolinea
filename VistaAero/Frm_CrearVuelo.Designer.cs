namespace VistaAero
{
    partial class Frm_CrearVuelo
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
            this.dtg_listaAeronaves = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_crearVuelo = new System.Windows.Forms.Button();
            this.cbo_origen = new System.Windows.Forms.ComboBox();
            this.cbo_destino = new System.Windows.Forms.ComboBox();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.cal_fechaSalida = new System.Windows.Forms.MonthCalendar();
            this.txt_aeronaveS = new System.Windows.Forms.TextBox();
            this.lbl_Aeronave = new System.Windows.Forms.Label();
            this.chk_wifi = new System.Windows.Forms.CheckBox();
            this.chk_comida = new System.Windows.Forms.CheckBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btn_SALIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_listaAeronaves
            // 
            this.dtg_listaAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProvider1.SetHelpString(this.dtg_listaAeronaves, "Muestra las aeronaves disponibles");
            this.dtg_listaAeronaves.Location = new System.Drawing.Point(287, 12);
            this.dtg_listaAeronaves.Name = "dtg_listaAeronaves";
            this.dtg_listaAeronaves.ReadOnly = true;
            this.dtg_listaAeronaves.RowTemplate.Height = 25;
            this.helpProvider1.SetShowHelp(this.dtg_listaAeronaves, true);
            this.dtg_listaAeronaves.Size = new System.Drawing.Size(728, 328);
            this.dtg_listaAeronaves.TabIndex = 0;
            this.dtg_listaAeronaves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listaAeronaves_CellClick);
            // 
            // btn_volver
            // 
            this.helpProvider1.SetHelpString(this.btn_volver, "Vuelve al menu principal");
            this.btn_volver.Location = new System.Drawing.Point(27, 291);
            this.btn_volver.Name = "btn_volver";
            this.helpProvider1.SetShowHelp(this.btn_volver, true);
            this.btn_volver.Size = new System.Drawing.Size(121, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_crearVuelo
            // 
            this.helpProvider1.SetHelpString(this.btn_crearVuelo, "Crea el vuelo (si esta todo seleccionado)");
            this.btn_crearVuelo.Location = new System.Drawing.Point(165, 291);
            this.btn_crearVuelo.Name = "btn_crearVuelo";
            this.helpProvider1.SetShowHelp(this.btn_crearVuelo, true);
            this.btn_crearVuelo.Size = new System.Drawing.Size(110, 23);
            this.btn_crearVuelo.TabIndex = 3;
            this.btn_crearVuelo.Text = "Crear vuelo";
            this.btn_crearVuelo.UseVisualStyleBackColor = true;
            this.btn_crearVuelo.Click += new System.EventHandler(this.btn_crearVuelo_Click);
            // 
            // cbo_origen
            // 
            this.cbo_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_origen.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.cbo_origen, "Permite elegir el origen del vuelo");
            this.cbo_origen.Location = new System.Drawing.Point(154, 30);
            this.cbo_origen.Name = "cbo_origen";
            this.helpProvider1.SetShowHelp(this.cbo_origen, true);
            this.cbo_origen.Size = new System.Drawing.Size(121, 23);
            this.cbo_origen.TabIndex = 4;
            this.cbo_origen.SelectedIndexChanged += new System.EventHandler(this.cbo_origen_SelectedIndexChanged);
            // 
            // cbo_destino
            // 
            this.cbo_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_destino.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.cbo_destino, "Permite elegir el destino del vuelo (Si es internacional puede tener como origen " +
        "BS AS)");
            this.cbo_destino.Location = new System.Drawing.Point(27, 30);
            this.cbo_destino.Name = "cbo_destino";
            this.helpProvider1.SetShowHelp(this.cbo_destino, true);
            this.cbo_destino.Size = new System.Drawing.Size(121, 23);
            this.cbo_destino.TabIndex = 5;
            this.cbo_destino.SelectedIndexChanged += new System.EventHandler(this.cbo_destino_SelectedIndexChanged);
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(27, 12);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(47, 15);
            this.lbl_destino.TabIndex = 6;
            this.lbl_destino.Text = "Destino";
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Location = new System.Drawing.Point(154, 12);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(43, 15);
            this.lbl_origen.TabIndex = 7;
            this.lbl_origen.Text = "Origen";
            // 
            // cal_fechaSalida
            // 
            this.helpProvider1.SetHelpString(this.cal_fechaSalida, "Permite elegir la fecha de  salida del vuelo (tiene que ser como minimo dentro de" +
        " 7 dias)");
            this.cal_fechaSalida.Location = new System.Drawing.Point(27, 65);
            this.cal_fechaSalida.Name = "cal_fechaSalida";
            this.helpProvider1.SetShowHelp(this.cal_fechaSalida, true);
            this.cal_fechaSalida.TabIndex = 8;
            // 
            // txt_aeronaveS
            // 
            this.helpProvider1.SetHelpString(this.txt_aeronaveS, "Muestra la matricula del aeronave seleccionada");
            this.txt_aeronaveS.Location = new System.Drawing.Point(165, 262);
            this.txt_aeronaveS.Name = "txt_aeronaveS";
            this.txt_aeronaveS.PlaceholderText = "Seleccione un aeronave";
            this.txt_aeronaveS.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txt_aeronaveS, true);
            this.txt_aeronaveS.Size = new System.Drawing.Size(110, 23);
            this.txt_aeronaveS.TabIndex = 9;
            // 
            // lbl_Aeronave
            // 
            this.lbl_Aeronave.AutoSize = true;
            this.lbl_Aeronave.Location = new System.Drawing.Point(27, 265);
            this.lbl_Aeronave.Name = "lbl_Aeronave";
            this.lbl_Aeronave.Size = new System.Drawing.Size(132, 15);
            this.lbl_Aeronave.TabIndex = 10;
            this.lbl_Aeronave.Text = "Aeronave Seleccionada:";
            // 
            // chk_wifi
            // 
            this.chk_wifi.AutoSize = true;
            this.helpProvider1.SetHelpString(this.chk_wifi, "checked = tiene wifi / unchecked = no tiene");
            this.chk_wifi.Location = new System.Drawing.Point(28, 234);
            this.chk_wifi.Name = "chk_wifi";
            this.helpProvider1.SetShowHelp(this.chk_wifi, true);
            this.chk_wifi.Size = new System.Drawing.Size(47, 19);
            this.chk_wifi.TabIndex = 11;
            this.chk_wifi.Text = "Wifi";
            this.chk_wifi.UseVisualStyleBackColor = true;
            // 
            // chk_comida
            // 
            this.chk_comida.AutoSize = true;
            this.helpProvider1.SetHelpString(this.chk_comida, "Check = tiene comida / unchecked = no tiene");
            this.chk_comida.Location = new System.Drawing.Point(91, 234);
            this.chk_comida.Name = "chk_comida";
            this.helpProvider1.SetShowHelp(this.chk_comida, true);
            this.chk_comida.Size = new System.Drawing.Size(68, 19);
            this.chk_comida.TabIndex = 12;
            this.chk_comida.Text = "Comida";
            this.chk_comida.UseVisualStyleBackColor = true;
            // 
            // btn_SALIR
            // 
            this.helpProvider1.SetHelpString(this.btn_SALIR, "Cierra la aplicacion");
            this.btn_SALIR.Location = new System.Drawing.Point(29, 324);
            this.btn_SALIR.Name = "btn_SALIR";
            this.helpProvider1.SetShowHelp(this.btn_SALIR, true);
            this.btn_SALIR.Size = new System.Drawing.Size(119, 23);
            this.btn_SALIR.TabIndex = 13;
            this.btn_SALIR.Text = "Salir";
            this.btn_SALIR.UseVisualStyleBackColor = true;
            this.btn_SALIR.Click += new System.EventHandler(this.btn_SALIR_Click);
            // 
            // Frm_CrearVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 352);
            this.Controls.Add(this.btn_SALIR);
            this.Controls.Add(this.chk_comida);
            this.Controls.Add(this.chk_wifi);
            this.Controls.Add(this.lbl_Aeronave);
            this.Controls.Add(this.txt_aeronaveS);
            this.Controls.Add(this.cal_fechaSalida);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.cbo_destino);
            this.Controls.Add(this.cbo_origen);
            this.Controls.Add(this.btn_crearVuelo);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dtg_listaAeronaves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CrearVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear vuelo";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_listaAeronaves;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_crearVuelo;
        private System.Windows.Forms.ComboBox cbo_origen;
        private System.Windows.Forms.ComboBox cbo_destino;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.MonthCalendar cal_fechaSalida;
        private System.Windows.Forms.TextBox txt_aeronaveS;
        private System.Windows.Forms.Label lbl_Aeronave;
        private System.Windows.Forms.CheckBox chk_wifi;
        private System.Windows.Forms.CheckBox chk_comida;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btn_SALIR;
    }
}