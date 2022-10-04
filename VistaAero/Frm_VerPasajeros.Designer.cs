namespace VistaAero
{
    partial class Frm_VerPasajeros
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
            this.btn_verInfo = new System.Windows.Forms.Button();
            this.dtg_pasajeros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(12, 415);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(85, 23);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_verInfo
            // 
            this.btn_verInfo.Location = new System.Drawing.Point(12, 12);
            this.btn_verInfo.Name = "btn_verInfo";
            this.btn_verInfo.Size = new System.Drawing.Size(85, 23);
            this.btn_verInfo.TabIndex = 1;
            this.btn_verInfo.Text = "Ver pasajero";
            this.btn_verInfo.UseVisualStyleBackColor = true;
            // 
            // dtg_pasajeros
            // 
            this.dtg_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pasajeros.Location = new System.Drawing.Point(110, 12);
            this.dtg_pasajeros.Name = "dtg_pasajeros";
            this.dtg_pasajeros.RowTemplate.Height = 25;
            this.dtg_pasajeros.Size = new System.Drawing.Size(604, 426);
            this.dtg_pasajeros.TabIndex = 2;
            // 
            // Frm_VerPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.dtg_pasajeros);
            this.Controls.Add(this.btn_verInfo);
            this.Controls.Add(this.btn_volver);
            this.Name = "Frm_VerPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Pasajeros";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_verInfo;
        private System.Windows.Forms.DataGridView dtg_pasajeros;
    }
}