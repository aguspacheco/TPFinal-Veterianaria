using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using vetApp.db;

namespace vetApp.Views
{

    [Permiso(ClaseBaseForm = "Profesional", FuncionPermiso = "AltaProfesional,ModificaProfesional,ConsultaProfesional", RolUsuario = "administrador,operadorCliente,operadorTurno,consulta,operador")]
    public partial class FrmProfesionalAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Profesional _Profesional_modif = null;
        private string ProfesionalLog = "";

        public FrmProfesionalAM()
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

        private void LoadCombos()
        {
            this.LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre));
            this.CentroAtencionCbo.DataSource = CentroAtencion.FindAllStatic(null, (ca1, ca2) => ca1.Nombre.CompareTo(ca2.Nombre));
            this.LocalidadCbo.SelectedIndex = -1;
            this.CentroAtencionCbo.SelectedIndex = -1;
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
                    this.Text = "Ingreso de nuevo Profesional...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Profesional...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Profesional...";
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
            Profesional profesional = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                profesional = new Profesional();
                operacionLog = "ALTA";
                // cargar la info de la Cliente antes de dar de alta.
            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                profesional = _Profesional_modif;
                detalleLog = "OBJ-Antes:" + ProfesionalLog + " - OBJ-MOD";
            }

            if (ApellidoTxt.Text == "")
            {
                MessageBox.Show("Ingrese apellido", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ApellidoTxt.Focus();
                return;
            }

            if (NombresTxt.Text == "")
            {
                MessageBox.Show("Ingrese nombre", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombresTxt.Focus();
                return;
            }

            if (MatriculaTxt.Text == "")
            {
                MessageBox.Show("Ingrese matrícula", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MatriculaTxt.Focus();
                return;
            }

            if (DniTxt.Text == "")
            {
                MessageBox.Show("Ingrese DNI", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DniTxt.Focus();
                return;
            }

            if (DomicilioTxt.Text == "")
            {
                MessageBox.Show("Ingrese domicilio", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DomicilioTxt.Focus();
                return;
            }

            if (TelefonoTxt.Text == "")
            {
                MessageBox.Show("Ingrese teléfono", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TelefonoTxt.Focus();
                return;
            }

            Localidad loc = (Localidad)LocalidadCbo.SelectedItem;
            if (loc == null)
            {
                MessageBox.Show("Ingrese localidad", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LocalidadCbo.Focus();
                return;
            }

            CentroAtencion centro = (CentroAtencion)CentroAtencionCbo.SelectedItem;
            if (centro == null)
            {
                MessageBox.Show("Ingrese centro de atención", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CentroAtencionCbo.Focus();
                return;
            }

            profesional = new Profesional();
            profesional.Apellido = ApellidoTxt.Text;
            profesional.Nombres = NombresTxt.Text;
            profesional.Matricula = MatriculaTxt.Text;
            profesional.NroDocumento = Int32.Parse(DniTxt.Text);
            profesional.Domicilio = DomicilioTxt.Text;
            profesional.Telefono = TelefonoTxt.Text;
            profesional.CodPostal = loc.Id;
            

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(profesional);
            // intentar guardar en la Base de datos.
            try
            {
                profesional.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                if (Profesional.ExisteProfesional(profesional.NroDocumento))       // TODO excepción "backend sent unrecognized response type r"
                {
                    errMsj = "ya se encuentra registrado un Profesional con el DNI ingresado";
                }
                else
                {
                    errMsj = "Error: " + ex.Message;
                }
            }
            // si esta configurado, al form invoker enviarle evento de operacion completa
            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(profesional, new EventArgDom { ObjProcess = profesional, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(profesional, new EventArgDom { ObjProcess = profesional, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        public void ShowModificarProfesional(FormBase Invoker, Profesional Profesional_modif)
        {
            ShowInfoProfesionalInForm(Profesional_modif, Invoker);
        }

        public void ShowModificarProfesional(Profesional Profesional_modif)
        {
            ShowInfoProfesionalInForm(Profesional_modif, null);
        }

        private void ShowInfoProfesionalInForm(Profesional Profesional_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Profesional_modif = Profesional_modif;
            ProfesionalLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Profesional_modif);
            // cargar cada control con informacion del Profesional....
            FormBase.ShowDataFromModel(this, Profesional_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();

        }

        public void ShowIngresoProfesional(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoProfesional()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }


        private void FrmProfesionalAM_Load(object sender, EventArgs e)
        {

        }

        private void DniTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TelefonoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
