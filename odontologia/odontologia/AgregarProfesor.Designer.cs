namespace odontologia
{
    partial class AgregarProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtNumAcceso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApMat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApPat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNumAcceso = new MaterialSkin.Controls.MaterialLabel();
            this.lblAm = new MaterialSkin.Controls.MaterialLabel();
            this.lblAp = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.txtPersmiso = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(335, 285);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = false;
            this.btnAceptar.Size = new System.Drawing.Size(82, 36);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNumAcceso
            // 
            this.txtNumAcceso.Depth = 0;
            this.txtNumAcceso.Hint = "";
            this.txtNumAcceso.Location = new System.Drawing.Point(335, 222);
            this.txtNumAcceso.MaxLength = 32767;
            this.txtNumAcceso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumAcceso.Name = "txtNumAcceso";
            this.txtNumAcceso.PasswordChar = '\0';
            this.txtNumAcceso.SelectedText = "";
            this.txtNumAcceso.SelectionLength = 0;
            this.txtNumAcceso.SelectionStart = 0;
            this.txtNumAcceso.Size = new System.Drawing.Size(239, 23);
            this.txtNumAcceso.TabIndex = 19;
            this.txtNumAcceso.TabStop = false;
            this.txtNumAcceso.Text = "Numero de Control";
            this.txtNumAcceso.UseSystemPasswordChar = false;
            this.txtNumAcceso.Enter += new System.EventHandler(this.txtNumAcceso_Enter);
            this.txtNumAcceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAcceso_KeyPress);
            this.txtNumAcceso.Leave += new System.EventHandler(this.txtNumAcceso_Leave);
            // 
            // txtApMat
            // 
            this.txtApMat.Depth = 0;
            this.txtApMat.Hint = "";
            this.txtApMat.Location = new System.Drawing.Point(335, 173);
            this.txtApMat.MaxLength = 32767;
            this.txtApMat.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.PasswordChar = '\0';
            this.txtApMat.SelectedText = "Apellido Materno";
            this.txtApMat.SelectionLength = 16;
            this.txtApMat.SelectionStart = 0;
            this.txtApMat.Size = new System.Drawing.Size(239, 23);
            this.txtApMat.TabIndex = 18;
            this.txtApMat.TabStop = false;
            this.txtApMat.Text = "Apellido Materno";
            this.txtApMat.UseSystemPasswordChar = false;
            this.txtApMat.Enter += new System.EventHandler(this.txtApMat_Enter);
            this.txtApMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApMat_KeyPress);
            this.txtApMat.Leave += new System.EventHandler(this.txtApMat_Leave);
            // 
            // txtApPat
            // 
            this.txtApPat.Depth = 0;
            this.txtApPat.Hint = "";
            this.txtApPat.Location = new System.Drawing.Point(335, 127);
            this.txtApPat.MaxLength = 32767;
            this.txtApPat.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.PasswordChar = '\0';
            this.txtApPat.SelectedText = "Apellido Paterno";
            this.txtApPat.SelectionLength = 16;
            this.txtApPat.SelectionStart = 0;
            this.txtApPat.Size = new System.Drawing.Size(239, 23);
            this.txtApPat.TabIndex = 17;
            this.txtApPat.TabStop = false;
            this.txtApPat.Text = "Apellido Paterno";
            this.txtApPat.UseSystemPasswordChar = false;
            this.txtApPat.Enter += new System.EventHandler(this.txtApPat_Enter);
            this.txtApPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApPat_KeyPress);
            this.txtApPat.Leave += new System.EventHandler(this.txtApPat_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(335, 74);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "Nombre";
            this.txtNombre.SelectionLength = 6;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(239, 23);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.TabStop = false;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblNumAcceso
            // 
            this.lblNumAcceso.AutoSize = true;
            this.lblNumAcceso.Depth = 0;
            this.lblNumAcceso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumAcceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumAcceso.Location = new System.Drawing.Point(135, 216);
            this.lblNumAcceso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumAcceso.Name = "lblNumAcceso";
            this.lblNumAcceso.Size = new System.Drawing.Size(136, 19);
            this.lblNumAcceso.TabIndex = 15;
            this.lblNumAcceso.Text = "Numero de acceso";
            // 
            // lblAm
            // 
            this.lblAm.AutoSize = true;
            this.lblAm.Depth = 0;
            this.lblAm.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAm.Location = new System.Drawing.Point(135, 173);
            this.lblAm.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAm.Name = "lblAm";
            this.lblAm.Size = new System.Drawing.Size(124, 19);
            this.lblAm.TabIndex = 14;
            this.lblAm.Text = "Apellido Materno";
            // 
            // lblAp
            // 
            this.lblAp.AutoSize = true;
            this.lblAp.Depth = 0;
            this.lblAp.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAp.Location = new System.Drawing.Point(135, 127);
            this.lblAp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(120, 19);
            this.lblAp.TabIndex = 13;
            this.lblAp.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(135, 79);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // txtPersmiso
            // 
            this.txtPersmiso.Location = new System.Drawing.Point(573, 323);
            this.txtPersmiso.Name = "txtPersmiso";
            this.txtPersmiso.Size = new System.Drawing.Size(100, 20);
            this.txtPersmiso.TabIndex = 21;
            this.txtPersmiso.Text = "2";
            this.txtPersmiso.Visible = false;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(573, 363);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCarrera.TabIndex = 22;
            this.txtCarrera.Text = "1";
            this.txtCarrera.Visible = false;
            // 
            // AgregarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtPersmiso);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNumAcceso);
            this.Controls.Add(this.txtApMat);
            this.Controls.Add(this.txtApPat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumAcceso);
            this.Controls.Add(this.lblAm);
            this.Controls.Add(this.lblAp);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProfesor";
            this.Text = "AgregarProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnAceptar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumAcceso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApMat;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApPat;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialLabel lblNumAcceso;
        private MaterialSkin.Controls.MaterialLabel lblAm;
        private MaterialSkin.Controls.MaterialLabel lblAp;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private System.Windows.Forms.TextBox txtPersmiso;
        private System.Windows.Forms.TextBox txtCarrera;
    }
}