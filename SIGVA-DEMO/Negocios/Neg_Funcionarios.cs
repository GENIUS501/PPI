using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
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
    }
}
