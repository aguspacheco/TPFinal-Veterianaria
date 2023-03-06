namespace vetApp.Views
{
    partial class FrmProfesionalAM
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
            this.CentroAtencionCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniLbl = new System.Windows.Forms.Label();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadLbl = new System.Windows.Forms.Label();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.DomicilioTxt = new System.Windows.Forms.TextBox();
            this.DomicilioLbl = new System.Windows.Forms.Label();
            this.MatriculaTxt = new System.Windows.Forms.TextBox();
            this.MatriculaLbl = new System.Windows.Forms.Label();
            this.NombresTxt = new System.Windows.Forms.TextBox();
            this.NombresLbl = new System.Windows.Forms.Label();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CentroAtencionCbo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DniTxt);
            this.groupBox1.Controls.Add(this.DniLbl);
            this.groupBox1.Controls.Add(this.LocalidadCbo);
            this.groupBox1.Controls.Add(this.LocalidadLbl);
            this.groupBox1.Controls.Add(this.TelefonoTxt);
            this.groupBox1.Controls.Add(this.TelefonoLbl);
            this.groupBox1.Controls.Add(this.DomicilioTxt);
            this.groupBox1.Controls.Add(this.DomicilioLbl);
            this.groupBox1.Controls.Add(this.MatriculaTxt);
            this.groupBox1.Controls.Add(this.MatriculaLbl);
            this.groupBox1.Controls.Add(this.NombresTxt);
            this.groupBox1.Controls.Add(this.NombresLbl);
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoLbl);
            this.groupBox1.Location = new System.Drawing.Point(24, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // CentroAtencionCbo
            // 
            this.CentroAtencionCbo.DisplayMember = "Nombre";
            this.CentroAtencionCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CentroAtencionCbo.FormattingEnabled = true;
            this.CentroAtencionCbo.Location = new System.Drawing.Point(74, 242);
            this.CentroAtencionCbo.Margin = new System.Windows.Forms.Padding(2);
            this.CentroAtencionCbo.Name = "CentroAtencionCbo";
            this.CentroAtencionCbo.Size = new System.Drawing.Size(157, 21);
            this.CentroAtencionCbo.TabIndex = 8;
            this.CentroAtencionCbo.Tag = "CodCentroAtencion";
            this.CentroAtencionCbo.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Centr&o atención";
            // 
            // DniTxt
            // 
            this.DniTxt.Location = new System.Drawing.Point(74, 111);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(80, 20);
            this.DniTxt.TabIndex = 4;
            this.DniTxt.Tag = "Dni";
            // 
            // DniLbl
            // 
            this.DniLbl.AutoSize = true;
            this.DniLbl.Location = new System.Drawing.Point(16, 112);
            this.DniLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniLbl.Name = "DniLbl";
            this.DniLbl.Size = new System.Drawing.Size(50, 13);
            this.DniLbl.TabIndex = 16;
            this.DniLbl.Text = "&Nro.Doc.";
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(74, 207);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(157, 21);
            this.LocalidadCbo.TabIndex = 7;
            this.LocalidadCbo.Tag = "CodPostal";
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadLbl
            // 
            this.LocalidadLbl.AutoSize = true;
            this.LocalidadLbl.Location = new System.Drawing.Point(16, 213);
            this.LocalidadLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocalidadLbl.Name = "LocalidadLbl";
            this.LocalidadLbl.Size = new System.Drawing.Size(53, 13);
            this.LocalidadLbl.TabIndex = 12;
            this.LocalidadLbl.Text = "&Localidad";
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Location = new System.Drawing.Point(74, 176);
            this.TelefonoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Size = new System.Drawing.Size(166, 20);
            this.TelefonoTxt.TabIndex = 6;
            this.TelefonoTxt.Tag = "Telefono";
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(17, 176);
            this.TelefonoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLbl.TabIndex = 10;
            this.TelefonoLbl.Text = "&Telefono";
            // 
            // DomicilioTxt
            // 
            this.DomicilioTxt.Location = new System.Drawing.Point(74, 141);
            this.DomicilioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DomicilioTxt.Name = "DomicilioTxt";
            this.DomicilioTxt.Size = new System.Drawing.Size(166, 20);
            this.DomicilioTxt.TabIndex = 5;
            // 
            // DomicilioLbl
            // 
            this.DomicilioLbl.AutoSize = true;
            this.DomicilioLbl.Location = new System.Drawing.Point(17, 142);
            this.DomicilioLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DomicilioLbl.Name = "DomicilioLbl";
            this.DomicilioLbl.Size = new System.Drawing.Size(49, 13);
            this.DomicilioLbl.TabIndex = 8;
            this.DomicilioLbl.Text = "Dom&icilio";
            // 
            // MatriculaTxt
            // 
            this.MatriculaTxt.Location = new System.Drawing.Point(74, 83);
            this.MatriculaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.MatriculaTxt.Name = "MatriculaTxt";
            this.MatriculaTxt.Size = new System.Drawing.Size(80, 20);
            this.MatriculaTxt.TabIndex = 3;
            this.MatriculaTxt.Tag = "NroLegajo";
            // 
            // MatriculaLbl
            // 
            this.MatriculaLbl.AutoSize = true;
            this.MatriculaLbl.Location = new System.Drawing.Point(16, 85);
            this.MatriculaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MatriculaLbl.Name = "MatriculaLbl";
            this.MatriculaLbl.Size = new System.Drawing.Size(50, 13);
            this.MatriculaLbl.TabIndex = 4;
            this.MatriculaLbl.Text = "Ma&tricula";
            // 
            // NombresTxt
            // 
            this.NombresTxt.Location = new System.Drawing.Point(74, 51);
            this.NombresTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Size = new System.Drawing.Size(166, 20);
            this.NombresTxt.TabIndex = 2;
            this.NombresTxt.Tag = "Nombres";
            // 
            // NombresLbl
            // 
            this.NombresLbl.AutoSize = true;
            this.NombresLbl.Location = new System.Drawing.Point(16, 52);
            this.NombresLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombresLbl.Name = "NombresLbl";
            this.NombresLbl.Size = new System.Drawing.Size(49, 13);
            this.NombresLbl.TabIndex = 2;
            this.NombresLbl.Text = "No&mbres";
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(74, 17);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(160, 20);
            this.ApellidoTxt.TabIndex = 1;
            this.ApellidoTxt.Tag = "Apellido";
            // 
            // ApellidoLbl
            // 
            this.ApellidoLbl.AutoSize = true;
            this.ApellidoLbl.Location = new System.Drawing.Point(16, 18);
            this.ApellidoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApellidoLbl.Name = "ApellidoLbl";
            this.ApellidoLbl.Size = new System.Drawing.Size(44, 13);
            this.ApellidoLbl.TabIndex = 0;
            this.ApellidoLbl.Text = "&Apellido";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(257, 330);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 10;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(175, 330);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 9;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmProfesionalAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 379);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfesionalAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmProfesionalAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.Label DniLbl;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.Label LocalidadLbl;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.TextBox DomicilioTxt;
        private System.Windows.Forms.Label DomicilioLbl;
        private System.Windows.Forms.TextBox MatriculaTxt;
        private System.Windows.Forms.Label MatriculaLbl;
        private System.Windows.Forms.TextBox NombresTxt;
        private System.Windows.Forms.Label NombresLbl;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.Label ApellidoLbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.ComboBox CentroAtencionCbo;
        private System.Windows.Forms.Label label1;

    }
}