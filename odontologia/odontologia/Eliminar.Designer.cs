namespace odontologia
{
    partial class Configuracion
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
            this.lblNumAcceso = new MaterialSkin.Controls.MaterialLabel();
            this.lblContra = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumAcceso = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnCambioContra = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblContra2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblContraNueva = new MaterialSkin.Controls.MaterialLabel();
            this.txtContra2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCinfirmarContra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAceotarNueContra = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblNumAcceso
            // 
            this.lblNumAcceso.AutoSize = true;
            this.lblNumAcceso.Depth = 0;
            this.lblNumAcceso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumAcceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumAcceso.Location = new System.Drawing.Point(49, 96);
            this.lblNumAcceso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumAcceso.Name = "lblNumAcceso";
            this.lblNumAcceso.Size = new System.Drawing.Size(136, 19);
            this.lblNumAcceso.TabIndex = 2;
            this.lblNumAcceso.Text = "Numero de acceso";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Depth = 0;
            this.lblContra.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContra.Location = new System.Drawing.Point(49, 146);
            this.lblContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(86, 19);
            this.lblContra.TabIndex = 4;
            this.lblContra.Text = "Contraseña";
            // 
            // txtNumAcceso
            // 
            this.txtNumAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAcceso.Location = new System.Drawing.Point(212, 96);
            this.txtNumAcceso.Multiline = true;
            this.txtNumAcceso.Name = "txtNumAcceso";
            this.txtNumAcceso.ReadOnly = true;
            this.txtNumAcceso.Size = new System.Drawing.Size(188, 31);
            this.txtNumAcceso.TabIndex = 9;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(212, 147);
            this.txtContra.Multiline = true;
            this.txtContra.Name = "txtContra";
            this.txtContra.ReadOnly = true;
            this.txtContra.Size = new System.Drawing.Size(188, 31);
            this.txtContra.TabIndex = 10;
            // 
            // btnCambioContra
            // 
            this.btnCambioContra.AutoSize = true;
            this.btnCambioContra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCambioContra.Depth = 0;
            this.btnCambioContra.Icon = null;
            this.btnCambioContra.Location = new System.Drawing.Point(43, 239);
            this.btnCambioContra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCambioContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambioContra.Name = "btnCambioContra";
            this.btnCambioContra.Primary = false;
            this.btnCambioContra.Size = new System.Drawing.Size(174, 36);
            this.btnCambioContra.TabIndex = 12;
            this.btnCambioContra.Text = "Cambiar Contraseña";
            this.btnCambioContra.UseVisualStyleBackColor = true;
            this.btnCambioContra.Click += new System.EventHandler(this.btnCambioContra_Click);
            // 
            // lblContra2
            // 
            this.lblContra2.AutoSize = true;
            this.lblContra2.Depth = 0;
            this.lblContra2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContra2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContra2.Location = new System.Drawing.Point(314, 239);
            this.lblContra2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContra2.Name = "lblContra2";
            this.lblContra2.Size = new System.Drawing.Size(86, 19);
            this.lblContra2.TabIndex = 13;
            this.lblContra2.Text = "Contraseña";
            this.lblContra2.Visible = false;
            // 
            // lblContraNueva
            // 
            this.lblContraNueva.AutoSize = true;
            this.lblContraNueva.Depth = 0;
            this.lblContraNueva.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContraNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContraNueva.Location = new System.Drawing.Point(314, 284);
            this.lblContraNueva.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContraNueva.Name = "lblContraNueva";
            this.lblContraNueva.Size = new System.Drawing.Size(155, 19);
            this.lblContraNueva.TabIndex = 14;
            this.lblContraNueva.Text = "Confirmar contraseña";
            this.lblContraNueva.Visible = false;
            // 
            // txtContra2
            // 
            this.txtContra2.Depth = 0;
            this.txtContra2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtContra2.Hint = "";
            this.txtContra2.Location = new System.Drawing.Point(492, 239);
            this.txtContra2.MaxLength = 32767;
            this.txtContra2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.PasswordChar = '\0';
            this.txtContra2.SelectedText = "";
            this.txtContra2.SelectionLength = 0;
            this.txtContra2.SelectionStart = 0;
            this.txtContra2.Size = new System.Drawing.Size(185, 23);
            this.txtContra2.TabIndex = 15;
            this.txtContra2.TabStop = false;
            this.txtContra2.Text = "Nueva contraseña";
            this.txtContra2.UseSystemPasswordChar = false;
            this.txtContra2.Visible = false;
            this.txtContra2.Click += new System.EventHandler(this.txtContra2_Click);
            this.txtContra2.Enter += new System.EventHandler(this.txtContra2_Enter);
            this.txtContra2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra2_KeyPress);
            this.txtContra2.Leave += new System.EventHandler(this.txtContra2_Leave);
            // 
            // txtCinfirmarContra
            // 
            this.txtCinfirmarContra.Depth = 0;
            this.txtCinfirmarContra.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCinfirmarContra.Hint = "";
            this.txtCinfirmarContra.Location = new System.Drawing.Point(492, 284);
            this.txtCinfirmarContra.MaxLength = 32767;
            this.txtCinfirmarContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCinfirmarContra.Name = "txtCinfirmarContra";
            this.txtCinfirmarContra.PasswordChar = '\0';
            this.txtCinfirmarContra.SelectedText = "";
            this.txtCinfirmarContra.SelectionLength = 0;
            this.txtCinfirmarContra.SelectionStart = 0;
            this.txtCinfirmarContra.Size = new System.Drawing.Size(185, 23);
            this.txtCinfirmarContra.TabIndex = 16;
            this.txtCinfirmarContra.TabStop = false;
            this.txtCinfirmarContra.Text = "Confirmar contraseña";
            this.txtCinfirmarContra.UseSystemPasswordChar = false;
            this.txtCinfirmarContra.Visible = false;
            this.txtCinfirmarContra.Enter += new System.EventHandler(this.txtCinfirmarContra_Enter);
            this.txtCinfirmarContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCinfirmarContra_KeyPress);
            this.txtCinfirmarContra.Leave += new System.EventHandler(this.txtCinfirmarContra_Leave);
            // 
            // btnAceotarNueContra
            // 
            this.btnAceotarNueContra.AutoSize = true;
            this.btnAceotarNueContra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceotarNueContra.Depth = 0;
            this.btnAceotarNueContra.Icon = null;
            this.btnAceotarNueContra.Location = new System.Drawing.Point(318, 333);
            this.btnAceotarNueContra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceotarNueContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceotarNueContra.Name = "btnAceotarNueContra";
            this.btnAceotarNueContra.Primary = false;
            this.btnAceotarNueContra.Size = new System.Drawing.Size(82, 36);
            this.btnAceotarNueContra.TabIndex = 17;
            this.btnAceotarNueContra.Text = "Aceptar";
            this.btnAceotarNueContra.UseVisualStyleBackColor = true;
            this.btnAceotarNueContra.Visible = false;
            this.btnAceotarNueContra.Click += new System.EventHandler(this.btnAceotarNueContra_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceotarNueContra);
            this.Controls.Add(this.txtCinfirmarContra);
            this.Controls.Add(this.txtContra2);
            this.Controls.Add(this.lblContraNueva);
            this.Controls.Add(this.lblContra2);
            this.Controls.Add(this.btnCambioContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtNumAcceso);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNumAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblNumAcceso;
        private MaterialSkin.Controls.MaterialLabel lblContra;
        private System.Windows.Forms.TextBox txtNumAcceso;
        private System.Windows.Forms.TextBox txtContra;
        private MaterialSkin.Controls.MaterialFlatButton btnCambioContra;
        private MaterialSkin.Controls.MaterialLabel lblContra2;
        private MaterialSkin.Controls.MaterialLabel lblContraNueva;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContra2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCinfirmarContra;
        private MaterialSkin.Controls.MaterialFlatButton btnAceotarNueContra;
    }
}