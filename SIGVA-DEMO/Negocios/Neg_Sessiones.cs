using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Negocios
{
   public class Neg_Sessiones
   {
       #region "Ingresar"
       public Int32 Ingresar(Ent_Sessiones Data)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Sessiones IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Sessiones();
               FilasAfectadas = IControlador.Ingresar(Data);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           return FilasAfectadas;
       }
       #endregion

       #region "Salir"
       public Int32 Salir(Ent_Sessiones Data)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Sessiones IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Sessiones();
               FilasAfectadas = IControlador.Salir(Data);
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
