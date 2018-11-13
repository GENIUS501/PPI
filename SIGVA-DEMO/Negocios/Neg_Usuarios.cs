using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Transactions;

namespace Negocios
{
     public class Neg_Usuarios
     {
        #region "Insertar"
         public Int32 Insertar(Ent_Usuarios Data)
         {
             Int32 FilasAfectadas = 0;
             AccesoDatos.AD_Usuarios IControlador;

             try
             {
                 IControlador = new AccesoDatos.AD_Usuarios();
                 FilasAfectadas = IControlador.Insertar(Data);
             }
             catch (Exception ex)
             {
                 throw new Exception(ex.Message, ex);
             }

             return FilasAfectadas;
         }
        #endregion

        #region "Actualizar"
         public Int32 Actualizar(Ent_Usuarios Data)
         {
             Int32 FilasAfectadas = 0;
             AccesoDatos.AD_Usuarios IControlador;

             try
             {
                 IControlador = new AccesoDatos.AD_Usuarios();
                 FilasAfectadas = IControlador.Actualizar(Data);
             }
             catch (Exception ex)
             {
                 throw new Exception(ex.Message, ex);
             }

             return FilasAfectadas;
         }
         #endregion

        #region "Leer Especifico"
             public Ent_Usuarios LeerCodigoLlave(string pCodigo)
             {
                 AccesoDatos.AD_Usuarios IControlador;
                 try
                 {
                     IControlador = new AccesoDatos.AD_Usuarios();
                     return IControlador.LeerCodigoLlave(pCodigo);
                 }
                 catch (Exception ex)
                 {
                     throw new Exception(ex.Message, ex);
                 }
             }
          #endregion

        #region "Login"
             public  Ent_Usuarios Login(string user, string pass)
             {
                 AccesoDatos.AD_Usuarios IControlador;
                 try
                 {
                     IControlador = new AccesoDatos.AD_Usuarios();
                     return IControlador.Login(user, pass);
                 }
                 catch (Exception ex)
                 {
                     throw new Exception("Usuario o contraseña no valido" + ex);
                 }
             }
        #endregion

        #region "Eliminar"
             public Int32 Eliminar(string user)
             {
                 Int32 FilasAfectadas = 0;
                 AccesoDatos.AD_Usuarios IControlador;

                 try
                 {
                     IControlador = new AccesoDatos.AD_Usuarios();
                     FilasAfectadas = IControlador.Eliminar(user);
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
