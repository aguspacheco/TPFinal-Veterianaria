using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class Mascota : BaseClass, IAccessDB<Mascota>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionMascotaGuardar;
        public List<Mascota> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Mascota> FindAll(string criterio)
        {
            return ORMDB<Mascota>.FindAll(criterio);
        }
        public Mascota FindbyKey(params object[] key)
        {
            var masc = ORMDB<Mascota>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = masc.Id;
            this.Nombre = masc.Nombre;
            this.DniCliente = masc.DniCliente;
            this.FechaNac= masc.FechaNac;
            this.CodEspecie= masc.CodEspecie;
            this.Vacunado = masc.Vacunado;
            this.Observaciones = masc.Observaciones;
            this.SetIsObjFromDB();//marcar como que se recupero desde la base.
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionMascotaGuardar != null)
                {

                }
            }
            return ORMDB<Mascota>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Mascota
        public static List<Mascota> FindAllStatic(string criterio, Comparison<Mascota> compara)
        {
            var lista = ORMDB<Mascota>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
    }
}
