using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class AD_Departamentos
    {
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
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion
    }
}
