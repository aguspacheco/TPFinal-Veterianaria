using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class TurnoConsulta : BaseClass, IAccessDB<TurnoConsulta>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTurnoGuardar;
        public List<TurnoConsulta> FindAll()
        {
            return this.FindAll(null);
        }
        public List<TurnoConsulta> FindAll(string criterio)
        {
            return ORMDB<TurnoConsulta>.FindAll(criterio);
        }
        public TurnoConsulta FindbyKey(params object[] key)
        {
            var turno = ORMDB<TurnoConsulta>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = turno.Codigo;
            this.CodCentroAtencion = turno.CodCentroAtencion;
            this.CodMascota = turno.CodMascota;
            this.NroDocProfesional = turno.NroDocProfesional;
            this.Fecha = turno.Fecha;
            this.Hora = turno.Hora;
            
            this.SetIsObjFromDB();//marcar como que se recupero desde la base.
            return this;
        }
        public bool     SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionTurnoGuardar != null)
                {
                    
                }
            }
            return ORMDB<TurnoConsulta>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-TurnoConsulta
        public static List<TurnoConsulta> FindAllStatic(string criterio, Comparison<TurnoConsulta> compara)
        {
            var lista = ORMDB<TurnoConsulta>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
    }
}
