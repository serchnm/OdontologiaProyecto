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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // inicioboton
            // 
            this.inicioboton.AutoSize = true;
            this.inicioboton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inicioboton.BackColor = System.Drawing.Color.White;
            this.inicioboton.Depth = 0;
            this.inicioboton.Icon = null;
            this.inicioboton.Location = new System.Drawing.Point(293, 358);
            this.inicioboton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inicioboton.MouseState = MaterialSkin.MouseState.HOVER;
            this.inicioboton.Name = "inicioboton";
            this.inicioboton.Primary = false;
            this.inicioboton.Size = new System.Drawing.Size(69, 36);
            this.inicioboton.TabIndex = 0;
            this.inicioboton.Text = "Iniciar";
            this.inicioboton.UseVisualStyleBackColor = false;
            this.inicioboton.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // noalumno
            // 
            this.noalumno.Depth = 0;
            this.noalumno.ForeColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.noalumno.Text = "Numero de acceso ";
            this.noalumno.UseSystemPasswordChar = false;
            this.noalumno.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            this.noalumno.Enter += new System.EventHandler(this.noalumno_Enter);
            this.noalumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noalumno_KeyPress);
            this.noalumno.Leave += new System.EventHandler(this.noalumno_Leave);
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
            this.contrasena.Enter += new System.EventHandler(this.contrasena_Enter);
            this.contrasena.Leave += new System.EventHandler(this.contrasena_Leave);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(206, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(283, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Universidad Autonoma de Baja California";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(269, 66);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Incio de secion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.inicioboton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button button1;
    }
}

