using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
   public class Neg_Bitacora
    {
       #region "Leer Todo"
       public DataTable Leer(string usuario)
       {
           AccesoDatos.AD_Bitacora IControlador;
           try
           {
               IControlador = new AccesoDatos.AD_Bitacora();
               return IControlador.LeerCodigoLlave(usuario);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }
       }
       #endregion
    }
}
