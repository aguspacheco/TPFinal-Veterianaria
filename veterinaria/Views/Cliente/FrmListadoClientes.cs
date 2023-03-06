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
    public partial class FrmListadoClientes : FormBase
    {
        public FrmListadoClientes()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {            
            LoadComboBox( Localidad.FindAllStatic(null , (l1,l2)=> l1.Nombre.CompareTo(l2.Nombre)) , this.LocalidadCbo, addSeleccion: true);
                                    
            this.ClientesGrd.AutoGenerateColumns = false;
            this.ClientesGrd.DataSource = Cliente.FindAllStatic (null, (p1,p2)=> (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido+p2.Nombres));
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;
            
            if (this.LocalidadChk.Checked && this.LocalidadCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and cod_postal= " + LocalidadCbo.SelectedValue;
                }
                else
                    criterio = "cod_postal= " + LocalidadCbo.SelectedValue;
            }
            this.ClientesGrd.DataSource = Cliente.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));            
        }

        private void ClientesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.ClientesGrd.Rows)
            {                
                rw.Cells[3].Value = (rw.DataBoundItem as Cliente).LocalidadCliente.Nombre;
            }
        }

        private void ClientesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientesGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmClienteAM frmpac = new FrmClienteAM();
            Cliente pac  =  (this.ClientesGrd.SelectedRows[0].DataBoundItem as Cliente);
            frmpac.ShowModificarCliente(pac);
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementar funcionalidad...!", "falta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
