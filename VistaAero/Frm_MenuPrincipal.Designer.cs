namespace VistaAero
{
    partial class Frm_MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_crearVuelo = new System.Windows.Forms.Button();
            this.dtg_vuelos = new System.Windows.Forms.DataGridView();
            this.btn_pasajeros = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.tmr_updateVuelos = new System.Windows.Forms.Timer(this.components);
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.lbl_usuarioConectado = new System.Windows.Forms.Label();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clientes
            // 
            this.helpProvider1.SetHelpString(this.btn_clientes, "Permite visualizar la lista de clientes de la aerolinea");
            this.btn_clientes.Location = new System.Drawing.Point(1020, 8);
            this.btn_clientes.Name = "btn_clientes";
            this.helpProvider1.SetShowHelp(this.btn_clientes, true);
            this.btn_clientes.Size = new System.Drawing.Size(131, 23);
            this.btn_clientes.TabIndex = 11;
            this.btn_clientes.Text = "Ver Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_agregar
            // 
            this.helpProvider1.SetHelpString(this.btn_agregar, "Seleccionando un vuelo en tierra se puede agregar pasajeros al mismo");
            this.btn_agregar.Location = new System.Drawing.Point(746, 8);
            this.btn_agregar.Name = "btn_agregar";
            this.helpProvider1.SetShowHelp(this.btn_agregar, true);
            this.btn_agregar.Size = new System.Drawing.Size(131, 23);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar Pasajeros";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_crearVuelo
            // 
            this.helpProvider1.SetHelpString(this.btn_crearVuelo, "Permite crear un vuelo con las aeronaves disponibles");
            this.btn_crearVuelo.Location = new System.Drawing.Point(883, 8);
            this.btn_crearVuelo.Name = "btn_crearVuelo";
            this.helpProvider1.SetShowHelp(this.btn_crearVuelo, true);
            this.btn_crearVuelo.Size = new System.Drawing.Size(131, 23);
            this.btn_crearVuelo.TabIndex = 8;
            this.btn_crearVuelo.Text = "Crear Vuelo";
            this.btn_crearVuelo.UseVisualStyleBackColor = true;
            this.btn_crearVuelo.Click += new System.EventHandler(this.btn_crearVuelo_Click);
            // 
            // dtg_vuelos
            // 
            this.dtg_vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_vuelos.Location = new System.Drawing.Point(12, 41);
            this.dtg_vuelos.Name = "dtg_vuelos";
            this.dtg_vuelos.ReadOnly = true;
            this.dtg_vuelos.RowTemplate.Height = 25;
            this.dtg_vuelos.Size = new System.Drawing.Size(1138, 426);
            this.dtg_vuelos.TabIndex = 7;
            // 
            // btn_pasajeros
            // 
            this.helpProvider1.SetHelpString(this.btn_pasajeros, "Seleccionando un vuelo y tocando este boton se puede visualizar los pasajeros de " +
        "ese vuelo");
            this.btn_pasajeros.Location = new System.Drawing.Point(609, 8);
            this.btn_pasajeros.Name = "btn_pasajeros";
            this.helpProvider1.SetShowHelp(this.btn_pasajeros, true);
            this.btn_pasajeros.Size = new System.Drawing.Size(131, 23);
            this.btn_pasajeros.TabIndex = 6;
            this.btn_pasajeros.Text = "Ver Pasajeros";
            this.btn_pasajeros.UseVisualStyleBackColor = true;
            this.btn_pasajeros.Click += new System.EventHandler(this.btn_pasajeros_Click);
            // 
            // btn_salir
            // 
            this.helpProvider1.SetHelpString(this.btn_salir, "Cierra la aplicacion");
            this.btn_salir.Location = new System.Drawing.Point(12, 473);
            this.btn_salir.Name = "btn_salir";
            this.helpProvider1.SetShowHelp(this.btn_salir, true);
            this.btn_salir.Size = new System.Drawing.Size(128, 23);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_cerrarSesion
            // 
            this.helpProvider1.SetHelpString(this.btn_cerrarSesion, "Cierra la sesion y vuelve al login");
            this.btn_cerrarSesion.Location = new System.Drawing.Point(269, 8);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.helpProvider1.SetShowHelp(this.btn_cerrarSesion, true);
            this.btn_cerrarSesion.Size = new System.Drawing.Size(128, 23);
            this.btn_cerrarSesion.TabIndex = 13;
            this.btn_cerrarSesion.Text = "Cerrar Sesion";
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // lbl_usuarioConectado
            // 
            this.lbl_usuarioConectado.AutoSize = true;
            this.lbl_usuarioConectado.Location = new System.Drawing.Point(12, 12);
            this.lbl_usuarioConectado.Name = "lbl_usuarioConectado";
            this.lbl_usuarioConectado.Size = new System.Drawing.Size(60, 15);
            this.lbl_usuarioConectado.TabIndex = 14;
            this.lbl_usuarioConectado.Text = "DatosUser";
            // 
            // btn_Estadisticas
            // 
            this.helpProvider1.SetHelpString(this.btn_Estadisticas, "Permite ver las estadisticas de la aerolinea");
            this.btn_Estadisticas.Location = new System.Drawing.Point(472, 8);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.helpProvider1.SetShowHelp(this.btn_Estadisticas, true);
            this.btn_Estadisticas.Size = new System.Drawing.Size(131, 23);
            this.btn_Estadisticas.TabIndex = 15;
            this.btn_Estadisticas.Text = "Estadisticas";
            this.btn_Estadisticas.UseVisualStyleBackColor = true;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // btn_actualizar
            // 
            this.helpProvider1.SetHelpString(this.btn_actualizar, "Actualiza la lista de vuelos(necesario cada vez que  crearmos un vuelo)");
            this.btn_actualizar.Location = new System.Drawing.Point(528, 473);
            this.btn_actualizar.Name = "btn_actualizar";
            this.helpProvider1.SetShowHelp(this.btn_actualizar, true);
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 16;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 503);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_Estadisticas);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Controls.Add(this.btn_cerrarSesion);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_crearVuelo);
            this.Controls.Add(this.dtg_vuelos);
            this.Controls.Add(this.btn_pasajeros);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_crearVuelo;
        private System.Windows.Forms.DataGridView dtg_vuelos;
        private System.Windows.Forms.Button btn_pasajeros;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Timer tmr_updateVuelos;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Label lbl_usuarioConectado;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
