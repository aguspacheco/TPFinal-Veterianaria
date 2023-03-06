using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class Profesional : BaseClass, IAccessDB<Profesional>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionProfesionalGuardar;
        public List<Profesional> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Profesional> FindAll(string criterio)
        {
            return ORMDB<Profesional>.FindAll(criterio);
        }
        public Profesional FindbyKey(params object[] key)
        {
            var prof = ORMDB<Profesional>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.NroDocumento = prof.NroDocumento;
            this.Matricula = prof.Matricula;            
            this.Apellido = prof.Apellido;
            this.Nombres = prof.Nombres;
            this.Domicilio = prof.Domicilio;
            this.Telefono = prof.Telefono;
            this.CodPostal = prof.CodPostal;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionProfesionalGuardar != null)
                {
                    // validar mas de un campo significativo antes de guardar....
                    if (NroDocumento == 0)
                        ValidacionProfesionalGuardar("No se puede poner NroDocumento cero");
                }
            }
            return ORMDB<Profesional>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Profesional
        public static List<Profesional> FindAllStatic(string criterio, Comparison<Profesional> compara)
        {
            var lista = ORMDB<Profesional>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
        public static bool ExisteProfesional(int doc)
        {
            var list = FindAllStatic("dni=" + doc.ToString(),null);
            if (list != null && list.Count>0)
            return true;
            return false;
        }
    }
}
