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
    public partial class Frm_Estadisticas : Form
    {
 
        public Frm_Estadisticas()
        {
            InitializeComponent();
            CalcularDestinoMasSolicitado();
        }


        //Lista de destinos ordenados por facturación de forma descendente.
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_destinosFacturacionDesc_Click(object sender, EventArgs e)
        {
            dtg_Estadisticas.DataSource = null;
            List<Destino> listaOrdenada = Aerolinea.ListaDestinos.OrderByDescending(o => o.Facturacion).ToList();
            dtg_Estadisticas.DataSource = listaOrdenada;
            dtg_Estadisticas.Columns["cantidadDeVecesElegido"].Visible = false;
        }

        private void CalcularDestinoMasSolicitado()
        {
            int contadorAux = 0;
            string nombreDestino = "";

            foreach (Destino destino in Aerolinea.ListaDestinos)
            {

                if (contadorAux == 0 || destino.CantidadDeVecesElegido > contadorAux)
                {
                    Destino auxDestinoMasElegido = destino;
                    nombreDestino = destino.Nombre;
                    contadorAux = destino.CantidadDeVecesElegido;
                }
            }
            lbl_destinoMasPedido.Text = "Destino mas solicitado: " + nombreDestino;
        }

        private void btn_aeronavesHoras_Click(object sender, EventArgs e)
        {
            dtg_Estadisticas.DataSource = null;
            List<Aeronave> listaAeroanves = Aerolinea.ListaAeronaves;
            dtg_Estadisticas.DataSource = listaAeroanves;
            dtg_Estadisticas.Columns["asientosTurista"].Visible = false;
            dtg_Estadisticas.Columns["asientosPremium"].Visible = false;
            dtg_Estadisticas.Columns["cantidadBanios"].Visible = false;
            dtg_Estadisticas.Columns["capacidadBodega"].Visible = false;
            dtg_Estadisticas.Columns["estaDisponible"].Visible = false;
        }

        private void btn_ganancias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_GananciasTotales frmGanancias = new Frm_GananciasTotales();
            frmGanancias.ShowDialog();
            this.Show();
        }

        private void btn_pasajerosFrecuentes_Click(object sender, EventArgs e)
        {
            dtg_Estadisticas.DataSource = null;
            List<Cliente> listaOrdenada = Aerolinea.ListaClientes.OrderByDescending(o => o.CantidadVuelosRealizados).ToList();
            dtg_Estadisticas.DataSource = listaOrdenada;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
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
