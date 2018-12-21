using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Departamentos
    {
        #region "Propiedades"
        public Int32 Id_Departamamento { get; set; }
        public string Nombre_Departamento { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Departamentos()
        {
            Id_Departamamento = 0;
            Nombre_Departamento = "";
        }
        #endregion

        #region "Constructor con parametros"
        public Ent_Departamentos(Int32 id_departamento,string nombre_departamento)
        {
            Id_Departamamento = id_departamento;
            Nombre_Departamento = nombre_departamento;
        }
        #endregion
    }
}
