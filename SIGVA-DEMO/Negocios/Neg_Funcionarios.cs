using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using AccesoDatos;


namespace Negocios
{
    public class Neg_Funcionarios
    {
        #region "Insertar"
        public Int32 Insertar(Ent_Funcionarios Data)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Funcionarios IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Funcionarios();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }
        #endregion

        #region "Leer Especifico"
        public Ent_Funcionarios LeerCodigoLlave(Int32 pCodigo)
        {
            AccesoDatos.AD_Funcionarios IControlador;
            try
            {
                IControlador = new AccesoDatos.AD_Funcionarios();
                return IControlador.LeerCodigoLlave(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region "Llenar datagrid0"
        public DataTable Llenar_data_grid0()
        {
            DataTable dt = new DataTable();
            AccesoDatos.AD_Funcionarios IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Funcionarios();
                dt = IControlador.llenar_datagrid0();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region "Llenar datagrid1"
        public DataTable Llenar_data_grid1(Int32 Parametro)
        {
            DataTable dt = new DataTable();
            AccesoDatos.AD_Funcionarios IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Funcionarios();
                dt = IControlador.llenar_datagrid1(Parametro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region "Llenar datagrid2"
        public DataTable Llenar_data_grid2(Int32 Parametro)
        {
            DataTable dt = new DataTable();
            AccesoDatos.AD_Funcionarios IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Funcionarios();
                dt = IControlador.llenar_datagrid2(Parametro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region "Eliminar"
        public Int32 Eliminar(Int32 Cedula)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Funcionarios IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Funcionarios();
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
