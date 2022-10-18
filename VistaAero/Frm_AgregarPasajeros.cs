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
                
                    if (!Funciones.ValidarNombresApellidos(txt_nombre.Text.Trim()) || !Funciones.ValidarDni(Convert.ToInt32(num_dni.Value)) || !Funciones.ValidarNombresApellidos(txt_apellido.Text.Trim()))
                    {
                        MessageBox.Show("Verifique los datos ingresados");
                        return;
                    }

                    Cliente auxCliente = new Cliente(Funciones.FormatearNombreApellido(txt_nombre.Text.Trim()), Funciones.FormatearNombreApellido(txt_apellido.Text.Trim()), Convert.ToInt32(num_dni.Value), Convert.ToInt32(num_edad.Value));
                   if(agregarPasajero(auxVuelo, auxCliente))
                    MessageBox.Show("Pasajero agregado con exito!");       
            }
        }

        private bool agregarPasajero(Vuelo auxVuelo, Cliente auxCliente)
        {
            Pasaje auxPasajePrecio = new Pasaje(auxVuelo);
            Pasaje auxPasaje = new Pasaje(auxVuelo, auxPasajePrecio.CalcularPrecioPasaje(auxVuelo, ((ETipoPasajero)cbo_tipoPasajero.SelectedItem)), auxVuelo.CodigoVuelo);
            if (auxPasajePrecio is not null && auxPasaje is not null)
            {
                if (chk_comida.Checked == true && auxVuelo.TieneComida == false)
                {
                    MessageBox.Show("Este vuelo no posee comida");
                    return false;
                }

                if (chk_wifi.Checked == true && auxVuelo.TieneWifi == false)
                {
                    MessageBox.Show("Este vuelo no posee wifi");
                    return false;
                }

                string impuestosPasaje = auxPasaje.GetPrecioImpuestosExplicado(auxPasaje, ((ETipoPasajero)cbo_tipoPasajero.SelectedItem));

                DialogResult dr = MessageBox.Show($"{auxVuelo.DestinoS}, {impuestosPasaje}", "¿Quiere comprar el pasaje?"
                      , MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (!Aerolinea.ClienteExistente(auxCliente))
                            Aerolinea.ListaClientes.Add(auxCliente);

                        Pasajero auxPasajero = new Pasajero(auxCliente.Nombre, auxCliente.Apellido, auxCliente.Dni, auxCliente.Edad, auxPasaje, (ETipoPasajero)cbo_tipoPasajero.SelectedItem);

                        if (auxPasajero is not null)
                        {
                            foreach (Pasajero pasajero in auxVuelo.ListaPasajeros)
                            {
                                if (pasajero == auxPasajero)//comparacion por sobrecarga de operadores
                                {
                                    MessageBox.Show("Ese pasajero ya esta registrado en este vuelo!");
                                    return false;
                                }
                            }

                            foreach(Vuelo vuelo in Aerolinea.ListaVuelos)
                            {
                                foreach(Pasajero pasajero in vuelo.ListaPasajeros)
                                {
                                    if(vuelo.EstadoVuelo == "Volando")
                                    {
                                        if(auxPasajero == pasajero)
                                        {
                                            if(auxPasajero.Pasaje.Vuelo.HoraSalida > pasajero.Pasaje.Vuelo.HoraLlegada)
                                            {
                                                MessageBox.Show("Ese pasajero se encuentra volando, dicho vuelo aterriza posteriormente a la hora de salida del vuelo que usted quiere reservar");
                                                return false;
                                            }  
                                        }
                                    }
                                }
                            }

                            auxVuelo.ListaPasajeros.Add(auxPasajero);
                            auxVuelo.AsignarAsientoPasajero(auxPasajero);
                            dtg_vuelo.Update();
                            dtg_vuelo.Refresh();
                            return true;
                        }
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Se cancelo la compra");
                        return false;
                }
            }
            return false;
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
