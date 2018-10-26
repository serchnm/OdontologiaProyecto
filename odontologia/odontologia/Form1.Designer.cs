namespace odontologia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inicioboton = new MaterialSkin.Controls.MaterialFlatButton();
            this.noalumno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.contrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // inicioboton
            // 
            this.inicioboton.AutoSize = true;
            this.inicioboton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inicioboton.BackColor = System.Drawing.Color.Transparent;
            this.inicioboton.Depth = 0;
            this.inicioboton.Icon = null;
            this.inicioboton.Location = new System.Drawing.Point(293, 358);
            this.inicioboton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inicioboton.MouseState = MaterialSkin.MouseState.HOVER;
            this.inicioboton.Name = "inicioboton";
            this.inicioboton.Primary = true;
            this.inicioboton.Size = new System.Drawing.Size(69, 36);
            this.inicioboton.TabIndex = 0;
            this.inicioboton.Text = "Iniciar";
            this.inicioboton.UseVisualStyleBackColor = false;
            this.inicioboton.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // noalumno
            // 
            this.noalumno.Depth = 0;
            this.noalumno.Hint = "";
            this.noalumno.Location = new System.Drawing.Point(236, 275);
            this.noalumno.MaxLength = 32767;
            this.noalumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.noalumno.Name = "noalumno";
            this.noalumno.PasswordChar = '\0';
            this.noalumno.SelectedText = "";
            this.noalumno.SelectionLength = 0;
            this.noalumno.SelectionStart = 0;
            this.noalumno.Size = new System.Drawing.Size(183, 23);
            this.noalumno.TabIndex = 1;
            this.noalumno.TabStop = false;
            this.noalumno.Text = "No.Alumno";
            this.noalumno.UseSystemPasswordChar = false;
            this.noalumno.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // contrasena
            // 
            this.contrasena.Depth = 0;
            this.contrasena.Hint = "";
            this.contrasena.Location = new System.Drawing.Point(236, 316);
            this.contrasena.MaxLength = 32767;
            this.contrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '\0';
            this.contrasena.SelectedText = "";
            this.contrasena.SelectionLength = 0;
            this.contrasena.SelectionStart = 0;
            this.contrasena.Size = new System.Drawing.Size(183, 23);
            this.contrasena.TabIndex = 2;
            this.contrasena.TabStop = false;
            this.contrasena.Text = "Contraseña";
            this.contrasena.UseSystemPasswordChar = true;
            this.contrasena.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 168);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(668, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 16);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.noalumno);
            this.Controls.Add(this.inicioboton);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton inicioboton;
        private MaterialSkin.Controls.MaterialSingleLineTextField noalumno;
        private MaterialSkin.Controls.MaterialSingleLineTextField contrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

