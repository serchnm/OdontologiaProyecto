using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coneccion;

namespace odontologia
{
    public partial class AgregarProfesor : Form
    {
        Conec co = new Conec();
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtApPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtApMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtNumAcceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(co.InsertarProfesor(Convert.ToInt32(txtNumAcceso.Text), txtNombre.Text, txtApPat.Text, txtApMat.Text, Convert.ToInt32(txtPersmiso.Text), Convert.ToInt32(txtCarrera.Text)));
            txtNombre.Text = "";
            txtNumAcceso.Text = "";
            txtApPat.Text = "";
            txtApMat.Text = "";
        }
    }
}
