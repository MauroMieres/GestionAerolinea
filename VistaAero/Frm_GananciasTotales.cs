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
    public partial class Frm_GananciasTotales : Form
    {
        public Frm_GananciasTotales()
        {
            InitializeComponent();

            List<Destino> recaudacionNacional = new List<Destino>();
            List<Destino> recaudacionInternacional = new List<Destino>();
            decimal facturacionNacional = 0;
            decimal facturacionInternacional = 0;

            foreach (Destino destino in Aerolinea.ListaDestinos)
            {
                if (destino.TipoDestino == ETipoDestino.Nacional)
                {
                    recaudacionNacional.Add(destino);
                    facturacionNacional += destino.Facturacion;
                }
                else
                {
                    recaudacionInternacional.Add(destino);
                    facturacionInternacional += destino.Facturacion;
                }
            }

            List<Destino> listaNacionalOrdenada = recaudacionNacional.OrderByDescending(o => o.Facturacion).ToList();
            List<Destino> listInternacionalOrdenada = recaudacionInternacional.OrderByDescending(o => o.Facturacion).ToList();

            dtg_recaudacionNacional.DataSource = listaNacionalOrdenada;
            dtg_RecaudacionInter.DataSource = listInternacionalOrdenada;

            lbl_gananciasNacionales.Text = $"Ganancias totales {facturacionNacional}";
            lbl_gananciasInternacionales.Text = $"Ganancias totales {facturacionInternacional}";

            OcultarColumnas();

        }

       // public override string Text { get; set; }

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

        public void OcultarColumnas()
        {
            dtg_recaudacionNacional.Columns["TipoDestino"].Visible = false;
            //  dtg_recaudacionNacional.Columns["CantidadDeVecesElegido"].Visible = false;

            dtg_RecaudacionInter.Columns["TipoDestino"].Visible = false;
           // dtg_RecaudacionInter.Columns["CantidadDeVecesElegido"].Visible = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
