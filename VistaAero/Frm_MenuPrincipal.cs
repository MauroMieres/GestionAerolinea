using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using EntidadesAero;

namespace VistaAero
{
    public partial class Frm_MenuPrincipal : Form
    {
        List<Vuelo> listaVuelos = Aerolinea.ListaVuelos;//es la info del datagrid
        public Frm_MenuPrincipal(Vendedor vendedor)
        {
            InitializeComponent();
            dtg_vuelos.DataSource = Aerolinea.ListaVuelos;
            dtg_vuelos.Columns["Destino"].Visible = false;
            dtg_vuelos.Columns["Origen"].Visible = false;
            dtg_vuelos.Columns["Aeronave"].Visible = false;
            lbl_usuarioConectado.Text = $"Usuario conectado: {vendedor.Nombre} {vendedor.Apellido}, {DateTime.Now.ToShortDateString()}";
        }

        private void btn_pasajeros_Click(object sender, EventArgs e)
        {
            if (dtg_vuelos.CurrentRow is null)
            {
                MessageBox.Show("No hay un vuelo elegido");
            }
            else
            {
                Vuelo auxVuelo = (Vuelo)dtg_vuelos.CurrentRow.DataBoundItem;
                if (auxVuelo is not null)
                {
                    this.Hide();
                    Frm_VerPasajeros frmVerPasajeros = new Frm_VerPasajeros(auxVuelo);
                    frmVerPasajeros.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ListaClientes frmClientes = new Frm_ListaClientes();
            frmClientes.ShowDialog();
            this.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (dtg_vuelos.CurrentRow is null)
            {
                MessageBox.Show("No hay un vuelo elegido");
            }
            else
            {
                Vuelo auxVuelo = (Vuelo)dtg_vuelos.CurrentRow.DataBoundItem;
                if (auxVuelo.EstadoVuelo == "En tierra")
                {
                    List<Vuelo> auxListaVuelos = new List<Vuelo>();
                    auxListaVuelos.Add(auxVuelo);
                    if (auxVuelo is not null && auxListaVuelos is not null)
                    {
                        this.Hide();
                        Frm_AgregarPasajeros frmAgregarPasajeros = new Frm_AgregarPasajeros(auxListaVuelos);
                        frmAgregarPasajeros.ShowDialog();
                        dtg_vuelos.Update();
                        dtg_vuelos.Refresh();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden agregar pasajeros a vuelos aterrizados o volando actualmente");
                }
            }
        }


        private void btn_crearVuelo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_CrearVuelo frmVerAeronaves = new Frm_CrearVuelo();
            frmVerAeronaves.ShowDialog();
            ActualizarDataGrid();
            this.Show();
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

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("¿Esta seguro de que desea cerrar sesion?", "Alerta", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                return;
            }
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Estadisticas frmEstadisticas = new Frm_Estadisticas();
            frmEstadisticas.ShowDialog();
            this.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dtg_vuelos.DataSource = null;
            dtg_vuelos.DataSource = listaVuelos;
            dtg_vuelos.Columns["Destino"].Visible = false;
            dtg_vuelos.Columns["Origen"].Visible = false;
            dtg_vuelos.Columns["Aeronave"].Visible = false;
        }

        private void ActualizarDataGrid()
        {
            dtg_vuelos.DataSource = null;
            dtg_vuelos.DataSource = listaVuelos;
            dtg_vuelos.Columns["Destino"].Visible = false;
            dtg_vuelos.Columns["Origen"].Visible = false;
            dtg_vuelos.Columns["Aeronave"].Visible = false;
        }
    }
}
