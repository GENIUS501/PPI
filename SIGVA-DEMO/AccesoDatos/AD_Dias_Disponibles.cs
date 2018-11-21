using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
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

        #region "Leer Dia"
        public Ent_Dias_Disponibles LeerDia(Int32 pCedula,Int32 pAno)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Ent_Dias_Disponibles vRegistro = new Ent_Dias_Disponibles();

                string commandText = "SELECT [Cantidad_Dias] FROM [dbo].[Dias_Disponibles] WHERE [Cedula] =  " + pCedula + "AND [Ano] = "+pAno;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Cantidad_Dias = Convert.ToDecimal(dtConsulta.Rows[0]["Cantidad_Dias"].ToString());
                }
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
