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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_loguear_Click(object sender, EventArgs e)
        {
            Vendedor auxVendedor = Aerolinea.UsuarioExistente(txt_user.Text,txt_password.Text);

            if(auxVendedor is null)
            {
                MessageBox.Show("Usuario no encontrado o null");
            }
            else
            {
                this.Hide();
                Frm_MenuPrincipal frmMenuPpal = new Frm_MenuPrincipal(auxVendedor);
                frmMenuPpal.ShowDialog();
                this.Show();
            }
        }


        private void btn_autocompletar_Click(object sender, EventArgs e)
        {
            txt_user.Text = "mauro";
            txt_password.Text = "1234";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("¿Esta seguro de que desea salir?", "Alerta", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                System.Environment.Exit(1);
            else
                return;
        }

     
    }
}
