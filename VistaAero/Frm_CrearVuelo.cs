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
    public partial class Frm_CrearVuelo : Form
    {
        List<string> auxListaDestino = new List<string>();
        List<string> auxListaOrigen = new List<string>();
       
        Destino auxDestino;
        Destino auxOrigen;

        public Frm_CrearVuelo()
        {
            InitializeComponent();
            dtg_listaAeronaves.DataSource = Aerolinea.ListaAeronaves;

            foreach (Destino destino in Aerolinea.ListaDestinos)
            {
                auxListaDestino.Add(destino.Nombre);
                auxListaOrigen.Add(destino.Nombre);
            }

            cbo_destino.DataSource = auxListaDestino;
            cbo_origen.DataSource = auxListaOrigen;       
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

       

        private void btn_crearVuelo_Click(object sender, EventArgs e)
        {   
            Aeronave auxAeronave = (Aeronave)dtg_listaAeronaves.CurrentRow.DataBoundItem;
            CrearVuelo(auxAeronave);      
        }

        private void dtg_listaAeronaves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Aeronave auxAeronave = (Aeronave)dtg_listaAeronaves.CurrentRow.DataBoundItem;
            txt_aeronaveS.Text = auxAeronave.Matricula;
        }

        private void cbo_destino_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_destino.Text == "Recife" ||
                cbo_destino.Text == "Acapulco" ||
                cbo_destino.Text == "Miami" ||
                cbo_destino.Text == "Roma")
            {
                cbo_origen.DataSource = null;
                cbo_origen.Items.Clear();
                cbo_origen.Items.Add("Buenos Aires");
            }
            else
            {
                if (cbo_origen.Items.Count == 1)
                {
                    foreach (Destino destinos in Aerolinea.ListaDestinos)
                    {
                        if (destinos.Nombre != "Buenos Aires") 
                        cbo_origen.Items.Add(destinos.Nombre);
                    }
                }
            }
        }

        private void cbo_origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_origen.Text == "Recife" ||
                cbo_origen.Text == "Acapulco" ||
                cbo_origen.Text == "Miami" ||
                cbo_origen.Text == "Roma")
            {
                cbo_destino.DataSource = null;
                cbo_destino.Items.Clear();
                cbo_destino.Items.Add("Buenos Aires");
            }
            else
            {
                if (cbo_destino.Items.Count == 1)
                {
                    foreach (Destino destinos in Aerolinea.ListaDestinos)
                    {
                        if (destinos.Nombre != "Buenos Aires")
                            cbo_destino.Items.Add(destinos.Nombre);
                    }
                }
            }
        }

        private void CrearVuelo(Aeronave auxAeronave)
        {
            if (auxAeronave is null)
            {
                MessageBox.Show("No se eligo una aeronave correctamente, vuelva a intentar.");
            }
            else
            {
                DateTime fechaPartida = cal_fechaSalida.SelectionRange.Start;
                if (DateTime.Compare(fechaPartida, DateTime.Now.AddDays(6)) < 0)
                {
                    MessageBox.Show("La fecha de partida tiene que ser minimo 7 dias a partir de la fecha actual: " + DateTime.Now.AddDays(7).ToShortDateString());
                    return;
                }

                if (!(auxAeronave.EstaDisponible))
                {
                    MessageBox.Show("Elija un aeronave disponible");
                }
                else
                {
                    if (cbo_destino.Text == cbo_origen.Text)
                    {
                        MessageBox.Show("Origen y destino no pueden ser el mismo");
                    }
                    else
                    {
                        foreach (Destino destino in Aerolinea.ListaDestinos)
                        {
                            if (destino.Nombre == cbo_destino.Text)
                            {
                                auxDestino = destino;
                            }
                            if (destino.Nombre == cbo_origen.Text)
                            {
                                auxOrigen = destino;
                            }
                        }
                        if (auxDestino is not null && auxOrigen is not null)
                        {
                            Vuelo auxVuelo = new Vuelo(auxDestino, cal_fechaSalida.SelectionRange.Start.Date, auxOrigen, auxAeronave, chk_wifi.Checked, chk_comida.Checked);
                            if (auxVuelo is not null)
                            {
                                Aerolinea.ListaVuelos.Add(auxVuelo);
                                dtg_listaAeronaves.Update();
                                dtg_listaAeronaves.Refresh();
                                MessageBox.Show($"Vuelo creado con exito");
                            }
                        }
                    }
                }
            }
        }

        private void btn_SALIR_Click(object sender, EventArgs e)
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
