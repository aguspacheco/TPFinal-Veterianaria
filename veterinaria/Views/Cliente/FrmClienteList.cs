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
    public partial class FrmClienteList : FormBase
    {
        private string _criterio = null;
        private List<Cliente> _listado;
        
        public FrmClienteList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<Cliente> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.ClientesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Cliente>(listado);
            var source = new BindingSource(bindingList, null);
            this.ClientesGrd.DataSource =  source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmClienteList_Load(object sender, EventArgs e)
        {
            
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for( int i=0;i<this.ClientesGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.ClientesGrd.Rows[i];
                item.Cells[5].Value = (item.DataBoundItem as Cliente).LocalidadCliente.Nombre;
            }
        }

        private void ClientesGrd_DoubleClick(object sender, EventArgs e)
        {
            if( this.ClientesGrd.SelectedRows.Count>0)
            {

                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmClienteAM frm = new FrmClienteAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarCliente (this, (this.ClientesGrd.SelectedRows[0].DataBoundItem as Cliente));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = ClientesGrd.SelectedRows[0].Index;
                this.ClientesGrd.DataSource = Cliente.FindAllStatic(_criterio, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
                ClientesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Cliente actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClientesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = ClientesGrd.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = ClientesGrd.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    ClientesGrd.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            ClientesGrd.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
