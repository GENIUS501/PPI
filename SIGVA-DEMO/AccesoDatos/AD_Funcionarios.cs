using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace AccesoDatos
{
    public class AD_Funcionarios
    {

        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        #region "Insertar"
        public Int32 Insertar(Ent_Funcionarios uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into FUNCIONARIOS (Cedula,Nombre,Apellido1,Apellido2,Id_Puesto,Id_Departamento,Fecha_De_Ingreso,Direccion,Telefono,Email,Fecha_de_Anualidad,Estatus,Anos_Institucion_anterior) values(@Cedula,@Nombre,@Apellido1,@Apellido2,@Id_Puesto,@Id_Departamento,@Fecha_De_Ingreso,@Direccion,@Telefono,@Email,@Fecha_de_Anualidad,@Estatus,@Anos_Institucion_anterior)";
                Parameter[] parametros = {
                                         new Parameter("@Cedula",uRegistro.Cedula),
                                         new Parameter("@Nombre",uRegistro.Nombre),
                                         new Parameter("@Apellido1",uRegistro.Apellido1),
                                         new Parameter("@Apellido2",uRegistro.Apellido2),
                                         new Parameter("@Id_Puesto",uRegistro.Id_Puesto),
                                         new Parameter("@Id_Departamento",uRegistro.Id_Departamento),
                                         new Parameter("@Fecha_De_Ingreso",uRegistro.Fecha_De_Ingreso),
                                         new Parameter("@Direccion",uRegistro.Direccion),
                                         new Parameter("@Telefono",uRegistro.Telefono),
                                         new Parameter("@Email",uRegistro.Email),
                                         new Parameter("@Fecha_de_Anualidad",uRegistro.Fecha_de_Anualidad),
                                         new Parameter("@Estatus",uRegistro.Estatus),
                                         new Parameter("@Anos_Institucion_anterior",uRegistro.Anos_Institucion_anterior),
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

        #region "Llenar datagrid0"
        public DataTable llenar_datagrid0()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento, SUM(Dias_Disponibles.Cantidad_Dias) AS saldos FROM FUNCIONARIOS INNER JOIN Dias_Disponibles ON FUNCIONARIOS.Cedula = Dias_Disponibles.Cedula INNER JOIN DEPARTAMENTOS ON FUNCIONARIOS.Id_Departamento = DEPARTAMENTOS.Id_Departamento INNER JOIN PUESTOS ON FUNCIONARIOS.Id_Puesto = PUESTOS.Id_Puesto AND DEPARTAMENTOS.Id_Departamento = PUESTOS.Id_Departamento GROUP BY FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Llenar datagrid1"
        public DataTable llenar_datagrid1(Int32 Parametro)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento, ISNULL(SUM(Dias_Disponibles.Cantidad_Dias),0) AS saldos FROM FUNCIONARIOS INNER JOIN Dias_Disponibles ON FUNCIONARIOS.Cedula = Dias_Disponibles.Cedula INNER JOIN DEPARTAMENTOS ON FUNCIONARIOS.Id_Departamento = DEPARTAMENTOS.Id_Departamento INNER JOIN PUESTOS ON FUNCIONARIOS.Id_Puesto = PUESTOS.Id_Puesto AND DEPARTAMENTOS.Id_Departamento = PUESTOS.Id_Departamento  AND DEPARTAMENTOS.Id_Departamento = @param GROUP BY FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento";

                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@param", Convert.ToInt32(Parametro));
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Llenar datagrid2"
        
        public DataTable llenar_datagrid2(Int32 Parametro)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento, ISNULL(SUM(Dias_Disponibles.Cantidad_Dias),0) AS saldos FROM FUNCIONARIOS INNER JOIN Dias_Disponibles ON FUNCIONARIOS.Cedula = Dias_Disponibles.Cedula INNER JOIN DEPARTAMENTOS ON FUNCIONARIOS.Id_Departamento = DEPARTAMENTOS.Id_Departamento INNER JOIN PUESTOS ON FUNCIONARIOS.Id_Puesto = PUESTOS.Id_Puesto AND DEPARTAMENTOS.Id_Departamento = PUESTOS.Id_Departamento  AND FUNCIONARIOS.Cedula = @param GROUP BY FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@param", Convert.ToInt32(Parametro));
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
    }
}
