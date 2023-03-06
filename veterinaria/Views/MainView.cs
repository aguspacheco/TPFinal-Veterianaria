using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using Npgsql; // Libreria para conectar con PostgreSQL
using vetApp.db; // incluir libreria para poder acceder a los objetos de negocios.
using vetApp.Views; // incluir libreria para poder acceder a los objetos de negocios.

namespace vetApp.Views
{    
    public partial class MainView : FormBase
    {
        private Usuario _usuarioActual = null;
        public Usuario UsuarioActual
        {
            get { return _usuarioActual; }
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowUsuario()
        {
            _usuarioActual = Usuario.UsuarioSys;
            StatusInfoUser.Text = String.Format("Usuario: {0} - {1}", _usuarioActual.UsuarioName, _usuarioActual.FechaLogin); ;
            // mostrar los permisos del usuario en base a los roles, leer cada permiso.
            // Recorrer cada item de Menu, para verificar primero los grupos  y luego cada opcion.
            var list = this.menuStrip1.Items.Cast < ToolStripMenuItem>().ToList().Where(t=> t.Name.IndexOf("mnu_top") != -1);
            List<Funcion> listFuncUser = UsuarioActual.ListadoFunciones;
            bool prmOK=false;
            foreach (var item in list)
	        {
                // verificar el permiso puede incluir listado hacer split.
                prmOK = false;
                string perm = item.Tag.ToString();
                string[] listFunciones = perm.Split(',');
                for (int i = 0; i < listFunciones.Length; i++)
                {
                    prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFunciones[i])!=null;
                }
                item.Enabled = prmOK;
                //por cada ItemPrincipal, verificar los SubItems por debajo si tiene permiso.

                var list_subitm = item.DropDownItems.Cast<ToolStripMenuItem>().ToList();
                                
                foreach (var subitm in list_subitm)
                {
                    prmOK = false;
                    string permsub = subitm.Tag.ToString();
                    string[] listFuncionesSub = permsub.Split(',');
                    for (int i = 0; i < listFuncionesSub.Length; i++)
                    {
                        prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFuncionesSub[i]) != null;
                    }                    
                    subitm.Enabled = prmOK;
                }
            }
            // aplicar permiso a cada submenu.
            
            this.Visible = true;
        }
        private static readonly MainView instance = new MainView();
        static MainView()
        {

        }
        private MainView()
        {
            InitializeComponent();
        }
        // Implementacion de Patron Singleton
        public static MainView Instance
        {
            get
            {
                return instance;
            }
        }

        public void ShowMain(FrmLogin loginFrm, Usuario user)
        {
            loginFrm.Dispose();
            loginFrm = null;
            _usuarioActual = user;
            this.Show();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin;
            if (_usuarioActual == null)
            {
                this.Visible = false;
                frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (_usuarioActual == null)
                {
                    Application.Exit();
                    return;
                }
                this.Visible = true;
            }
        }

        private void IngresoEspecialidadMnu_Click(object sender, EventArgs e)
        {

        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                MessageBox.Show("Operacion realizada correctamente ", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Verificar si hay Form de Listado para poder actualizar la lista de datos..
            }
            else
            {
                MessageBox.Show("Ocurrio un error: " + ev.Mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresoClienteMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmClienteAM frm = new FrmClienteAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoCliente(this);
        }

        private void BuscarClienteMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmClienteBusq frm = new FrmClienteBusq();
            frm.ShowBuscar();
        }

        private void ListadoClienteMnu_Click(object sender, EventArgs e)
        {
            FrmListadoClientes frmListPac = new FrmListadoClientes();
            frmListPac.Show();
        }

        private void ListadoProfesionals_Click(object sender, EventArgs e)
        {
            FrmListadoProfesionales frm = new FrmListadoProfesionales();
            frm.Show();
        }

        private void IngresoProfesional_Click(object sender, EventArgs e)
        {
            FrmProfesionalAM frm = new FrmProfesionalAM();
            frm.ShowIngresoProfesional();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema?", "salida..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
                return;
            }
            e.Cancel = true;
        }

        private void IngresoCentroAtencion_mn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmCentroAtencionAM frmCen = new FrmCentroAtencionAM();
            frmCen.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frmCen.ShowIngresoCentroAtencion();
        }

        private void BuscarCentroAtencion_mnu_Click(object sender, EventArgs e)
        {
            string va = "";
        }

        private void VacunaAM_mnu_Click(object sender, EventArgs e)
        {
            FrmMascotaAM frm = new FrmMascotaAM();
            frm.Show();
        }

        private void LocalidadAM_mnu_Click(object sender, EventArgs e)
        {

        }

        private void BuscarTurno_mnu_Click(object sender, EventArgs e)
        {

        }

        private void tuenosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
