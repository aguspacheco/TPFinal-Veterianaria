using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class CentroAtencion : BaseClass, IAccessDB<CentroAtencion>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionCentroAtencionGuardar;
        public List<CentroAtencion> FindAll()
        {
            return this.FindAll(null);
        }
        public List<CentroAtencion> FindAll(string criterio)
        {
            return ORMDB<CentroAtencion>.FindAll(criterio);
        }
        public CentroAtencion FindbyKey(params object[] key)
        {
            var ce = ORMDB<CentroAtencion>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = ce.Id;
            this.Nombre = ce.Nombre;
            this.Domicilio = ce.Domicilio;
            this.Telefono = ce.Telefono;
            this.CodPostal = ce.CodPostal;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionCentroAtencionGuardar != null)
                {
                    if (Nombre == "")
                        ValidacionCentroAtencionGuardar("No se puede poner Denominacion vacia");
                }
            }
            return ORMDB<CentroAtencion>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-CentroAtencion
        public static List<CentroAtencion> FindAllStatic(string criterio, Comparison<CentroAtencion> compara)
        {
            var lista = ORMDB<CentroAtencion>.FindAll(criterio);
            if(compara!=null)
                lista.Sort(compara);
            return lista;
        }
    }
}
