using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Negocios
{
   public class Neg_Saldos_Disponibles
    {
       #region "Eliminar"
       public Int32 Eliminar(Int32 Cedula)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Saldos_Disponibles IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Saldos_Disponibles();
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
