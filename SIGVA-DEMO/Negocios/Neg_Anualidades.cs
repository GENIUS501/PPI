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

        #region "Actualizar"
        public Int32 Actualizar(Ent_Anualidades Data)
        {
            Int32 FilasAfectadas = 0;
            AccesoDatos.AD_Anualidades IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Anualidades();
                FilasAfectadas = IControlador.Actualizar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }
        #endregion

        #region "Leer Anualidad"
        public Ent_Anualidades LeerAnualidad(Int32 Cedula)
        {
            AccesoDatos.AD_Anualidades IControlador;
            try
            {
                IControlador = new AccesoDatos.AD_Anualidades();
                return IControlador.LeerAnulidad(Cedula);
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
            AccesoDatos.AD_Anualidades IControlador;

            try
            {
                IControlador = new AccesoDatos.AD_Anualidades();
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
