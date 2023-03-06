using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class MascotaMedicamento : BaseClass, IAccessDB<MascotaMedicamento>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionMascotaMedicamentoGuardar;
        public List<MascotaMedicamento> FindAll()
        {
            return this.FindAll(null);
        }
        public List<MascotaMedicamento> FindAll(string criterio)
        {
            return ORMDB<MascotaMedicamento>.FindAll(criterio);
        }
        public MascotaMedicamento FindbyKey(params object[] key)
        {
            var mascMed = ORMDB<MascotaMedicamento>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = mascMed.Id;
            this.Cantidad = mascMed.Cantidad;
            this.CodMascotaTratamiento = mascMed.CodMascotaTratamiento;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionMascotaMedicamentoGuardar != null)
                {
                    
                }
            }
            return ORMDB<MascotaMedicamento>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-MascotaMedicamento
        public static List<MascotaMedicamento> FindAllStatic(string criterio, Comparison<MascotaMedicamento> compara)
        {
            var lista = ORMDB<MascotaMedicamento>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static MascotaMedicamento FindByKeyStatic(params object[] key)
        {
            return ORMDB<MascotaMedicamento>.FindbyKey(key);
        }
    }
}
