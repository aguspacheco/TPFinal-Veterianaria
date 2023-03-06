using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class Especie : BaseClass, IAccessDB<Especie>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionEspecieGuardar;
        public List<Especie> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Especie> FindAll(string criterio)
        {
            return ORMDB<Especie>.FindAll(criterio);
        }
        public Especie FindbyKey(params object[] key)
        {
            var loc = ORMDB<Especie>.FindbyKey(key);
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
                if (this.ValidacionEspecieGuardar != null)
                {
                    if (Nombre == "")
                        ValidacionEspecieGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Especie>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Especie
        public static List<Especie> FindAllStatic(string criterio, Comparison<Especie> compara)
        {
            var lista = ORMDB<Especie>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Especie FindByKeyStatic(params object[] key)
        {
            return ORMDB<Especie>.FindbyKey(key);
        }
    }
}
