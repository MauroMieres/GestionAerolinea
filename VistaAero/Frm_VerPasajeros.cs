﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAero;

namespace VistaAero
{
    public partial class Frm_VerPasajeros : Form
    {
        public Frm_VerPasajeros(Vuelo vuelo)
        {
            InitializeComponent();
            dtg_pasajeros.DataSource = vuelo.ListaPasajeros1;
            dtg_pasajeros.Columns["Pasaje"].Visible = false;
            dtg_pasajeros.Columns["cantidadVuelosRealizados"].Visible = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}