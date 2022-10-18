namespace VistaAero
{
    partial class Frm_ListaClientes
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
            this.dtg_listaClientes = new System.Windows.Forms.DataGridView();
            this.btn_verVuelos = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtg_vuelosRealizados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vuelosRealizados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.helpProvider1.SetHelpString(this.btn_volver, "Vuelve al menu principal");
            this.btn_volver.Location = new System.Drawing.Point(12, 41);
            this.btn_volver.Name = "btn_volver";
            this.helpProvider1.SetShowHelp(this.btn_volver, true);
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dtg_listaClientes
            // 
            this.dtg_listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listaClientes.Location = new System.Drawing.Point(93, 12);
            this.dtg_listaClientes.Name = "dtg_listaClientes";
            this.dtg_listaClientes.RowTemplate.Height = 25;
            this.dtg_listaClientes.Size = new System.Drawing.Size(545, 233);
            this.dtg_listaClientes.TabIndex = 1;
            // 
            // btn_verVuelos
            // 
            this.helpProvider1.SetHelpString(this.btn_verVuelos, "Muestra la lista de vuelos realizados por ese cliente");
            this.btn_verVuelos.Location = new System.Drawing.Point(12, 12);
            this.btn_verVuelos.Name = "btn_verVuelos";
            this.helpProvider1.SetShowHelp(this.btn_verVuelos, true);
            this.btn_verVuelos.Size = new System.Drawing.Size(75, 23);
            this.btn_verVuelos.TabIndex = 2;
            this.btn_verVuelos.Text = "Ver vuelos";
            this.btn_verVuelos.UseVisualStyleBackColor = true;
            this.btn_verVuelos.Click += new System.EventHandler(this.btn_verVuelos_Click);
            // 
            // btn_salir
            // 
            this.helpProvider1.SetHelpString(this.btn_salir, "Cierra la aplicacion");
            this.btn_salir.Location = new System.Drawing.Point(12, 421);
            this.btn_salir.Name = "btn_salir";
            this.helpProvider1.SetShowHelp(this.btn_salir, true);
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dtg_vuelosRealizados
            // 
            this.dtg_vuelosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_vuelosRealizados.Location = new System.Drawing.Point(93, 253);
            this.dtg_vuelosRealizados.Name = "dtg_vuelosRealizados";
            this.dtg_vuelosRealizados.RowTemplate.Height = 25;
            this.dtg_vuelosRealizados.Size = new System.Drawing.Size(545, 191);
            this.dtg_vuelosRealizados.TabIndex = 4;
            // 
            // Frm_ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.dtg_vuelosRealizados);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_verVuelos);
            this.Controls.Add(this.dtg_listaClientes);
            this.Controls.Add(this.btn_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vuelosRealizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dtg_listaClientes;
        private System.Windows.Forms.Button btn_verVuelos;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dtg_vuelosRealizados;
    }
}