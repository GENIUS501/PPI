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
    public class AD_Anos_Institucion_Anterior
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        #region "Insertar"
        public Int32 Insertar(Ent_Anos_Institucion_Anterior uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into Anos_Institucion_Anterior (Cedula,Cantidad_Dias) values(@Cedula,@Cantidad_Dias)";
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

        #region "Leer Anos_Institucion_Anterior"
        public Ent_Anos_Institucion_Anterior LeerAnos_Anterior(Int32 pCedula)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Ent_Anos_Institucion_Anterior vRegistro = new Ent_Anos_Institucion_Anterior();

                string commandText = "SELECT [Cantidad_Dias] FROM [dbo].[Anos_Institucion_Anterior] WHERE [Cedula] =  " + pCedula;
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

        #region "Actualizar"
        public Int32 Actualizar(Ent_Anos_Institucion_Anterior uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Anos_Institucion_Anterior SET Cantidad_Dias = @Cantidad_Dias WHERE Cedula = @Cedula";
                Parameter[] parametros = {
                                         new Parameter("@Cedula",uRegistro.Cedula),
                                         new Parameter("@Cantidad_Dias",uRegistro.Cantidad_Dias),
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

        #region "Eliminar"
        public Int32 Eliminar(Int32 Cedula)
        {
            Int32 Filasafectadas = 0;
            string sentencia;
            sentencia = "delete from Anos_Institucion_Anterior  where Cedula = @Cedula";
            Parameter[] parametros = { new Parameter("@Cedula", Cedula) };
            Filasafectadas = Database.exectuteNonQuery(sentencia, parametros);
            return Filasafectadas;
        }
        #endregion
    }
}
