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
    public partial class FrmListadoProfesionales : Form
    {
        public FrmListadoProfesionales()
        {
            InitializeComponent();
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void FrmListadoProfesionals_Load(object sender, EventArgs e)
        {
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.ValueMember = "Id";

            this.CentroAtencionCbo.DisplayMember = "Nombre";
            this.CentroAtencionCbo.ValueMember = "Codigo";

            this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
            this.CentroAtencionCbo.DataSource = ORMDB<CentroAtencion>.FindAll(null);

            this.ProfesionalesGrd.AutoGenerateColumns = false;
            this.ProfesionalesGrd.DataSource = ORMDB<Profesional>.FindAll(null);
            
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
                    criterio += " and cod_postal = " + LocalidadCbo.SelectedValue;
                }
                else
                    criterio = "cod_postal= " + LocalidadCbo.SelectedValue;
            }
              if (this.CentroAtencionChk.Checked && this.CentroAtencionCbo.SelectedIndex != -1)
              {
                  if (criterio != null)
                  {
                      criterio += " and cod_centro_a in (select codigo from centro_atencion where  cod_postal = " + LocalidadCbo.SelectedValue + ")";
                  }
                  else
                      criterio = "cod_centro_a in (select codigo from centro_atencion where  cod_postal = " + LocalidadCbo.SelectedValue + ")";
              }
            this.ProfesionalesGrd.AutoGenerateColumns = false;
            this.ProfesionalesGrd.DataSource = ORMDB<Profesional>.FindAll(criterio);
        }

        private void ProfesionalesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.ProfesionalesGrd.Rows)
            {
                rw.Cells[4].Value = (rw.DataBoundItem as Profesional).LocalidadProfesional.Nombre;
                //rw.Cells[5].Value = (rw.DataBoundItem as Profesional).ListadoEspecialidades;
               //rw.Cells[4].Value = (rw.DataBoundItem as Profesional).LocalidadProfesional.Nombre;
            }
        }

        public void ShowListar()
        {
            this.Show();
        }

        private void ProfesionalesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EspecialidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CentroAtencionCbo.Enabled = this.CentroAtencionChk.Checked;
        }

    }
}
