using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
   public class Neg_Dias_Reservados
    {
       #region "Eliminar"
       public Int32 Eliminar(Int32 Cedula)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Dias_Reservados IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Dias_Reservados();
               FilasAfectadas = IControlador.Eliminar(Cedula);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           return FilasAfectadas;
       }
       #endregion
    }
}
