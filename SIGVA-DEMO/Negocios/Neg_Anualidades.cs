using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocios
{
    public class Neg_Anualidades
    {
        #region "Insertar"
        public Int32 Insertar(Ent_Anualidades Data)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Anualidades IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Anualidades();
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
