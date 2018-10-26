using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Coneccion;


//Material
using MaterialSkin;
using MaterialSkin.Controls;

namespace odontologia
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);


            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green700, Primary.Green800,
                Primary.Green800, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            noalumno.Clear();
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            contrasena.Clear();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("select *from InicioSecion where Usuario ='{0}' and Contrasena='{1}'",noalumno.Text.Trim(),contrasena.Text.Trim());
                DataSet ds = Conec.Ejecutar(cmd);
                string usuario = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                string contras = ds.Tables[0].Rows[0]["Contrasena"].ToString().Trim();

                if (usuario == noalumno.Text.ToString() && contras == contrasena.Text.Trim())
                {
                    this.Hide();
                    Form2 principal = new Form2();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch
            {
                MessageBox.Show("Vuelva a intertarlo");
            }

            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
