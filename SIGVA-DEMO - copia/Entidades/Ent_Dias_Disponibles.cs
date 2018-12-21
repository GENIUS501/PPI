using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Ent_Dias_Disponibles
   {
       #region "Propiedades"
       public Int32 Ano { get; set; }
       public Decimal Cantidad_Dias { get; set; }
       public Int32 Cedula { get; set; }
       #endregion

       #region "Constructor sin parametros"
       public Ent_Dias_Disponibles()
       {
           Ano = 0;
           Cantidad_Dias = 0;
           Cedula = 0;
       }
       #endregion

       #region "Constructor con parametros"
       public Ent_Dias_Disponibles(Int32 ano,Int32 cedula,Decimal cantidad_dias)
       {
           Ano = ano;
           Cedula = cedula;
           Cantidad_Dias = cantidad_dias;
       }
       #endregion
   }
}
