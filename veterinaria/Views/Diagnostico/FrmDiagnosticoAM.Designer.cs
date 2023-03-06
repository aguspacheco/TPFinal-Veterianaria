namespace vetApp.Views.Diagnostico
{
    partial class FrmDiagnosticoAM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombresTxt = new System.Windows.Forms.TextBox();
            this.NombresLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelarBtn);
            this.groupBox1.Controls.Add(this.GuardarBtn);
            this.groupBox1.Controls.Add(this.NombresTxt);
            this.groupBox1.Controls.Add(this.NombresLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // NombresTxt
            // 
            this.NombresTxt.Location = new System.Drawing.Point(82, 48);
            this.NombresTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombresTxt.MaxLength = 90;
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Size = new System.Drawing.Size(113, 20);
            this.NombresTxt.TabIndex = 4;
            this.NombresTxt.Tag = "Nombres";
            this.NombresTxt.TextChanged += new System.EventHandler(this.NombresTxt_TextChanged);
            // 
            // NombresLbl
            // 
            this.NombresLbl.AutoSize = true;
            this.NombresLbl.Location = new System.Drawing.Point(34, 51);
            this.NombresLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombresLbl.Name = "NombresLbl";
            this.NombresLbl.Size = new System.Drawing.Size(44, 13);
            this.NombresLbl.TabIndex = 3;
            this.NombresLbl.Text = "Nombre";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(149, 103);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 14;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(55, 103);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 13;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            // 
            // FrmDiagnosticoAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 173);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDiagnosticoAM";
            this.Text = "FrmDiagnosticoAM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombresTxt;
        private System.Windows.Forms.Label NombresLbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;

    }
}