using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Material
using MaterialSkin;
using MaterialSkin.Controls;

namespace odontologia
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
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
            Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void menu1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelModificar.Visible = true;
            panelModificar.Location= new Point(192, 97);
            panelModificar.Size= new Size(468, 312);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelModificar.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelModificar.Visible = false;
            panelconfig.Visible = true;
            panelconfig.Location = new Point(192, 97);
            panelconfig.Size = new Size(468, 312);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }
    }
}
