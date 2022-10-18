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
    public partial class Frm_ListaClientes : Form
    {
        public Frm_ListaClientes()
        {
            InitializeComponent();
            dtg_listaClientes.DataSource = Aerolinea.ListaClientes;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

        private void btn_verVuelos_Click(object sender, EventArgs e)
        {
            if (dtg_listaClientes.CurrentRow is null)
            {
                MessageBox.Show("No hay un pasajero elegido");
            }
            else
            {
                Cliente cliente = (Cliente)dtg_listaClientes.CurrentRow.DataBoundItem;
                dtg_vuelosRealizados.DataSource = cliente.VuelosRealizados;
                OcultarColumnas();
            }
        }

        public void OcultarColumnas()
        {
           
            dtg_vuelosRealizados.Columns["AsientosPremiumDisponibles"].Visible = false;
            dtg_vuelosRealizados.Columns["AsientosTuristaDisponibles"].Visible = false;
            dtg_vuelosRealizados.Columns["EstadoVuelo"].Visible = false;
            dtg_vuelosRealizados.Columns["Recaudacion"].Visible = false;

            dtg_vuelosRealizados.Columns["Destino"].Visible = false;
            dtg_vuelosRealizados.Columns["Origen"].Visible = false;
            dtg_vuelosRealizados.Columns["Aeronave"].Visible = false;

        }
    }
}
