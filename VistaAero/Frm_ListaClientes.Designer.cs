﻿namespace VistaAero
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(12, 421);
            this.btn_volver.Name = "btn_volver";
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
            this.dtg_listaClientes.Size = new System.Drawing.Size(545, 432);
            this.dtg_listaClientes.TabIndex = 1;
            // 
            // btn_verVuelos
            // 
            this.btn_verVuelos.Location = new System.Drawing.Point(12, 12);
            this.btn_verVuelos.Name = "btn_verVuelos";
            this.btn_verVuelos.Size = new System.Drawing.Size(75, 23);
            this.btn_verVuelos.TabIndex = 2;
            this.btn_verVuelos.Text = "Ver vuelos";
            this.btn_verVuelos.UseVisualStyleBackColor = true;
            // 
            // Frm_ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.btn_verVuelos);
            this.Controls.Add(this.dtg_listaClientes);
            this.Controls.Add(this.btn_volver);
            this.Name = "Frm_ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dtg_listaClientes;
        private System.Windows.Forms.Button btn_verVuelos;
    }
}