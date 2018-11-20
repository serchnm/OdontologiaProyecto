using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class2;

//Material
using MaterialSkin;
using MaterialSkin.Controls;

namespace odontologia
{
    public partial class MenuPrincipal : MaterialForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green700, Primary.Green800,
                Primary.Green800, Accent.LightBlue200,
                TextShade.WHITE
            );

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string cmd = string.Format("select *from Dcumento where NumDocumento ='{0}'", txtBuscar.Text.Trim());
                DataSet ds = Conec.Ejecutar(cmd);
                string Doc = ds.Tables[0].Rows[0]["NumDocumento"].ToString().Trim();
                

                if (Doc == txtBuscar.Text.ToString())
                {
                    pdfreader.Visible = true;
                }

            }
            catch
            {
                MessageBox.Show("Archivo no encontrado ");
               
            }
        }
        private void NuevoForm(object FormNuevo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form NForm = FormNuevo as Form;
            NForm.TopLevel = false;
            NForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(NForm);
            this.panel1.Tag = NForm;
            NForm.Show();

        }
        //Boton Configuracion
        private void button4_Click(object sender, EventArgs e)
        {
            lblMprincipal.Text = "Configuracion";
            btnBuscar.Visible = false;
            txtBuscar.Visible = false;
            NuevoForm(new Configuracion());
        }
        //Boton agregar
        private void button3_Click(object sender, EventArgs e)
        {
            lblMprincipal.Text = "Agregar Archivo";
            btnBuscar.Visible = true;
            txtBuscar.Visible = true;
        }
        //Boton eliminar
        private void button2_Click(object sender, EventArgs e)
        {
            lblMprincipal.Text = "Eliminar Archivo";
            btnBuscar.Visible = true;
            txtBuscar.Visible = true;
        }
        //Imagen de inicio
        private void ImgHome_Click(object sender, EventArgs e)
        {
            
            btnBuscar.Visible = false;
            txtBuscar.Visible = false;
            NuevoForm(new Home());
            lblMprincipal.Text = "UABC";
            
        }
        //Boton agregar profesor
        private void btnAgregarProfe_Click(object sender, EventArgs e)
        {
            lblMprincipal.Text = "Agregar Profesor";
            btnBuscar.Visible = false;
            txtBuscar.Visible = false;
            NuevoForm(new AgregarProfesor());
        }

        private void btnAgregarAlum_Click(object sender, EventArgs e)
        {
            lblMprincipal.Text = "Agregar Alumno";
            btnBuscar.Visible = false;
            txtBuscar.Visible = false;
            NuevoForm(new AgregarAlumno());
        }

        private void pdfreader_Enter(object sender, EventArgs e)
        {

        }
    }
}
