﻿namespace odontologia
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.noalumno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.contrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(293, 358);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(69, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Iniciar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // noalumno
            // 
            this.noalumno.Depth = 0;
            this.noalumno.Hint = "";
            this.noalumno.Location = new System.Drawing.Point(236, 273);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.noalumno);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField noalumno;
        private MaterialSkin.Controls.MaterialSingleLineTextField contrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

