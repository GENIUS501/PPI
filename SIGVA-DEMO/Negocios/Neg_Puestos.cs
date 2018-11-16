using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using AccesoDatos;

namespace Negocios
{
   public class Neg_Puestos
    {
       #region "Insertar"
       public Int32 Insertar(Ent_Puestos Data)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Puestos IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Puestos();
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
       public Int32 Actualizar(Ent_Puestos Data)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Puestos IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Puestos();
               FilasAfectadas = IControlador.Actualizar(Data);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           return FilasAfectadas;
       }
       #endregion

       #region "Leer"
       public DataTable Leer()
       {
           DataTable dt;
           AccesoDatos.AD_Puestos IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Puestos();
               dt = IControlador.Leer();
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           return dt;
       }
        #endregion

       #region "Leer especifico"
       public Ent_Puestos LeerCodigoLlave(Int32 pCodigo)
       {
           AccesoDatos.AD_Puestos IControlador;
           try
           {
               IControlador = new AccesoDatos.AD_Puestos();
               return IControlador.LeerCodigoLlave(pCodigo);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }
       }
       #endregion

       #region "Eliminar"
       public Int32 Eliminar(Int32 Id)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Puestos IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Puestos();
               FilasAfectadas = IControlador.Eliminar(Id);
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
