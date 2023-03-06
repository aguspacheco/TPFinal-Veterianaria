using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class Medicamento : BaseClass, IAccessDB<Medicamento>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionMedicamentoGuardar;
        public List<Medicamento> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Medicamento> FindAll(string criterio)
        {
            return ORMDB<Medicamento>.FindAll(criterio);
        }
        public Medicamento FindbyKey(params object[] key)
        {
            var med = ORMDB<Medicamento>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = med.Id;
            this.Descripcion = med.Descripcion;
            this.CodEspecie = med.CodEspecie;
            this.Importe = med.Importe;
            this.Cantidad = med.Cantidad;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionMedicamentoGuardar != null)
                {
                    if (Descripcion == "")
                        ValidacionMedicamentoGuardar("No se puede poner Descripcion vacio");
                }
            }
            return ORMDB<Medicamento>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Medicamento
        public static List<Medicamento> FindAllStatic(string criterio, Comparison<Medicamento> compara)
        {
            var lista = ORMDB<Medicamento>.FindAll(criterio);
            if(compara!=null)
                lista.Sort(compara);
            return lista;
        }

        public static Medicamento FindByKeyStatic(params object[] key)
        {
            return ORMDB<Medicamento>.FindbyKey(key);
        }
    }
}
