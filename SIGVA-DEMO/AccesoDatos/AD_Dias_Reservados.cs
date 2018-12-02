using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Entidades;

namespace AccesoDatos
{
    public class AD_Dias_Reservados
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;

        #region "Insertar"
        public Int32 Insertar(Ent_Dias_Reservados uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into Dias_Reservados (Cedula,Fecha_Inicial,Fecha_Final,Detalle,Reservado_El,Cantidad_dias) values(@Cedula,@Fecha_Inicial,@Fecha_Final,@Detalle,@Reservado_El,@Cantidad_dias)";
                Parameter[] parametros = {
                                         new Parameter("@Cedula",uRegistro.Cedula),
                                         new Parameter("@Fecha_Inicial",uRegistro.Fecha_Inicial),
                                         new Parameter("@Fecha_Final",uRegistro.Fecha_Final),
                                         new Parameter("@Detalle",uRegistro.Detalle),
                                         new Parameter("@Reservado_El",uRegistro.Reservado_El),
                                         new Parameter("@Cantidad_dias",uRegistro.Cantidad_dias),
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

        #region "Reporte"
        public DataTable llenar_datagrid_reporte(DateTime Fecha_ini,DateTime Fecha_Fin)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Dias_Reservados Where Reservado_El BETWEEN '"+Fecha_ini+"' AND '"+Fecha_Fin+"'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Llenar datagrid"
        public DataTable llenar_datagrid(Int32 Pcodigo)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Dias_Reservados WHERE Cedula = " + Pcodigo;
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
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
            sentencia = "delete from Dias_Reservados  where Cedula = @Cedula";
            Parameter[] parametros = { new Parameter("@Cedula", Cedula) };
            Filasafectadas = Database.exectuteNonQuery(sentencia, parametros);
            return Filasafectadas;
        }
        #endregion
    }
}
