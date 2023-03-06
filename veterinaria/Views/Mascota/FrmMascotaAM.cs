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
    [Permiso(ClaseBaseForm = "Mascota", FuncionPermiso = "AltaMascota,ModificaMascota,ConsultaMascota", RolUsuario = "administrador,operadorCliente,operadorTurno,consulta,operador")]
    public partial class FrmMacotaAM : FormBase
    {

        public FrmMacotaAM()
        {
            InitializeComponent();
        }

        private void FrmMascotaAM_Load(object sender, EventArgs e)
        {
          this.EspecieCbo.DisplayMember = "nombre";
            this.EspecieCbo.ValueMember = "id";
               this.EspecieCbo.DataSource = ORMDB<Especie>.FindAll(null);

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void GuardarMascotaClick(object sender, EventArgs e)
        {
            Mascota mascota = null;

            if (Nombre.Text == "")
            {
                MessageBox.Show("No puede ingresar una mascota sin nombre", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }

            if (dniTxt.Text == "")
            {
                MessageBox.Show("No puede ingresar una mascota sin dni del dueño", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombresTxt.Focus();
                return;
            }

            DialogResult rta = MessageBox.Show("Desea registrar la informacion de la mascota?", "Confirma..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.No)
                return;
            mascota.Nombre = NombreTxt.Text.Trim();
            mascota.Vacunado = VacunadoChk.Checked;
            Mascota.ListMascotas.Add(mascota);
            LimpiarForm();
        }
    }
}

