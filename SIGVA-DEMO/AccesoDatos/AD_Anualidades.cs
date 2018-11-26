using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace AccesoDatos
{
    public class AD_Anualidades
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        #region "Insertar"
        public Int32 Insertar(Ent_Anualidades uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into Anualidades (Cedula,Cantidad_Dias) values(@Cedula,@Cantidad_Dias)";
                Parameter[] parametros = {
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

        #region "Leer Anualidad"
        public Ent_Anualidades LeerAnulidad(Int32 pCedula)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Ent_Anualidades vRegistro = new Ent_Anualidades();

                string commandText = "SELECT [Cantidad_Dias] FROM [dbo].[Anualidades] WHERE [Cedula] =  " + pCedula ;
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

        #region "Eliminar"
        public Int32 Eliminar(Int32 Cedula)
        {
            Int32 Filasafectadas = 0;
            string sentencia;
            sentencia = "delete from Anualidades  where Cedula = @Cedula";
            Parameter[] parametros = { new Parameter("@Cedula", Cedula) };
            Filasafectadas = Database.exectuteNonQuery(sentencia, parametros);
            return Filasafectadas;
        }
        #endregion
    }
}
