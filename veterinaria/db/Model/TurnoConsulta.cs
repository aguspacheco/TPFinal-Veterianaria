using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vetApp.db
{
    [Table(Name = "consulta")]
    public partial class TurnoConsulta
    {
        #region variables locales
        private int _codigo;
        private int _codCentroAtencion;
        private int _nroDocProfesional;
        private int _cod_mascota;        
        private DateTime _fecha;
        private DateTime _hora;
        private int _cod_diagnostico;
        private bool _asistio;
        private string _observaciones;
        private Diagnostico _diagnostico = null;
        private Mascota _mascota = null;
        private Profesional _Profesional = null;
        private CentroAtencion _centroAtencion = null;
        #endregion
        
        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "cod_centro", Tipo = typeof(int))]
        public int CodCentroAtencion
        {
            get { return _codCentroAtencion; }
            set { _codCentroAtencion = value; }
        }

        [Propiedad(Name = "dni_prof", Tipo = typeof(int))]
        public int NroDocProfesional
        {
            get { return _nroDocProfesional; }
            set { _nroDocProfesional = value; }
        }

        [Propiedad(Name = "cod_mascota", Tipo = typeof(int))]
        public int CodMascota
        {
            get { return _cod_mascota; }
            set { _cod_mascota = value; }
        }

        [Propiedad(Name = "fecha", Tipo = typeof(DateTime), Format = "yyyy-MM-dd")]
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        [Propiedad(Name = "hora", Tipo = typeof(DateTime), Format="HH:mm:ss")]
        public DateTime Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        [Propiedad(Name = "cod_diag", Tipo = typeof(int))]
        public int CodDiagnostico
        {
            get { return _cod_diagnostico; }
            set { _cod_diagnostico = value; }
        }
        [Propiedad(Name = "asistio", Tipo = typeof(int))]
        public bool Asistio
        {
            get { return _asistio; }
            set { _asistio = value; }
        }
        [Propiedad(Name = "observaciones", Tipo = typeof(string), Longitud = 150)]
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        #endregion  
        
        #region Relaciones con otras entidades
        // implementar las relaciones.....
        // CentroAtencion
        // Mascota
        // Diagnostico
        // Profesional
        Mascota MascotaTurno
        {
            get {
                if (_mascota == null && this._cod_mascota != 0)
                {
                    _mascota =  ORMDB<Mascota>.FindbyKey(this._cod_mascota);
                }
                return _mascota;
            }
        }

        #endregion
        
    }
}
