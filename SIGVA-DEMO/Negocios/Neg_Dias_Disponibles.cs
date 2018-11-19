using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

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
    }
}
