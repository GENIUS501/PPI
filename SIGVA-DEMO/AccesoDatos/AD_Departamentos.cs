using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace AccesoDatos
{
    public class AD_Departamentos
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;

        #region "Insertar"
        public Int32 Insertar(Ent_Departamentos uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into DEPARTAMENTOS (Nombre_Departamento) values(@Nombre_Departamento)";
                Parameter[] parametros = {
                                         new Parameter("@Nombre_Departamento",uRegistro.Nombre_Departamento),
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

        #region "Leer Especifico"
        public Ent_Departamentos LeerCodigoLlave(Int32 pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Ent_Departamentos vRegistro = new Ent_Departamentos();

                string commandText = "SELECT [Id_Departamento],[Nombre_Departamento] FROM [dbo].[Departamentos] WHERE [Id_Departamento] = " + pCodigo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Id_Departamamento = Convert.ToInt32(dtConsulta.Rows[0]["Id_Departamento"]);
                    vRegistro.Nombre_Departamento = dtConsulta.Rows[0]["Nombre_Departamento"].ToString();
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
         public Int32 Actualizar(Ent_Departamentos uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE DEPARTAMENTOS SET Nombre_Departamento = @Nombre_Departamento WHERE Id_Departamento = @Id_Departamento";
                Parameter[] parametros = {
                                         new Parameter("@Id_Departamento",uRegistro.Id_Departamamento),
                                         new Parameter("@Nombre_Departamento",uRegistro.Nombre_Departamento),
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
         public Int32 Eliminar(Int32 id)
         {
             Int32 Filasafectadas = 0;
             string sentencia;
             sentencia = "delete from DEPARTAMENTOS  where Id_Departamento = @Id_Departamento";
             Parameter[] parametros = { new Parameter("@Id_Departamento", id) };
             Filasafectadas = Database.exectuteNonQuery(sentencia, parametros);
             return Filasafectadas;
         }
        #endregion
    }
}
