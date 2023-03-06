using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace vetApp.db
{
    [Table(Name = "mascota")]
    public partial class Mascota
    {
        #region variables locales
        private int _codigo;
        private string _nombre;
        private DateTime _fecha_nac;
        private int _dni_cliente;
        private int _cod_especie;
        private bool _vacunado;
        private string _observaciones;        
        private Cliente _clienteObj = null;
        private Especie _especieObj = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 80)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Propiedad(Name = "fecha_nac", Tipo = typeof(DateTime))]
        public DateTime FechaNac
        {
            get { return _fecha_nac; }
            set { _fecha_nac = value; }
        }

        [Propiedad(Name = "dni_cliente", Tipo = typeof(int))]
        public int DniCliente
        {
            get { return _dni_cliente; }
            set { _dni_cliente = value; }
        }
        
        [Propiedad(Name = "cod_especie", Tipo = typeof(int))]
        public int CodEspecie
        {
            get { return _cod_especie; }
            set { _cod_especie = value; }
        }

        [Propiedad(Name = "vacunado", Tipo = typeof(bool))]
        public bool Vacunado
        {
            get { return _vacunado; }
            set { _vacunado = value; }
        }

        [Propiedad(Name = "observaciones", Tipo = typeof(string), Longitud = 250)]
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        #endregion
        // -- TODO --
        #region Relaciones con otras entidades
        // implementar con Especie
        // implementar con Cliente
        #endregion
    }

}
