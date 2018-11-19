using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
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
    }
}
