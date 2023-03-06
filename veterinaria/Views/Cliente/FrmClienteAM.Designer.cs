namespace vetApp.Views
{
    partial class FrmClienteAM
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObservacionesTxt = new System.Windows.Forms.TextBox();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniLbl = new System.Windows.Forms.Label();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadLbl = new System.Windows.Forms.Label();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.DomicilioTxt = new System.Windows.Forms.TextBox();
            this.DomicilioLbl = new System.Windows.Forms.Label();
            this.NombresTxt = new System.Windows.Forms.TextBox();
            this.NombresLbl = new System.Windows.Forms.Label();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ErrorValidaCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.MascotasBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ObservacionesTxt);
            this.groupBox1.Controls.Add(this.DniTxt);
            this.groupBox1.Controls.Add(this.DniLbl);
            this.groupBox1.Controls.Add(this.LocalidadCbo);
            this.groupBox1.Controls.Add(this.LocalidadLbl);
            this.groupBox1.Controls.Add(this.TelefonoTxt);
            this.groupBox1.Controls.Add(this.TelefonoLbl);
            this.groupBox1.Controls.Add(this.DomicilioTxt);
            this.groupBox1.Controls.Add(this.DomicilioLbl);
            this.groupBox1.Controls.Add(this.NombresTxt);
            this.groupBox1.Controls.Add(this.NombresLbl);
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(389, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ObservacionesTxt
            // 
            this.ObservacionesTxt.Location = new System.Drawing.Point(24, 276);
            this.ObservacionesTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ObservacionesTxt.Multiline = true;
            this.ObservacionesTxt.Name = "ObservacionesTxt";
            this.ObservacionesTxt.Size = new System.Drawing.Size(356, 101);
            this.ObservacionesTxt.TabIndex = 10;
            this.ObservacionesTxt.Tag = "Observaciones";
            // 
            // DniTxt
            // 
            this.DniTxt.Location = new System.Drawing.Point(99, 110);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DniTxt.MaxLength = 15;
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(105, 22);
            this.DniTxt.TabIndex = 3;
            this.DniTxt.Tag = "NroDocumento";
            this.DniTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTxt_KeyPress);
            // 
            // DniLbl
            // 
            this.DniLbl.AutoSize = true;
            this.DniLbl.Location = new System.Drawing.Point(21, 111);
            this.DniLbl.Name = "DniLbl";
            this.DniLbl.Size = new System.Drawing.Size(80, 17);
            this.DniLbl.TabIndex = 16;
            this.DniLbl.Text = "&Documento";
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(99, 231);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(208, 24);
            this.LocalidadCbo.TabIndex = 7;
            this.LocalidadCbo.Tag = "CodPostal";
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadLbl
            // 
            this.LocalidadLbl.AutoSize = true;
            this.LocalidadLbl.Location = new System.Drawing.Point(21, 237);
            this.LocalidadLbl.Name = "LocalidadLbl";
            this.LocalidadLbl.Size = new System.Drawing.Size(69, 17);
            this.LocalidadLbl.TabIndex = 12;
            this.LocalidadLbl.Text = "&Localidad";
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Location = new System.Drawing.Point(99, 194);
            this.TelefonoTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Size = new System.Drawing.Size(220, 22);
            this.TelefonoTxt.TabIndex = 6;
            this.TelefonoTxt.Tag = "Telefono";
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(21, 196);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(64, 17);
            this.TelefonoLbl.TabIndex = 10;
            this.TelefonoLbl.Text = "Telef&ono";
            // 
            // DomicilioTxt
            // 
            this.DomicilioTxt.Location = new System.Drawing.Point(99, 152);
            this.DomicilioTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DomicilioTxt.Name = "DomicilioTxt";
            this.DomicilioTxt.Size = new System.Drawing.Size(220, 22);
            this.DomicilioTxt.TabIndex = 5;
            this.DomicilioTxt.Tag = "Domicilio";
            // 
            // DomicilioLbl
            // 
            this.DomicilioLbl.AutoSize = true;
            this.DomicilioLbl.Location = new System.Drawing.Point(21, 154);
            this.DomicilioLbl.Name = "DomicilioLbl";
            this.DomicilioLbl.Size = new System.Drawing.Size(64, 17);
            this.DomicilioLbl.TabIndex = 8;
            this.DomicilioLbl.Text = "Dom&icilio";
            // 
            // NombresTxt
            // 
            this.NombresTxt.Location = new System.Drawing.Point(99, 63);
            this.NombresTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombresTxt.MaxLength = 90;
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Size = new System.Drawing.Size(220, 22);
            this.NombresTxt.TabIndex = 2;
            this.NombresTxt.Tag = "Nombres";
            // 
            // NombresLbl
            // 
            this.NombresLbl.AutoSize = true;
            this.NombresLbl.Location = new System.Drawing.Point(21, 64);
            this.NombresLbl.Name = "NombresLbl";
            this.NombresLbl.Size = new System.Drawing.Size(65, 17);
            this.NombresLbl.TabIndex = 2;
            this.NombresLbl.Text = "No&mbres";
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(99, 21);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApellidoTxt.MaxLength = 50;
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(212, 22);
            this.ApellidoTxt.TabIndex = 1;
            this.ApellidoTxt.Tag = "Apellido";
            this.ApellidoTxt.TextChanged += new System.EventHandler(this.ApellidoTxt_TextChanged);
            // 
            // ApellidoLbl
            // 
            this.ApellidoLbl.AutoSize = true;
            this.ApellidoLbl.Location = new System.Drawing.Point(21, 22);
            this.ApellidoLbl.Name = "ApellidoLbl";
            this.ApellidoLbl.Size = new System.Drawing.Size(58, 17);
            this.ApellidoLbl.TabIndex = 0;
            this.ApellidoLbl.Text = "A&pellido";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(322, 430);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(79, 33);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(207, 430);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(79, 33);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // ErrorValidaCliente
            // 
            this.ErrorValidaCliente.ContainerControl = this;
            // 
            // MascotasBtn
            // 
            this.MascotasBtn.Location = new System.Drawing.Point(20, 430);
            this.MascotasBtn.Name = "MascotasBtn";
            this.MascotasBtn.Size = new System.Drawing.Size(91, 33);
            this.MascotasBtn.TabIndex = 13;
            this.MascotasBtn.Text = "Mascotas";
            this.MascotasBtn.UseVisualStyleBackColor = true;
            this.MascotasBtn.Click += new System.EventHandler(this.MascotasBtn_Click);
            // 
            // FrmClienteAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 487);
            this.Controls.Add(this.MascotasBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmClienteAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmpClienteAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.Label ApellidoLbl;
        private System.Windows.Forms.TextBox NombresTxt;
        private System.Windows.Forms.Label NombresLbl;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.Label LocalidadLbl;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.TextBox DomicilioTxt;
        private System.Windows.Forms.Label DomicilioLbl;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.Label DniLbl;
        private System.Windows.Forms.TextBox ObservacionesTxt;
        private System.Windows.Forms.ErrorProvider ErrorValidaCliente;
        private System.Windows.Forms.Button MascotasBtn;
    }
}