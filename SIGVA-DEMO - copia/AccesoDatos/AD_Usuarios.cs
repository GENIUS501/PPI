using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;
using Entidades;

namespace AccesoDatos
{
    public class AD_Usuarios
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        #region "Insertar"
        public Int32 Insertar(Ent_Usuarios uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "insert into Usuarios (Cedula,Nombre,Apellido1,Apellido2,Usuario,Clave,Rol) values(@cedula,@nombre,@apellido1,@apellido2,@usuario,@clave,@rol)";
                Parameter[] parametros = {
                                         new Parameter("@cedula",uRegistro.Cedula),
                                         new Parameter("@nombre",uRegistro.Nombre),
                                         new Parameter("@apellido1",uRegistro.Apellido1),
                                         new Parameter("@apellido2",uRegistro.Apellido2),
                                         new Parameter("@usuario",uRegistro.Usuario),
                                         new Parameter("@clave",uRegistro.Clave),
                                         new Parameter("@rol",uRegistro.Rol),
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

        #region "Actualizar"
        public Int32 Actualizar(Ent_Usuarios uRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Usuarios SET Nombre = @nombre, Apellido1 = @apellido1, Apellido2 = @apellido2, Clave = @clave, Rol = @rol WHERE Usuario = @usuario";
                Parameter[] parametros = {
                                        // new Parameter("@cedula",uRegistro.Cedula),
                                         new Parameter("@nombre",uRegistro.Nombre),
                                         new Parameter("@apellido1",uRegistro.Apellido1),
                                         new Parameter("@apellido2",uRegistro.Apellido2),
                                         new Parameter("@usuario",uRegistro.Usuario),
                                         new Parameter("@clave",uRegistro.Clave),
                                         new Parameter("@rol",uRegistro.Rol),
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

        #region "Leer Especifico"
        public Ent_Usuarios LeerCodigoLlave(string pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Ent_Usuarios vRegistro = new Ent_Usuarios();

                string commandText = "SELECT [Cedula],[Nombre],[Apellido1],[Apellido2],[Usuario],[Clave],[Rol] FROM [dbo].[Usuarios] WHERE [Usuario] =  '" + pCodigo.ToString()+"'";
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Cedula = Convert.ToInt32 (dtConsulta.Rows[0]["Cedula"]);
                    vRegistro.Nombre = dtConsulta.Rows[0]["Nombre"].ToString();
                    vRegistro.Apellido1 = dtConsulta.Rows[0]["Apellido1"].ToString();
                    vRegistro.Apellido2 = dtConsulta.Rows[0]["Apellido2"].ToString();
                    vRegistro.Usuario = dtConsulta.Rows[0]["Usuario"].ToString();
                    vRegistro.Clave = dtConsulta.Rows[0]["Clave"].ToString();
                    vRegistro.Rol = Convert.ToInt32(dtConsulta.Rows[0]["Rol"]);
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Login"
        public  Ent_Usuarios Login(string usera, string pass)
        {
            Ent_Usuarios user = new Ent_Usuarios();
            string sentencia;
            DataSet data = null;
            sentencia = "select * from Usuarios where Usuario = @Usuario and Clave = @Passwor";
            Parameter[] parametros = { new Parameter("@Usuario", usera),
                                       new Parameter("@Passwor",pass)                                     
                                     };
            data = Database.executeDataset(sentencia, parametros);
            foreach (DataRow row in data.Tables[0].Rows)
            {
                user = new Ent_Usuarios();
                user.Usuario = (String)row["Usuario"];
                user.Cedula = (Int32)row["Cedula"];
                user.Nombre = (String)row["Nombre"];
                user.Apellido1 = (String)row["Apellido1"];
                user.Apellido2 = (String)row["Apellido2"];
                user.Clave = (String)row["Clave"];
                user.Rol = (Int32)row["Rol"];
            }
            return user;
        }
        #endregion

        #region "Eliminar"
        public  Int32 Eliminar(string user)
        {
            Int32 Filasafectadas = 0;
            string sentencia;
            sentencia = "delete from Usuarios  where Usuario = @Usuario";
            Parameter[] parametros = { new Parameter("@Usuario", user.ToString()) };
           Filasafectadas = Database.exectuteNonQuery(sentencia, parametros);
            return Filasafectadas;
        }
        #endregion
    }
    }