namespace Panel_de_componentes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAcepActuallizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAcepActuallizar);
            this.panel1.Location = new System.Drawing.Point(38, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 263);
            this.panel1.TabIndex = 0;
            // 
            // btnAcepActuallizar
            // 
            this.btnAcepActuallizar.Depth = 0;
            this.btnAcepActuallizar.Location = new System.Drawing.Point(376, 86);
            this.btnAcepActuallizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcepActuallizar.Name = "btnAcepActuallizar";
            this.btnAcepActuallizar.Primary = true;
            this.btnAcepActuallizar.Size = new System.Drawing.Size(121, 43);
            this.btnAcepActuallizar.TabIndex = 1;
            this.btnAcepActuallizar.Text = "Aceptar";
            this.btnAcepActuallizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 635);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAcepActuallizar;
    }
}

