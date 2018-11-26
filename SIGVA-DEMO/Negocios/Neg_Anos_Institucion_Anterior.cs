using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocios
{
    public class Neg_Anos_Institucion_Anterior
    {
        #region "Insertar"
        public Int32 Insertar(Ent_Anos_Institucion_Anterior Data)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Anos_Institucion_Anterior IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Anos_Institucion_Anterior();
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
        public Int32 Actualizar(Ent_Anos_Institucion_Anterior Data)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Anos_Institucion_Anterior IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Anos_Institucion_Anterior();
                FilasAfectadas = IControlador.Actualizar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }
        #endregion

        #region "Eliminar"
        public Int32 Eliminar(Int32 Cedula)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Anos_Institucion_Anterior IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Anos_Institucion_Anterior();
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
