using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data;

namespace Negocios
{
   public class Neg_Dias_Disponibles
    {
        #region "Insertar"
        public Int32 Insertar(Ent_Dias_Disponibles Data)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Dias_Disponibles IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Dias_Disponibles();
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
        public Int32 Actualizar(Ent_Dias_Disponibles Data)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Dias_Disponibles IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Dias_Disponibles();
                FilasAfectadas = IControlador.Actualizar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }
        #endregion

        #region "Leer especial"
        public Ent_Dias_Disponibles Leerespecial(Int32 Cedula)
        {
            AccesoDatos.AD_Dias_Disponibles IControlador;
            try
            {
                IControlador = new AccesoDatos.AD_Dias_Disponibles();
                return IControlador.Leerespecial(Cedula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region "Leer Dia"
        public Ent_Dias_Disponibles LeerDia(Int32 Cedula, Int32 Ano)
        {
            AccesoDatos.AD_Dias_Disponibles IControlador;
            try
            {
                IControlador = new AccesoDatos.AD_Dias_Disponibles();
                return IControlador.LeerDia(Cedula,Ano);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region "Leer Saldos"
        public Decimal LeerSaldo(Int32 Cedula)
        {
            AccesoDatos.AD_Dias_Disponibles IControlador;
            try
            {
                IControlador = new AccesoDatos.AD_Dias_Disponibles();
                return IControlador.LeerSaldos(Cedula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region "Llenar datagrid"
        public DataTable Llenardatagrid(Int32 Cedula)
        {
            AccesoDatos.AD_Dias_Disponibles IControlador;
            try
            {
                IControlador = new AccesoDatos.AD_Dias_Disponibles();
                return IControlador.llenar_datagrid(Cedula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region "Eliminar"
        public Int32 Eliminar(Int32 Cedula)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Dias_Disponibles IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Dias_Disponibles();
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
