using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odontologia
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnCambioContra_Click(object sender, EventArgs e)
        {
            lblContra2.Visible = true;
            lblContraNueva.Visible = true;
            btnAceotarNueContra.Visible = true;
            txtCinfirmarContra.Visible = true;
            txtContra2.Visible = true;
        }

        private void txtContra2_Click(object sender, EventArgs e)
        {

        }

        private void txtContra2_Leave(object sender, EventArgs e)
        {
            if (txtContra2.Text == "")
            {
               txtContra2.Text = "Nueva contraseña";
               txtContra2.ForeColor = Color.Silver;
            }
            
        }

        private void txtContra2_Enter(object sender, EventArgs e)
        {
            if (txtContra2.Text == "Nueva contraseña")
            {
                txtContra2.Text = "";
                txtContra2.ForeColor = Color.Black;
            }      
        }

        private void txtCinfirmarContra_Leave(object sender, EventArgs e)
        {

            if (txtCinfirmarContra.Text == "")
            {
                txtCinfirmarContra.Text = "Confirmar contraseña";
                txtCinfirmarContra.ForeColor = Color.Silver;
            }
        }

        private void txtCinfirmarContra_Enter(object sender, EventArgs e)
        {

            if (txtCinfirmarContra.Text == "Confirmar contraseña")
            {
                txtCinfirmarContra.Text = "";
                txtCinfirmarContra.ForeColor = Color.Black;
            }
        }
    }
}
