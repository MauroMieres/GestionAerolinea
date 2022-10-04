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
        List<Vendedor> listaVendedores = Aerolinea.ListaVendedores;
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_loguear_Click(object sender, EventArgs e)
        {
            if(txt_user.Text is not null && txt_password is not null)
            {
                foreach (Vendedor vendedor in listaVendedores)
                {
                    if(vendedor.Usuario == txt_user.Text && vendedor.Contraseña == txt_password.Text)
                    {
                        MessageBox.Show("Usuario encontrado, por favor aguarde.");
                        this.Hide();
                        Frm_MenuPrincipal frmMenuPpal = new Frm_MenuPrincipal(vendedor);
                        frmMenuPpal.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        private void btn_autocompletar_Click(object sender, EventArgs e)
        {
            txt_user.Text = "mauro";
            txt_password.Text = "1234";
        }
    }
}
