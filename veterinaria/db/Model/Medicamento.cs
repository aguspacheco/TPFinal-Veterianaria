using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace vetApp.db
{
    [Table(Name = "medicamento")]
    public partial class Medicamento
    {
        #region variables locales
        private int _codigo;
        private string _descripcion;
        private int _cod_especie;
        private double _importe;
        private int _cantidad;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "descripcion", Tipo = typeof(string), Longitud = 100)]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        [Propiedad(Name = "cod_especie", Tipo = typeof(int))]
        public int CodEspecie
        {
            get { return _cod_especie; }
            set { _cod_especie = value; }
        }

        [Propiedad(Name = "importe", Tipo = typeof(double))]
        public double Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        [Propiedad(Name = "cantidad", Tipo = typeof(int))]
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        #endregion

        // -- TODO --
        #region Relaciones con otras entidades
        // implementar Especie
        #endregion
    }

}
