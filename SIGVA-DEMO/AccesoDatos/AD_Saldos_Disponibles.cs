using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class AD_Saldos_Disponibles
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        
        #region "Insertar"
        public Int32 Insertar(Ent_Saldos_Disponibles uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into Saldos_Disponibles (Fecha_Elaboracion,Cedula,Anualidades) values(@Fecha_Elaboracion,@Cedula,@Anualidades)";
                Parameter[] parametros = {
                                         new Parameter("@Cedula",uRegistro.Cedula),
                                         new Parameter("@Fecha_Elaboracion",uRegistro.Fecha_Elaboracion),
                                         new Parameter("@Anualidades",uRegistro.Anualidades),
                                      };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion

        #region "Numero de reporte"
        public Int32 LeerNumeroreporte(Int32 pCodigo)
        {
            try
            {
                Int32 Numero_reporte = 0;
                DataTable dtConsulta = new DataTable();

                string commandText = "SELECT ISNULL(MAX(Codigo_de_reporte),0) AS Numero_reporte FROM Saldos_Disponibles Where Cedula = " + pCodigo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    Numero_reporte = Convert.ToInt32(dtConsulta.Rows[0]["Numero_reporte"]);
                }


                return Numero_reporte;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Eliminar"
        public Int32 Eliminar(Int32 Cedula)
        {
            Int32 Filasafectadas = 0;
            string sentencia;
            sentencia = "delete from Saldos_Disponibles  where Cedula = @Cedula";
            Parameter[] parametros = { new Parameter("@Cedula", Cedula) };
            Filasafectadas = Database.exectuteNonQuery(sentencia, parametros);
            return Filasafectadas;
        }
        #endregion
    }
}
