using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class MascotaTratamiento : BaseClass, IAccessDB<MascotaTratamiento>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionMascotaTratamientoGuardar;
        public List<MascotaTratamiento> FindAll()
        {
            return this.FindAll(null);
        }
        public List<MascotaTratamiento> FindAll(string criterio)
        {
            return ORMDB<MascotaTratamiento>.FindAll(criterio);
        }
        public MascotaTratamiento FindbyKey(params object[] key)
        {
            var mascTrat = ORMDB<MascotaTratamiento>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = mascTrat.Id;
            this.CodConsulta = mascTrat.CodConsulta;
            this.CodTratamiento = mascTrat.CodTratamiento;
            this.FechaDesde = mascTrat.FechaDesde;
            this.FechaHasta = mascTrat.FechaHasta;

            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionMascotaTratamientoGuardar != null)
                {

                }
            }
            return ORMDB<MascotaTratamiento>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-MascotaTratamiento
        public static List<MascotaTratamiento> FindAllStatic(string criterio, Comparison<MascotaTratamiento> compara)
        {
            var lista = ORMDB<MascotaTratamiento>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static MascotaTratamiento FindByKeyStatic(params object[] key)
        {
            return ORMDB<MascotaTratamiento>.FindbyKey(key);
        }
    }
}
