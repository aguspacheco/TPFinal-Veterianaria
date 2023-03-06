using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vetApp.db.orm;

namespace vetApp.db
{
    public partial class Cliente : BaseClass, IAccessDB<Cliente>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionClienteGuardar;
        public List<Cliente> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Cliente> FindAll(string criterio)
        {
            return ORMDB<Cliente>.FindAll(criterio);
        }
        public Cliente FindbyKey(params object[] key)
        {
            var cli = ORMDB<Cliente>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.NroDocumento = cli.NroDocumento;    
            this.Apellido = cli.Apellido;
            this.Nombres = cli.Nombres;
            this.Domicilio = cli.Domicilio;
            this.Telefono = cli.Telefono;
            this.CodPostal = cli.CodPostal;
            this.Observaciones = cli.Observaciones;
            this.SetIsObjFromDB();// marcar la lectura desde la Base de datos.
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionClienteGuardar != null)
                {
                    if (NroDocumento == 0)
                        ValidacionClienteGuardar("No se puede poner Dni cero");
                }
            }
            return ORMDB<Cliente>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Cliente
        public static List<Cliente> FindAllStatic(string criterio, Comparison<Cliente> compara)
        {
            var lista = ORMDB<Cliente>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
    }
}
