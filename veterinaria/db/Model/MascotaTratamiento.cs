using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace vetApp.db
{
    [Table(Name = "mascota_tratamiento")]
    public partial class MascotaTratamiento
    {
        #region variables locales
        private int _codigo;
        private int _cod_tratamiento;
        private int _cod_consulta;
        private DateTime _fecha_desde;
        private DateTime _fecha_hasta;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "cod_tratamiento", Tipo = typeof(int))]
        public int CodTratamiento
        {
            get { return _cod_tratamiento; }
            set { _cod_tratamiento = value; }
        }

        [Propiedad(Name = "cod_consulta", Tipo = typeof(int))]
        public int CodConsulta
        {
            get { return _cod_consulta; }
            set { _cod_consulta = value; }
        }
        [Propiedad(Name = "fecha_desde", Tipo = typeof(DateTime), Format = "yyyy-MM-dd")]
        public DateTime FechaDesde
        {
            get { return _fecha_desde; }
            set { _fecha_desde = value; }
        }
        [Propiedad(Name = "fecha_hasta", Tipo = typeof(DateTime), Format = "yyyy-MM-dd")]
        public DateTime FechaHasta
        {
            get { return _fecha_hasta; }
            set { _fecha_hasta = value; }
        }

        #endregion
        
        // -- TODO --
        #region Relaciones con otras entidades
        // implementar Tratamiento
        // implementar Consulta
        #endregion
    }

}
