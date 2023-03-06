namespace vetApp.Views
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Clientes_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarClienteMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Profesionals_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesionalAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarProfesional_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Turnos_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnoAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTurno_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Localidades_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalidadAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarLocalidad_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.CentroAtencion_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.CentroAtencionAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarCentroAtencion_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Vacunas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.VacunaAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarVacuna_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoVacunas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoVacunaAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTipoVacuna_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Listados_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesionalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosDeAtencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Estadisticas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesionalsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.centroAtencionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDe_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusInfoUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clientes_mnu_top,
            this.Profesionals_mnu_top,
            this.Turnos_mnu_top,
            this.Localidades_mnu_top,
            this.CentroAtencion_mnu_top,
            this.Vacunas_mnu_top,
            this.TipoVacunas_mnu_top,
            this.tratamientoToolStripMenuItem,
            this.Listados_mnu_top,
            this.Estadisticas_mnu_top,
            this.AcercaDe_mnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Clientes_mnu_top
            // 
            this.Clientes_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClienteAM_mnu,
            this.BuscarClienteMnu});
            this.Clientes_mnu_top.Name = "Clientes_mnu_top";
            this.Clientes_mnu_top.Size = new System.Drawing.Size(61, 20);
            this.Clientes_mnu_top.Tag = "AltaCliente,ModificaCliente,ConsultaCliente";
            this.Clientes_mnu_top.Text = "Clientes";
            // 
            // ClienteAM_mnu
            // 
            this.ClienteAM_mnu.Name = "ClienteAM_mnu";
            this.ClienteAM_mnu.Size = new System.Drawing.Size(118, 22);
            this.ClienteAM_mnu.Tag = "AltaCliente";
            this.ClienteAM_mnu.Text = "Ingreso";
            this.ClienteAM_mnu.Click += new System.EventHandler(this.IngresoClienteMnu_Click);
            // 
            // BuscarClienteMnu
            // 
            this.BuscarClienteMnu.Name = "BuscarClienteMnu";
            this.BuscarClienteMnu.Size = new System.Drawing.Size(118, 22);
            this.BuscarClienteMnu.Tag = "ModificaCliente,ConsultaCliente";
            this.BuscarClienteMnu.Text = "Buscar...";
            this.BuscarClienteMnu.Click += new System.EventHandler(this.BuscarClienteMnu_Click);
            // 
            // Profesionals_mnu_top
            // 
            this.Profesionals_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfesionalAM_mnu,
            this.BuscarProfesional_mnu});
            this.Profesionals_mnu_top.Name = "Profesionals_mnu_top";
            this.Profesionals_mnu_top.Size = new System.Drawing.Size(89, 20);
            this.Profesionals_mnu_top.Tag = "AltaProfesional,ModificaProfesional,ConsultaProfesional";
            this.Profesionals_mnu_top.Text = "Profesionales";
            // 
            // ProfesionalAM_mnu
            // 
            this.ProfesionalAM_mnu.Name = "ProfesionalAM_mnu";
            this.ProfesionalAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.ProfesionalAM_mnu.Tag = "AltaProfesional";
            this.ProfesionalAM_mnu.Text = "Ingreso";
            this.ProfesionalAM_mnu.Click += new System.EventHandler(this.IngresoProfesional_Click);
            // 
            // BuscarProfesional_mnu
            // 
            this.BuscarProfesional_mnu.Name = "BuscarProfesional_mnu";
            this.BuscarProfesional_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarProfesional_mnu.Tag = "ModificaProfesional,ConsultaProfesional";
            this.BuscarProfesional_mnu.Text = "Buscar";
            this.BuscarProfesional_mnu.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // Turnos_mnu_top
            // 
            this.Turnos_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TurnoAM_mnu,
            this.BuscarTurno_mnu,
            this.registroAsistenciaToolStripMenuItem});
            this.Turnos_mnu_top.Name = "Turnos_mnu_top";
            this.Turnos_mnu_top.Size = new System.Drawing.Size(105, 20);
            this.Turnos_mnu_top.Tag = "AltaTurnoConsulta,ModificaTurnoConsulta,ConsultaTurnoConsulta,RegistraAsistenciaT" +
                "urno";
            this.Turnos_mnu_top.Text = "Turnos Consulta";
            // 
            // TurnoAM_mnu
            // 
            this.TurnoAM_mnu.Name = "TurnoAM_mnu";
            this.TurnoAM_mnu.Size = new System.Drawing.Size(173, 22);
            this.TurnoAM_mnu.Tag = "AltaTurnoConsulta";
            this.TurnoAM_mnu.Text = "Ingreso";
            // 
            // BuscarTurno_mnu
            // 
            this.BuscarTurno_mnu.Name = "BuscarTurno_mnu";
            this.BuscarTurno_mnu.Size = new System.Drawing.Size(173, 22);
            this.BuscarTurno_mnu.Tag = "ModificaTurnoConsulta,ConsultaTurnoConsulta";
            this.BuscarTurno_mnu.Text = "Buscar";
            this.BuscarTurno_mnu.Click += new System.EventHandler(this.BuscarTurno_mnu_Click);
            // 
            // registroAsistenciaToolStripMenuItem
            // 
            this.registroAsistenciaToolStripMenuItem.Name = "registroAsistenciaToolStripMenuItem";
            this.registroAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registroAsistenciaToolStripMenuItem.Tag = "RegistraAsistenciaTurno";
            this.registroAsistenciaToolStripMenuItem.Text = "Registro Asistencia";
            // 
            // Localidades_mnu_top
            // 
            this.Localidades_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalidadAM_mnu,
            this.BuscarLocalidad_mnu});
            this.Localidades_mnu_top.Name = "Localidades_mnu_top";
            this.Localidades_mnu_top.Size = new System.Drawing.Size(81, 20);
            this.Localidades_mnu_top.Tag = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad";
            this.Localidades_mnu_top.Text = "Localidades";
            // 
            // LocalidadAM_mnu
            // 
            this.LocalidadAM_mnu.Name = "LocalidadAM_mnu";
            this.LocalidadAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.LocalidadAM_mnu.Tag = "AltaLocalidad";
            this.LocalidadAM_mnu.Text = "Ingreso";
            this.LocalidadAM_mnu.Click += new System.EventHandler(this.LocalidadAM_mnu_Click);
            // 
            // BuscarLocalidad_mnu
            // 
            this.BuscarLocalidad_mnu.Name = "BuscarLocalidad_mnu";
            this.BuscarLocalidad_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarLocalidad_mnu.Tag = "ModificaLocalidad,ConsultaLocalidad";
            this.BuscarLocalidad_mnu.Text = "Buscar";
            // 
            // CentroAtencion_mnu_top
            // 
            this.CentroAtencion_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CentroAtencionAM_mnu,
            this.BuscarCentroAtencion_mnu});
            this.CentroAtencion_mnu_top.Name = "CentroAtencion_mnu_top";
            this.CentroAtencion_mnu_top.Size = new System.Drawing.Size(106, 20);
            this.CentroAtencion_mnu_top.Tag = "AltaCentroAtencion,ModificaCentroAtencion,ConsultaCentroAtencion";
            this.CentroAtencion_mnu_top.Text = "Centro Atencion";
            // 
            // CentroAtencionAM_mnu
            // 
            this.CentroAtencionAM_mnu.Name = "CentroAtencionAM_mnu";
            this.CentroAtencionAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.CentroAtencionAM_mnu.Tag = "AltaCentroAtencion";
            this.CentroAtencionAM_mnu.Text = "Ingreso";
            this.CentroAtencionAM_mnu.Click += new System.EventHandler(this.IngresoCentroAtencion_mn_Click);
            // 
            // BuscarCentroAtencion_mnu
            // 
            this.BuscarCentroAtencion_mnu.Name = "BuscarCentroAtencion_mnu";
            this.BuscarCentroAtencion_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarCentroAtencion_mnu.Tag = "ModificaCentroAtencion,ConsultaCentroAtencion";
            this.BuscarCentroAtencion_mnu.Text = "Buscar";
            this.BuscarCentroAtencion_mnu.Click += new System.EventHandler(this.BuscarCentroAtencion_mnu_Click);
            // 
            // Vacunas_mnu_top
            // 
            this.Vacunas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VacunaAM_mnu,
            this.BuscarVacuna_mnu});
            this.Vacunas_mnu_top.Name = "Vacunas_mnu_top";
            this.Vacunas_mnu_top.Size = new System.Drawing.Size(64, 20);
            this.Vacunas_mnu_top.Tag = "AltaMascota,ModificaMascota,ConsultaMascota";
            this.Vacunas_mnu_top.Text = "Mascota";
            // 
            // VacunaAM_mnu
            // 
            this.VacunaAM_mnu.Name = "VacunaAM_mnu";
            this.VacunaAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.VacunaAM_mnu.Tag = "AltaMascota";
            this.VacunaAM_mnu.Text = "Ingreso";
            this.VacunaAM_mnu.Click += new System.EventHandler(this.VacunaAM_mnu_Click);
            // 
            // BuscarVacuna_mnu
            // 
            this.BuscarVacuna_mnu.Name = "BuscarVacuna_mnu";
            this.BuscarVacuna_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarVacuna_mnu.Tag = "ModificaMascota,ConsultaMascota";
            this.BuscarVacuna_mnu.Text = "Buscar";
            // 
            // TipoVacunas_mnu_top
            // 
            this.TipoVacunas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoVacunaAM_mnu,
            this.BuscarTipoVacuna_mnu});
            this.TipoVacunas_mnu_top.Name = "TipoVacunas_mnu_top";
            this.TipoVacunas_mnu_top.Size = new System.Drawing.Size(93, 20);
            this.TipoVacunas_mnu_top.Tag = "AltaMedicamento,ModificaMedicamento,ConsultaMedicamento";
            this.TipoVacunas_mnu_top.Text = "Medicamento";
            // 
            // TipoVacunaAM_mnu
            // 
            this.TipoVacunaAM_mnu.Name = "TipoVacunaAM_mnu";
            this.TipoVacunaAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.TipoVacunaAM_mnu.Tag = "AltaMedicamento";
            this.TipoVacunaAM_mnu.Text = "Ingreso";
            // 
            // BuscarTipoVacuna_mnu
            // 
            this.BuscarTipoVacuna_mnu.Name = "BuscarTipoVacuna_mnu";
            this.BuscarTipoVacuna_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarTipoVacuna_mnu.Tag = "ModificaMedicamento,ConsultaMedicamento";
            this.BuscarTipoVacuna_mnu.Text = "Buscar";
            // 
            // tratamientoToolStripMenuItem
            // 
            this.tratamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.tratamientoToolStripMenuItem.Name = "tratamientoToolStripMenuItem";
            this.tratamientoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.tratamientoToolStripMenuItem.Tag = "AltaTratamiento,ModificaTratamiento,ConsultaTratamiento";
            this.tratamientoToolStripMenuItem.Text = "Tratamiento";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ingresoToolStripMenuItem.Tag = "AltaTratamiento";
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.buscarToolStripMenuItem.Tag = "ModificaTratamiento,ConsultaTratamiento";
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // Listados_mnu_top
            // 
            this.Listados_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesToolStripMenuItem,
            this.ProfesionalsToolStripMenuItem,
            this.tuenosToolStripMenuItem,
            this.localidadesToolStripMenuItem1,
            this.vacunasToolStripMenuItem1,
            this.tipoDeVacunasToolStripMenuItem,
            this.auditoriaToolStripMenuItem,
            this.centrosDeAtencionToolStripMenuItem,
            this.tratamientoToolStripMenuItem1});
            this.Listados_mnu_top.Name = "Listados_mnu_top";
            this.Listados_mnu_top.Size = new System.Drawing.Size(62, 20);
            this.Listados_mnu_top.Tag = "Listados";
            this.Listados_mnu_top.Text = "Listados";
            // 
            // ClientesToolStripMenuItem
            // 
            this.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            this.ClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ClientesToolStripMenuItem.Tag = "ConsultaCliente";
            this.ClientesToolStripMenuItem.Text = "Clientes";
            this.ClientesToolStripMenuItem.Click += new System.EventHandler(this.ListadoClienteMnu_Click);
            // 
            // ProfesionalsToolStripMenuItem
            // 
            this.ProfesionalsToolStripMenuItem.Name = "ProfesionalsToolStripMenuItem";
            this.ProfesionalsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ProfesionalsToolStripMenuItem.Tag = "ConsultaProfesional";
            this.ProfesionalsToolStripMenuItem.Text = "Profesional";
            this.ProfesionalsToolStripMenuItem.Click += new System.EventHandler(this.ListadoProfesionals_Click);
            // 
            // tuenosToolStripMenuItem
            // 
            this.tuenosToolStripMenuItem.Name = "tuenosToolStripMenuItem";
            this.tuenosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tuenosToolStripMenuItem.Tag = "ConsultaTurnoConsulta";
            this.tuenosToolStripMenuItem.Text = "Turnos Consulta";
            this.tuenosToolStripMenuItem.Click += new System.EventHandler(this.tuenosToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem1
            // 
            this.localidadesToolStripMenuItem1.Name = "localidadesToolStripMenuItem1";
            this.localidadesToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.localidadesToolStripMenuItem1.Tag = "ConsultaLocalidad";
            this.localidadesToolStripMenuItem1.Text = "Localidades";
            this.localidadesToolStripMenuItem1.Click += new System.EventHandler(this.MainView_Load);
            // 
            // vacunasToolStripMenuItem1
            // 
            this.vacunasToolStripMenuItem1.Name = "vacunasToolStripMenuItem1";
            this.vacunasToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.vacunasToolStripMenuItem1.Tag = "ConsultaMascota";
            this.vacunasToolStripMenuItem1.Text = "Mascota";
            // 
            // tipoDeVacunasToolStripMenuItem
            // 
            this.tipoDeVacunasToolStripMenuItem.Name = "tipoDeVacunasToolStripMenuItem";
            this.tipoDeVacunasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tipoDeVacunasToolStripMenuItem.Tag = "ConsultaMedicamento";
            this.tipoDeVacunasToolStripMenuItem.Text = "Medicamento";
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.auditoriaToolStripMenuItem.Tag = "ConsultaAuditoria";
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            // 
            // centrosDeAtencionToolStripMenuItem
            // 
            this.centrosDeAtencionToolStripMenuItem.Name = "centrosDeAtencionToolStripMenuItem";
            this.centrosDeAtencionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.centrosDeAtencionToolStripMenuItem.Tag = "ConsultaCentroAtencion";
            this.centrosDeAtencionToolStripMenuItem.Text = "Centros de Atencion";
            // 
            // tratamientoToolStripMenuItem1
            // 
            this.tratamientoToolStripMenuItem1.Name = "tratamientoToolStripMenuItem1";
            this.tratamientoToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.tratamientoToolStripMenuItem1.Tag = "ConsultaTratamiento";
            this.tratamientoToolStripMenuItem1.Text = "Tratamiento";
            // 
            // Estadisticas_mnu_top
            // 
            this.Estadisticas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfesionalsToolStripMenuItem1,
            this.centroAtencionToolStripMenuItem1});
            this.Estadisticas_mnu_top.Name = "Estadisticas_mnu_top";
            this.Estadisticas_mnu_top.Size = new System.Drawing.Size(79, 20);
            this.Estadisticas_mnu_top.Tag = "Estadisticas";
            this.Estadisticas_mnu_top.Text = "Estadísticas";
            // 
            // ProfesionalsToolStripMenuItem1
            // 
            this.ProfesionalsToolStripMenuItem1.Name = "ProfesionalsToolStripMenuItem1";
            this.ProfesionalsToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.ProfesionalsToolStripMenuItem1.Tag = "ConsultaMascota";
            this.ProfesionalsToolStripMenuItem1.Text = "Mascotas";
            // 
            // centroAtencionToolStripMenuItem1
            // 
            this.centroAtencionToolStripMenuItem1.Name = "centroAtencionToolStripMenuItem1";
            this.centroAtencionToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.centroAtencionToolStripMenuItem1.Tag = "ConsultaCentroAtencion";
            this.centroAtencionToolStripMenuItem1.Text = "Centro Atencion";
            // 
            // AcercaDe_mnu
            // 
            this.AcercaDe_mnu.Name = "AcercaDe_mnu";
            this.AcercaDe_mnu.Size = new System.Drawing.Size(80, 20);
            this.AcercaDe_mnu.Text = "Acerca de...";
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusInfoUser});
            this.status.Location = new System.Drawing.Point(0, 587);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.status.Size = new System.Drawing.Size(1028, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // StatusInfoUser
            // 
            this.StatusInfoUser.Name = "StatusInfoUser";
            this.StatusInfoUser.Size = new System.Drawing.Size(0, 17);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::vetApp.Properties.Resources.img_vac2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicApp: Registro de información";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem Clientes_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ClienteAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarClienteMnu;
        private System.Windows.Forms.ToolStripMenuItem Profesionals_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ProfesionalAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarProfesional_mnu;
        private System.Windows.Forms.ToolStripMenuItem Turnos_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem Localidades_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem Vacunas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TipoVacunas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TurnoAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem LocalidadAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem VacunaAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem TipoVacunaAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem Listados_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfesionalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarTurno_mnu;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoDeVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Estadisticas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ProfesionalsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel StatusInfoUser;
        private System.Windows.Forms.ToolStripMenuItem centrosDeAtencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarLocalidad_mnu;
        private System.Windows.Forms.ToolStripMenuItem CentroAtencion_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem CentroAtencionAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarCentroAtencion_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarVacuna_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarTipoVacuna_mnu;
        private System.Windows.Forms.ToolStripMenuItem centroAtencionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AcercaDe_mnu;
        private System.Windows.Forms.ToolStripMenuItem registroAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratamientoToolStripMenuItem1;

    }
}