using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using AccesoDatos;
using System.Collections;

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

       #region "Leer Todo"
       public DataTable Leer()
       {
           AccesoDatos.AD_Sessiones IControlador;
           try
           {
               IControlador = new AccesoDatos.AD_Sessiones();
               return IControlador.Leer();
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }
       }
       #endregion

       #region "Leer Especifico"
       public DataTable LeerCodigoLlave(string pCodigo)
       {
           AccesoDatos.AD_Sessiones IControlador;
           try
           {
               IControlador = new AccesoDatos.AD_Sessiones();
               return IControlador.LeerCodigoLlave(pCodigo);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }
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
