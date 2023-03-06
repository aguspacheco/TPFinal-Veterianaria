using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace vetApp.db
{
    [Table(Name = "especie")]
    public partial class Especie
    {
        #region variables locales
        private int _id;
        private string _nombre;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 40)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion
    }

}
