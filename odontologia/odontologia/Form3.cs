using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odontologia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            if (txtName.Text.Trim().Equals("") || txtFile.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            using (Model.OdontoEntities3 db = new Model.OdontoEntities3())
            {
                Model.document oDocument = new Model.document();
                oDocument.name = txtName.Text.Trim();
                oDocument.doc = file;
                oDocument.realname = openFileDialog1.SafeFileName;

                db.document.Add(oDocument);
                db.SaveChanges();
            }

            Refresh();
            
        }

        private void Refresh()
        {

            using (Model.OdontoEntities3 db = new Model.OdontoEntities3())
            {
                var lst = from d in db.document
                          select new { d.id, d.name };
                dgvLista.DataSource = lst.ToList();
            }
        }

    

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count > 0)
            {
                int id = int.Parse(dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[0].Value.ToString());

                using (Model.OdontoEntities3 db = new Model.OdontoEntities3())
                {
                    var oDocument = db.document.Find(id);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oDocument.realname;

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    if (File.Exists(fullFilePath))
                        Directory.Delete(fullFilePath);

                    File.WriteAllBytes(fullFilePath, oDocument.doc);

                    Process.Start(fullFilePath);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
