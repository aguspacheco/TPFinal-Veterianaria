using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using vetApp.db;
using Newtonsoft;

namespace vetApp.Views
{
    [Permiso(ClaseBaseForm="Cliente", FuncionPermiso = "AltaCliente,ModificaCliente,ConsultaCliente", RolUsuario = "administrador,operadorCliente,operadorTurno,consulta,operador")]
    public partial class FrmClienteAM : FormBase
    {
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private Cliente _Cliente_modif = null;
        private string ClienteLog = "";
        public FrmClienteAM()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                this.GuardarBtn.Enabled = perm.HasAddPerm || perm.HasUpdPerm;
                if (!this.GuardarBtn.Enabled && perm.HasViewPerm)
                {
                    this.GuardarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }
        private void FrmpClienteAM_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCombos()
        {
            this.LocalidadCbo.DataSource =  Localidad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));

            //this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
        }
        public override FrmOperacion OperacionForm
        {
            get
            {
                return base.OperacionForm;
            }
            set
            {
                base.OperacionForm = value;
                LoadCombos();
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nuevo Cliente...";
                    this.LocalidadCbo.SelectedIndex = -1;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Cliente...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Cliente...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Cliente Cliente = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog="";
            MainView.Instance.Cursor = Cursors.WaitCursor;
                       
            
            if (ApellidoTxt.Text == "")
            {
                MessageBox.Show("Ingrese apellido", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ApellidoTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Cliente = new Cliente();
                operacionLog = "ALTA";
                // cargar la info de la Cliente antes de dar de alta.
            }
            
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Cliente = _Cliente_modif;
                detalleLog = "OBJ-Antes:" + ClienteLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            Cliente.Apellido = ApellidoTxt.Text;
            Cliente.Nombres = NombresTxt.Text;
            Cliente.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Cliente.Domicilio = DomicilioTxt.Text;
            Cliente.CodPostal = Convert.ToInt32(LocalidadCbo.SelectedValue);
            Cliente.Observaciones = ObservacionesTxt.Text;
            Cliente.Telefono = TelefonoTxt.Text;
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Cliente);
            // intentar guardar en la Base de datos.
            try
            {
                Cliente.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                errMsj = "Error: " + ex.Message;
            }
            // si esta configurado, al form invoker enviarle evento de operacion completa
            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(Cliente, new EventArgDom { ObjProcess = Cliente, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Cliente, new EventArgDom { ObjProcess = Cliente, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }
        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarCliente(FormBase Invoker, Cliente Pac_modif)
        {
            ShowInfoClienteInForm(Pac_modif, Invoker);
        }
        public void ShowModificarCliente(Cliente Pac_modif)
        {
            ShowInfoClienteInForm(Pac_modif, null);
        }
        private void ShowInfoClienteInForm(Cliente Cli_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Cliente_modif = Cli_modif;
            ClienteLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Cliente_modif);
            // cargar cada control con informacion del Cliente....
            //this.ApellidoTxt.Text = Pac_modif.Apellido;
            FormBase.ShowDataFromModel(this, Cli_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click+=new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoCliente(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoCliente()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmClienteAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;   
        }

        private void DniTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }

        private void ApellidoTxt_TextChanged(object sender, EventArgs e)
        {
            if(!this.ApellidoTxt.Text.All(c=>  Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
             
            }
        }

        private void MascotasBtn_Click(object sender, EventArgs e)
        {
            //acceder a la lista de las mascotas que posee el cliente.
        }

    }
}
