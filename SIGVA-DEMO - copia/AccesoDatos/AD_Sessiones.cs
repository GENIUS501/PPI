using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using System.Collections;

namespace AccesoDatos
{
   public class AD_Sessiones
   {
       
       string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
       #region "Ingresar"
       public Int32 Ingresar(Ent_Sessiones uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into Sessiones (Usuario,Ingreso) values(@Usuario,@Ingreso)";
                Parameter[] parametros = {
                                         new Parameter("@Usuario",uRegistro.Usuario),
                                         new Parameter("@Ingreso",uRegistro.Ingreso),
                                      };
               FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
               if (FilasAfectadas > 0)
               {
                   FilasAfectadas = Obtenerid();
               }
            }
            catch (Exception ex)
            {
                throw ex;
            }

                return FilasAfectadas;
        }

       private Int32 Obtenerid()
       {
           Int32 Respuesta = 0;

           string sentencia;
           DataSet data = null;
           sentencia = "SELECT TOP 1 * FROM Sessiones ORDER BY Id_session DESC";
           Parameter[] parametros = { new Parameter("",0)                                    
                                     };
           data = Database.executeDataset(sentencia, parametros);
           foreach (DataRow row in data.Tables[0].Rows)
           {
               Respuesta = (Int32)row["Id_session"];
           }
           return Respuesta;
       }
        #endregion

       #region "Leer todos"
       public DataTable Leer()
       {
           try
           {
               DataTable dtConsulta = new DataTable();
               Ent_Usuarios vRegistro = new Ent_Usuarios();

               string commandText = "SELECT * FROM [dbo].[Sessiones] ";
               //string commandText = commandTexta;

               using (SqlConnection connection = new SqlConnection(vCadenaConexion))
               {
                   SqlCommand command = new SqlCommand(commandText, connection);

                   SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                   DataAdapter.Fill(dtConsulta);
               }

               return dtConsulta;

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       #endregion

       #region "Leer Especifico"
       public DataTable LeerCodigoLlave(string pCodigo)
       {
           try
           {
               DataTable dtConsulta = new DataTable();
               Ent_Usuarios vRegistro = new Ent_Usuarios();

               string commandText = "SELECT * FROM [dbo].[Sessiones] WHERE [Usuario] =  '" + pCodigo.ToString() + "'";
               //string commandText = commandTexta;

               using (SqlConnection connection = new SqlConnection(vCadenaConexion))
               {
                   SqlCommand command = new SqlCommand(commandText, connection);

                   SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                   DataAdapter.Fill(dtConsulta);
               }

               return dtConsulta;

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       #endregion

       #region "Salir"
       public Int32 Salir(Ent_Sessiones uRegistro)
       {
           Int32 FilasAfectadas = 0;

           try
           {
               string sentencia;
               sentencia = "UPDATE Sessiones SET  Salida = @Salida WHERE Id_session = @Id_session";
               Parameter[] parametros = {
                                         new Parameter("@Id_session",uRegistro.Id_Session),
                                         new Parameter("@Salida",uRegistro.Salida),
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
