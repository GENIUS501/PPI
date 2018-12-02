using Entidades;
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
    public class AD_Bitacora
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        #region "Llenar datagrid"
        public DataTable LeerCodigoLlave(string pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Ent_Usuarios vRegistro = new Ent_Usuarios();

                string commandText = "SELECT * FROM Bitacora WHERE usuario ='" + pCodigo.ToString() + "'";
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                return dtConsulta;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        #endregion
        }
    }
}
