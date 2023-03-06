using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace vetApp.db
{
    [Table(Name = "mascota_medicamento")]
    public partial class MascotaMedicamento
    {
        #region variables locales
        private int _codigo;
        private double _cantidad;
        private int _cod_mascota_tratamiento;
        private int _cod_medicamento;
        private Tratamiento _mascota_tratamiento = null;
        private Medicamento _medicamento = null;
        #endregion

        #region propiedades publicas
        
        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "cantidad", Tipo = typeof(double))]
        public double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        
        [Propiedad(Name = "cod_mascota_tratamiento", Tipo = typeof(int))]
        public int CodMascotaTratamiento
        {
            get { return _cod_mascota_tratamiento; }
            set { _cod_mascota_tratamiento = value; }
        }

        [Propiedad(Name = "cod_medicamento", Tipo = typeof(int))]
        public int CodMedicamento
        {
            get { return _cod_medicamento; }
            set { _cod_medicamento= value; }
        }
        #endregion

        // -- TODO --
        #region Relaciones con otras entidades
        // implementar MascotaTratamiento
        // implementar Medicamento
        #endregion
    }

}
