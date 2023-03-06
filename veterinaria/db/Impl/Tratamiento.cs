using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class Tratamiento : BaseClass, IAccessDB<Tratamiento>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTratamientoGuardar;
        public List<Tratamiento> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Tratamiento> FindAll(string criterio)
        {
            return ORMDB<Tratamiento>.FindAll(criterio);
        }
        public Tratamiento FindbyKey(params object[] key)
        {
            var med = ORMDB<Tratamiento>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = med.Id;
            this.Descripcion = med.Descripcion;
            this.CodEspecie = med.CodEspecie;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionTratamientoGuardar != null)
                {
                    if (Descripcion == "")
                        ValidacionTratamientoGuardar("No se puede poner Descripcion vacio");
                }
            }
            return ORMDB<Tratamiento>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Tratamiento
        public static List<Tratamiento> FindAllStatic(string criterio, Comparison<Tratamiento> compara)
        {
            var lista = ORMDB<Tratamiento>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Tratamiento FindByKeyStatic(params object[] key)
        {
            return ORMDB<Tratamiento>.FindbyKey(key);
        }
    }
}
