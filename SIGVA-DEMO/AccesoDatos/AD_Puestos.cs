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
   public class AD_Puestos
    {
       string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
       #region "Insertar"
       public Int32 Insertar(Ent_Puestos uRegistro)
       {
           Int32 FilasAfectadas = 0;

           try
           {
               string sentencia;
               sentencia = "insert into PUESTOS (Id_Departamento,Nombre_Puesto) values(@Id_Departamento,@Nombre_Puesto)";
               Parameter[] parametros = {
                                         new Parameter("@Nombre_Puesto",uRegistro.Nombre_Puesto),
                                         new Parameter("@Id_Departamento",uRegistro.Id_Departamento),
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

       #region "Actualizar"
       public Int32 Actualizar(Ent_Puestos uRegistro)
       {
           Int32 FilasAfectadas = 0;

           try
           {
               string sentencia;
               sentencia = "UPDATE PUESTOS SET Nombre_Puesto = @Nombre_Puesto, Id_Departamento = @Id_Departamento WHERE Id_Puesto = @Id_Puesto";
               Parameter[] parametros = {
                                         new Parameter("@Nombre_Puesto",uRegistro.Nombre_Puesto),
                                         new Parameter("@Id_Departamento",uRegistro.Id_Departamento),
                                         new Parameter("@Id_Puesto",uRegistro.Id_Puesto),
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

       #region "Leer"
       public DataTable Leer()
       {
           DataTable dt = new DataTable();
           try
           {
               string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
               using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
               {

                   string query = "SELECT PUESTOS.Id_Puesto, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento FROM PUESTOS INNER JOIN DEPARTAMENTOS ON PUESTOS.Id_Departamento = DEPARTAMENTOS.Id_Departamento";

                   SqlCommand cmd = new SqlCommand(query, cnx);
                   SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                   
                   adaptador.Fill(dt);
                   
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
           return dt;
       }
        #endregion

       #region "Leer Especifico"
       public Ent_Puestos LeerCodigoLlave(Int32 pCodigo)
       {
           try
           {
               DataTable dtConsulta = new DataTable();
               Ent_Puestos vRegistro = new Ent_Puestos();

               string commandText = "SELECT [Id_Departamento],[Nombre_Puesto],[Id_Puesto] FROM [dbo].[PUESTOS] WHERE [Id_Puesto] = " + pCodigo;
               //string commandText = commandTexta;

               using (SqlConnection connection = new SqlConnection(vCadenaConexion))
               {
                   SqlCommand command = new SqlCommand(commandText, connection);

                   SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                   DataAdapter.Fill(dtConsulta);
               }

               if (dtConsulta.Rows.Count != 0)
               {
                   vRegistro.Id_Departamento = Convert.ToInt32(dtConsulta.Rows[0]["Id_Departamento"]);
                   vRegistro.Id_Puesto = Convert.ToInt32(dtConsulta.Rows[0]["Id_Puesto"]);
                   vRegistro.Nombre_Puesto = dtConsulta.Rows[0]["Nombre_Puesto"].ToString();
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
       public Int32 Eliminar(Int32 id)
       {
           Int32 Filasafectadas = 0;
           string sentencia;
           sentencia = "delete from PUESTOS  where Id_Puesto = @Id_Puesto";
           Parameter[] parametros = { new Parameter("@Id_Puesto", id) };
           Filasafectadas = Database.exectuteNonQuery(sentencia, parametros);
           return Filasafectadas;
       }
       #endregion
    }
}
