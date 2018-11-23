using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AD_Dias_Devolucion
    {
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
