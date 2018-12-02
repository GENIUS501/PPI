using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Negocios
{
    public class Neg_Dias_Devolucion
    {
        #region "Insertar"
        public Int32 Insertar(Ent_Dias_Devolucion Data)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Dias_Devolucion IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Dias_Devolucion();
                FilasAfectadas = IControlador.Insertar(Data);
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
            AccesoDatos.AD_Dias_Devolucion IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Dias_Devolucion();
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
