using System;
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
            dtg_pasajeros.DataSource = vuelo.ListaPasajeros;
            dtg_pasajeros.Columns["Pasaje"].Visible = false;
            dtg_pasajeros.Columns["cantidadVuelosRealizados"].Visible = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_verInfo_Click(object sender, EventArgs e)
        {

            if(dtg_pasajeros.CurrentRow is not null)
            {
                Pasajero auxPasajero = (Pasajero)dtg_pasajeros.CurrentRow.DataBoundItem;
                MessageBox.Show(auxPasajero.ToString());
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("¿Esta seguro de que desea salir?", "Alerta", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
            else
            {
                return;
            }
        }
    }
}
