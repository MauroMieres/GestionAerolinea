namespace VistaAero
{
    partial class Frm_Estadisticas
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.dtg_Estadisticas = new System.Windows.Forms.DataGridView();
            this.btn_destinosFacturacionDesc = new System.Windows.Forms.Button();
            this.btn_pasajerosFrecuentes = new System.Windows.Forms.Button();
            this.btn_ganancias = new System.Windows.Forms.Button();
            this.btn_aeronavesHoras = new System.Windows.Forms.Button();
            this.lbl_destinoMasPedido = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Estadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.helpProvider1.SetHelpString(this.btn_volver, "Vuelve al menu principal");
            this.btn_volver.Location = new System.Drawing.Point(150, 247);
            this.btn_volver.Name = "btn_volver";
            this.helpProvider1.SetShowHelp(this.btn_volver, true);
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dtg_Estadisticas
            // 
            this.dtg_Estadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Estadisticas.Location = new System.Drawing.Point(231, 12);
            this.dtg_Estadisticas.Name = "dtg_Estadisticas";
            this.dtg_Estadisticas.RowTemplate.Height = 25;
            this.dtg_Estadisticas.Size = new System.Drawing.Size(557, 426);
            this.dtg_Estadisticas.TabIndex = 1;
            // 
            // btn_destinosFacturacionDesc
            // 
            this.helpProvider1.SetHelpString(this.btn_destinosFacturacionDesc, "Ordena y muestra los destinos por facturacion descendente");
            this.btn_destinosFacturacionDesc.Location = new System.Drawing.Point(9, 12);
            this.btn_destinosFacturacionDesc.Name = "btn_destinosFacturacionDesc";
            this.helpProvider1.SetShowHelp(this.btn_destinosFacturacionDesc, true);
            this.btn_destinosFacturacionDesc.Size = new System.Drawing.Size(216, 41);
            this.btn_destinosFacturacionDesc.TabIndex = 2;
            this.btn_destinosFacturacionDesc.Text = "Destinos ordenados por facturacion descendente";
            this.btn_destinosFacturacionDesc.UseVisualStyleBackColor = true;
            this.btn_destinosFacturacionDesc.Click += new System.EventHandler(this.btn_destinosFacturacionDesc_Click);
            // 
            // btn_pasajerosFrecuentes
            // 
            this.helpProvider1.SetHelpString(this.btn_pasajerosFrecuentes, "Ordena los pasajeros por cantida de vuelos (mayor a menor)");
            this.btn_pasajerosFrecuentes.Location = new System.Drawing.Point(9, 59);
            this.btn_pasajerosFrecuentes.Name = "btn_pasajerosFrecuentes";
            this.helpProvider1.SetShowHelp(this.btn_pasajerosFrecuentes, true);
            this.btn_pasajerosFrecuentes.Size = new System.Drawing.Size(216, 42);
            this.btn_pasajerosFrecuentes.TabIndex = 3;
            this.btn_pasajerosFrecuentes.Text = "Pasajeros frecuentes ordenados por cantidad de vuelos";
            this.btn_pasajerosFrecuentes.UseVisualStyleBackColor = true;
            this.btn_pasajerosFrecuentes.Click += new System.EventHandler(this.btn_pasajerosFrecuentes_Click);
            // 
            // btn_ganancias
            // 
            this.helpProvider1.SetHelpString(this.btn_ganancias, "Muetra las ganancias totales de la aerolinea (Vuelos ya finalizados)");
            this.btn_ganancias.Location = new System.Drawing.Point(9, 107);
            this.btn_ganancias.Name = "btn_ganancias";
            this.helpProvider1.SetShowHelp(this.btn_ganancias, true);
            this.btn_ganancias.Size = new System.Drawing.Size(216, 43);
            this.btn_ganancias.TabIndex = 4;
            this.btn_ganancias.Text = "Ganancias totales ";
            this.btn_ganancias.UseVisualStyleBackColor = true;
            this.btn_ganancias.Click += new System.EventHandler(this.btn_ganancias_Click);
            // 
            // btn_aeronavesHoras
            // 
            this.helpProvider1.SetHelpString(this.btn_aeronavesHoras, "Muestra las horas voladas por ese aeronave");
            this.btn_aeronavesHoras.Location = new System.Drawing.Point(9, 156);
            this.btn_aeronavesHoras.Name = "btn_aeronavesHoras";
            this.helpProvider1.SetShowHelp(this.btn_aeronavesHoras, true);
            this.btn_aeronavesHoras.Size = new System.Drawing.Size(216, 46);
            this.btn_aeronavesHoras.TabIndex = 5;
            this.btn_aeronavesHoras.Text = "Horas de vuelo aeronaves";
            this.btn_aeronavesHoras.UseVisualStyleBackColor = true;
            this.btn_aeronavesHoras.Click += new System.EventHandler(this.btn_aeronavesHoras_Click);
            // 
            // lbl_destinoMasPedido
            // 
            this.lbl_destinoMasPedido.AutoSize = true;
            this.lbl_destinoMasPedido.Location = new System.Drawing.Point(12, 220);
            this.lbl_destinoMasPedido.Name = "lbl_destinoMasPedido";
            this.lbl_destinoMasPedido.Size = new System.Drawing.Size(121, 15);
            this.lbl_destinoMasPedido.TabIndex = 6;
            this.lbl_destinoMasPedido.Text = "DestinoMasSolicitado";
            // 
            // btn_Salir
            // 
            this.helpProvider1.SetHelpString(this.btn_Salir, "Cierra la aplicacion");
            this.btn_Salir.Location = new System.Drawing.Point(9, 415);
            this.btn_Salir.Name = "btn_Salir";
            this.helpProvider1.SetShowHelp(this.btn_Salir, true);
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_destinoMasPedido);
            this.Controls.Add(this.btn_aeronavesHoras);
            this.Controls.Add(this.btn_ganancias);
            this.Controls.Add(this.btn_pasajerosFrecuentes);
            this.Controls.Add(this.btn_destinosFacturacionDesc);
            this.Controls.Add(this.dtg_Estadisticas);
            this.Controls.Add(this.btn_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Estadisticas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Estadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dtg_Estadisticas;
        private System.Windows.Forms.Button btn_destinosFacturacionDesc;
        private System.Windows.Forms.Button btn_pasajerosFrecuentes;
        private System.Windows.Forms.Button btn_ganancias;
        private System.Windows.Forms.Button btn_aeronavesHoras;
        private System.Windows.Forms.Label lbl_destinoMasPedido;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btn_Salir;
    }
}