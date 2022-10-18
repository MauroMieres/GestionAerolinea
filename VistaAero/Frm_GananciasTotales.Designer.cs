namespace VistaAero
{
    partial class Frm_GananciasTotales
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtg_recaudacionNacional = new System.Windows.Forms.DataGridView();
            this.dtg_RecaudacionInter = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lbl_gananciasNacionales = new System.Windows.Forms.Label();
            this.lbl_gananciasInternacionales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_recaudacionNacional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RecaudacionInter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.helpProvider1.SetHelpString(this.btn_volver, "Vuelve a la ventana anterior");
            this.btn_volver.Location = new System.Drawing.Point(12, 12);
            this.btn_volver.Name = "btn_volver";
            this.helpProvider1.SetShowHelp(this.btn_volver, true);
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_salir
            // 
            this.helpProvider1.SetHelpString(this.btn_salir, "Cierra el programa");
            this.btn_salir.Location = new System.Drawing.Point(12, 347);
            this.btn_salir.Name = "btn_salir";
            this.helpProvider1.SetShowHelp(this.btn_salir, true);
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dtg_recaudacionNacional
            // 
            this.dtg_recaudacionNacional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProvider1.SetHelpString(this.dtg_recaudacionNacional, "Muestra la ganancia de los vuelos nacionales");
            this.dtg_recaudacionNacional.Location = new System.Drawing.Point(93, 12);
            this.dtg_recaudacionNacional.Name = "dtg_recaudacionNacional";
            this.dtg_recaudacionNacional.ReadOnly = true;
            this.dtg_recaudacionNacional.RowTemplate.Height = 25;
            this.helpProvider1.SetShowHelp(this.dtg_recaudacionNacional, true);
            this.dtg_recaudacionNacional.Size = new System.Drawing.Size(358, 358);
            this.dtg_recaudacionNacional.TabIndex = 2;
            // 
            // dtg_RecaudacionInter
            // 
            this.dtg_RecaudacionInter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProvider1.SetHelpString(this.dtg_RecaudacionInter, "Muestra la ganancia de los vuelos Internacionales");
            this.dtg_RecaudacionInter.Location = new System.Drawing.Point(457, 12);
            this.dtg_RecaudacionInter.Name = "dtg_RecaudacionInter";
            this.dtg_RecaudacionInter.ReadOnly = true;
            this.dtg_RecaudacionInter.RowTemplate.Height = 25;
            this.helpProvider1.SetShowHelp(this.dtg_RecaudacionInter, true);
            this.dtg_RecaudacionInter.Size = new System.Drawing.Size(340, 358);
            this.dtg_RecaudacionInter.TabIndex = 3;
            // 
            // lbl_gananciasNacionales
            // 
            this.lbl_gananciasNacionales.AutoSize = true;
            this.lbl_gananciasNacionales.Location = new System.Drawing.Point(242, 386);
            this.lbl_gananciasNacionales.Name = "lbl_gananciasNacionales";
            this.lbl_gananciasNacionales.Size = new System.Drawing.Size(38, 15);
            this.lbl_gananciasNacionales.TabIndex = 4;
            this.lbl_gananciasNacionales.Text = "label1";
            // 
            // lbl_gananciasInternacionales
            // 
            this.lbl_gananciasInternacionales.AutoSize = true;
            this.lbl_gananciasInternacionales.Location = new System.Drawing.Point(619, 386);
            this.lbl_gananciasInternacionales.Name = "lbl_gananciasInternacionales";
            this.lbl_gananciasInternacionales.Size = new System.Drawing.Size(38, 15);
            this.lbl_gananciasInternacionales.TabIndex = 5;
            this.lbl_gananciasInternacionales.Text = "label1";
            // 
            // Frm_GananciasTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.lbl_gananciasInternacionales);
            this.Controls.Add(this.lbl_gananciasNacionales);
            this.Controls.Add(this.dtg_RecaudacionInter);
            this.Controls.Add(this.dtg_recaudacionNacional);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_GananciasTotales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_GananciasTotales";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_recaudacionNacional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RecaudacionInter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridView dtg_recaudacionNacional;
        private System.Windows.Forms.DataGridView dtg_RecaudacionInter;
        private System.Windows.Forms.Label lbl_gananciasNacionales;
        private System.Windows.Forms.Label lbl_gananciasInternacionales;
    }
}