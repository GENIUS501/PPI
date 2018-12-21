using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Sessiones
    {
        #region "Propiedades"
        public Int32 Id_Session { get; set; }
        public string Usuario { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Sessiones()
        {
            Id_Session = 0;
        }
        #endregion

        #region "Constructor con parametros"
        public Ent_Sessiones(Int32 id_session,string usuario,DateTime ingreso,DateTime salida)
        {
            Id_Session = id_session;
            Usuario = usuario;
            Ingreso = ingreso;
            Salida = salida;
        }
        #endregion
    }
}
