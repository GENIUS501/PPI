using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Ent_Anualidades
   {
       #region "Propiedades"
       public Int32 Cedula { get; set; }
       public Decimal Cantidad_Dias { get; set; }
       #endregion

       #region "Constructor sin parametros"
       public Ent_Anualidades()
       {
           Cedula = 0;
           Cantidad_Dias = 0;
       }
       #endregion

       #region "Constructor con parametros"
       public Ent_Anualidades(Int32 cedula, Decimal cantidad_dias)
       {
           Cedula = cedula;
           Cantidad_Dias = cantidad_dias;
       }
       #endregion
   }
}
