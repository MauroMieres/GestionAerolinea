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
            //foreach (Vuelo vuelo in Aerolinea.ListaVuelos)
            //{
            //    Aerolinea.BuscarClienteVuelo(vuelo);
            //    //Aerolinea.BuscarClienteVuelo(Aerolinea.GenerarClientes(), vuelo);
            //}
            dtg_listaClientes.DataSource = Aerolinea.ListaClientes;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
