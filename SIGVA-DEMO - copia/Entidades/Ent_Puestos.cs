using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Puestos
    {
        #region "Propiedades"
        public Int32 Id_Departamento { get; set; }
        public Int32 Id_Puesto { get; set; }
        public string Nombre_Puesto { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Puestos()
        {
            Id_Departamento = 0;
            Id_Puesto = 0;
            Nombre_Puesto = "";
        }
        #endregion

        #region "Constructor con parametros"
        public Ent_Puestos(Int32 id_departamento, Int32 id_puesto, string nombre_puesto)
        {
            Id_Departamento = id_departamento;
            Id_Puesto = id_puesto;
            Nombre_Puesto = nombre_puesto;  
        }
        #endregion

    }
}
