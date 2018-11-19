using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entidades;

namespace AccesoDatos
{
   public class AD_Dias_Disponibles
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        #region "Insertar"
        public Int32 Insertar(Ent_Dias_Disponibles uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into Dias_Disponibles (Ano,Cantidad_Dias,Cedula) values(@Ano,@Cantidad_Dias,@Cedula)";
                Parameter[] parametros = {
                                         new Parameter("@Ano",uRegistro.Ano),
                                         new Parameter("@Cantidad_Dias",uRegistro.Cantidad_Dias),
                                         new Parameter("@Cedula",uRegistro.Cedula),
                                      };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion
    }
}
