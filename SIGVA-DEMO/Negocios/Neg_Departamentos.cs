using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Negocios
{
   public class Neg_Departamentos
   {
       #region "Insertar"
       public Int32 Insertar(Ent_Departamentos Data)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Departamentos IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Departamentos();
               FilasAfectadas = IControlador.Insertar(Data);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           return FilasAfectadas;
       }
       #endregion

       #region "Leer especifico"
       public Ent_Departamentos LeerCodigoLlave(Int32 pCodigo)
       {
           AccesoDatos.AD_Departamentos IControlador;
           try
           {
               IControlador = new AccesoDatos.AD_Departamentos();
               return IControlador.LeerCodigoLlave(pCodigo);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }
       }
       #endregion

       #region "Actualizar"
       public Int32 Actualizar(Ent_Departamentos Data)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Departamentos IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Departamentos();
               FilasAfectadas = IControlador.Actualizar(Data);
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
