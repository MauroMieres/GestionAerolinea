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
using Biblioteca;

namespace VistaAero
{
    public partial class Frm_AgregarPasajeros : Form
    {
        public Frm_AgregarPasajeros(List<Vuelo> listaAuxVuelo)
        {
            InitializeComponent();

            if (listaAuxVuelo is not null)
                dtg_vuelo.DataSource = listaAuxVuelo;

            dtg_vuelo.Columns["Destino"].Visible = false;
            dtg_vuelo.Columns["Origen"].Visible = false;
            dtg_vuelo.Columns["Aeronave"].Visible = false;

            num_dni.Maximum = 50000000;//dni maximo 50 millones
            num_dni.Minimum = 1000000; //dni minimo 1 millon
            num_edad.Maximum = 120; //edad maxima 120 años
            num_edad.Minimum = 1; // edad minima 1 año

            cbo_tipoPasajero.DataSource = Enum.GetValues(typeof(ETipoPasajero));
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_agregarPasajero_Click(object sender, EventArgs e)
        {
            Vuelo auxVuelo = (Vuelo)dtg_vuelo.CurrentRow.DataBoundItem;
            if (auxVuelo is not null)
            {
                if (txt_nombre.Text != null && txt_apellido.Text != null && num_dni.Value.ToString() is not null && num_edad.Value.ToString() is not null && cbo_tipoPasajero.SelectedItem is not null)
                {
                    if (!Funciones.ValidarNombresApellidos(txt_nombre.Text) || !Funciones.ValidarDni(Convert.ToInt32(num_dni.Value)))
                    {
                        MessageBox.Show("Verifique los datos ingresados");
                        return;
                    }

                    Cliente auxCliente = new Cliente(txt_nombre.Text, txt_apellido.Text, Convert.ToInt32(num_dni.Value), Convert.ToInt32(num_edad.Value));
                    Pasaje auxPasajePrecio = new Pasaje(auxVuelo);
                    Pasaje auxPasaje = new Pasaje(auxVuelo, auxPasajePrecio.CalcularPrecioPasaje(auxVuelo, ((ETipoPasajero)cbo_tipoPasajero.SelectedItem)), auxVuelo.CodigoVuelo);

                    DialogResult dr = MessageBox.Show("¿Quiere comprar el pasaje?",
                          $"EL VUELO A {auxVuelo.DestinoS}, en clase {cbo_tipoPasajero.SelectedItem.ToString()}, tiene un costo de: USD{auxPasaje.Precio}", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            if (!Aerolinea.ClienteExistente(auxCliente))
                                Aerolinea.ListaClientes.Add(auxCliente);

                            Pasajero auxPasajero = new Pasajero(auxCliente.Nombre, auxCliente.Apellido, auxCliente.Dni, auxCliente.Edad, auxPasaje);

                            if (auxPasajero is not null)
                            {
                                foreach (Pasajero pasajero in auxVuelo.ListaPasajeros1)
                                {
                                    if (pasajero.Dni == auxPasajero.Dni)
                                    {
                                        MessageBox.Show("Ese pasajero ya esta registrado en este vuelo!");
                                        return;
                                    }
                                }
                                auxVuelo.ListaPasajeros1.Add(auxPasajero);
                                auxVuelo.AsignarAsientoPasajero(auxPasajero);
                                MessageBox.Show("Añadido al vuelo!");
                                dtg_vuelo.Update();
                                dtg_vuelo.Refresh();
                            }
                            break;
                        case DialogResult.No:
                            MessageBox.Show("Se cancelo la compra");
                            return;
                    }
                }
                else
                {
                    MessageBox.Show("Papu pone bien los datos");
                }
            }
        }
    }
}
