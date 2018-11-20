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
    public partial class Configuracion : Form
    {
        Conec co = new Conec();
        string usuario = "";
        string contras = "";
        string permiso = "";

        public Configuracion(string usuario, string contra)
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            // llenartabla();
            this.usu = usuario;
            this.contra = contra;
            txtContra.Text = contra;
            txtNumAcceso.Text = usu;
        }
        string usu,contra;
      
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
        public void llenartabla()
        {
            Form1 forma1 = new Form1();
            string cmd = string.Format("select *from InicioSecion where Usuario ='{0}' and Contrasena='{1}'", forma1.noalumno.Text.Trim(), forma1.contrasena.Text.Trim());
            DataSet ds = Conec.Ejecutar(cmd);
             usuario = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
             contras = ds.Tables[0].Rows[0]["Contrasena"].ToString().Trim();
             permiso = ds.Tables[0].Rows[0]["IdPermiso"].ToString().Trim();
            //Actualizar(usuario);
        }

        public void Actualizar(string usu, string contra)
        {            
            string cmd = string.Format("Update InicioSecion set Contrasena ='{0}' where Usuario='{1}' ", txtCinfirmarContra.Text.Trim(),usuario.Trim());
            DataSet ds = Conec.Ejecutar(cmd);
            string nuevacontra = ds.Tables[0].Rows[0]["Contrasena"].ToString().Trim();
        }

        private void btnAceotarNueContra_Click(object sender, EventArgs e)
        {
            if(txtContra2.Text==txtCinfirmarContra.Text)
            {
                MessageBox.Show(co.Configuracion(usu,Convert.ToInt32(contra)));
                
               llenartabla();
               txtContra.Text = contras.ToString().Trim();
               this.Refresh();
                
            }
        }

        private void txtContra2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtCinfirmarContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
