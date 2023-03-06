using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class Diagnostico : BaseClass, IAccessDB<Diagnostico>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionDiagnosticoGuardar;
        public List<Diagnostico> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Diagnostico> FindAll(string criterio)
        {
            return ORMDB<Diagnostico>.FindAll(criterio);
        }
        public Diagnostico FindbyKey(params object[] key)
        {
            var loc = ORMDB<Diagnostico>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = loc.Id;
            this.Nombre = loc.Nombre;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionDiagnosticoGuardar != null)
                {
                    if (Nombre == "")
                        ValidacionDiagnosticoGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Diagnostico>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Diagnostico
        public static List<Diagnostico> FindAllStatic(string criterio, Comparison<Diagnostico> compara)
        {
            var lista = ORMDB<Diagnostico>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Diagnostico FindByKeyStatic(params object[] key)
        {
            return ORMDB<Diagnostico>.FindbyKey(key);
        }
    }
}
