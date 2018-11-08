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
    }
}
