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

                   string query = "SELECT * FROM PUESTOS";

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
    }
}
