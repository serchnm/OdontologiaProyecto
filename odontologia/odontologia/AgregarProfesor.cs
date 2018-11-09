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
    public partial class AgregarProfesor : Form
    {
        public AgregarProfesor()
        {
            InitializeComponent();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtApPat_Enter(object sender, EventArgs e)
        {
            if (txtApPat.Text == "Apellido Paterno")
            {
                txtApPat.Text = "";
                txtApPat.ForeColor = Color.Black;
            }
        }

        private void txtApMat_Enter(object sender, EventArgs e)
        {
            if (txtApMat.Text == "Apellido Materno")
            {
                txtApMat.Text = "";
                txtApMat.ForeColor = Color.Black;
            }
        }

        private void txtNumAcceso_Enter(object sender, EventArgs e)
        {
            if (txtNumAcceso.Text == "Numero de Control")
            {
                txtNumAcceso.Text = "";
                txtNumAcceso.ForeColor = Color.Black;
            }
        }

        private void txtApPat_Leave(object sender, EventArgs e)
        {
            if (txtApPat.Text == "")
            {
                txtApPat.Text = "Apellido Paterno";
                txtApPat.ForeColor = Color.Silver;
            }
        }

        private void txtApMat_Leave(object sender, EventArgs e)
        {
            if (txtApMat.Text == "")
            {
                txtApMat.Text = "Apellido Materno";
                txtApMat.ForeColor = Color.Silver;
            }
        }

        private void txtNumAcceso_Leave(object sender, EventArgs e)
        {
            if (txtNumAcceso.Text == "")
            {
                txtNumAcceso.Text = "Numero de Control";
                txtNumAcceso.ForeColor = Color.Silver;
            }
        }
    }
}
