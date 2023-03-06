using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vetApp.db
{
    [Table(Name = "centro_atencion")]
    public partial class CentroAtencion
    {
        #region variables locales
        private int _codigo;
        private string _denominacion;
        private string _domicilio;
        private string _telefono;
        private int _codigoPostal;
        private Localidad _localidad = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 60)]
        public string Nombre
        {
            get { return _denominacion; }
            set { _denominacion = value; }
        }

        [Propiedad(Name = "domicilio", Tipo = typeof(string), Longitud = 120)]
        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        [Propiedad(Name = "telefono", Tipo = typeof(string), Longitud = 20)]
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        [Propiedad(Name = "cod_postal", Tipo = typeof(int))]
        public int CodPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }
        #endregion  
        // -- TODO --
        #region Relaciones con otras entidades

        // implementar Localidad

        #endregion
    }
}
