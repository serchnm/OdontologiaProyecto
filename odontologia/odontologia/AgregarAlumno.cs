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
    public partial class AgregarAlumno : Form
    {
        public AgregarAlumno()
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
            if(txtNumAcceso.Text=="")
            {
                txtNumAcceso.Text = "Numero de Control";
                txtNumAcceso.ForeColor = Color.Silver;
            }
        }
        // Realizar bien la insercion
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            //try
            //{
                //string cmd = string.Format("Insert into Alumno values  where IdAlumno ='{0}' and Contrasena='{1}'", noalumno.Text.Trim(), contrasena.Text.Trim());
               string cmd=string.Format ("insert into Alumno (IdAlumno,Nombre,ApPat,ApMat,IdPermiso,IdCarrera) values(" + txtNumAcceso.Text + ",'" + txtNombre.Text + "','" + txtApPat.Text + "','" + txtApMat.Text + "','"+txtPerrniso
                   +"',3) ");
                DataSet ds = Conec.Ejecutar(cmd);
                //string usuario = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                //string contras = ds.Tables[0].Rows[0]["Contrasena"].ToString().Trim();

            //    if (usuario == noalumno.Text.ToString() && contras == contrasena.Text.Trim())
            //    {
            //        this.Hide();
            //        MenuPrincipal principal = new MenuPrincipal();
            //        principal.Show();
            //    }

            //}
            //catch
            //{
            //    MessageBox.Show("Usuario o contraseña incorrecta");
            //    noalumno.Clear();
            //    contrasena.Clear();
            //}
        }
    }
}
