using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace vetApp.db
{
    [Table(Name = "diagnostico")]
    public partial class Diagnostico
    {
        #region variables locales
        private int _id;
        private string _nombre;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 60)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion
    }

}
