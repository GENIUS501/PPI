﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AD_Dias_Devolucion
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        #region "Insertar"
        public Int32 Insertar(Ent_Dias_Devolucion uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into DIAS_DEVOLUCION (Fecha_de_devolucion,Detalle,Cantidad_dias,Id_Reservacion,Cedula) values(@Fecha_de_devolucion,@Detalle,@Cantidad_dias,@Id_Reservacion,@Cedula)";
                Parameter[] parametros = {
                                         new Parameter("@Fecha_de_devolucion",uRegistro.Fecha_de_devolucion),
                                         new Parameter("@Detalle",uRegistro.Detalle),
                                         new Parameter("@Cantidad_dias",uRegistro.Cantidad_dias),
                                         new Parameter("@Id_Reservacion",uRegistro.Id_Reservacion),
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

        #region "Llenar datagrid"
        public DataTable llenar_datagrid(Int32 Pcodigo)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM DIAS_DEVOLUCION WHERE Cedula = " + Pcodigo;
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
            sentencia = "delete from DIAS_DEVOLUCION  where Cedula = @Cedula";
            Parameter[] parametros = { new Parameter("@Cedula", Cedula) };
            Filasafectadas = Database.exectuteNonQuery(sentencia, parametros);
            return Filasafectadas;
        }
        #endregion
    }
}
