using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.IO;
using System.Configuration;

namespace AccesoDatos
{
   public class Database
    {
   
       private static string connectionString = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
        /*
          Para conectarnos con el servidor y seleccionar una base de datos debemos utilizar la clase SqlConnection:
            SqlConnection conexion=new SqlConnection("server=DIEGO-PC\\SQLEXPRESS ; database=base1 ; integrated security = true");
            El string que le pasamos al constructor del SqlConnection le indicamos como primer dato el nombre de nuestro servidor, en su máquina lo puede ubicar cuando arranca el SQL Server Management Studio:
            El segundo dato que se le pasa es el nombre de la base de datos con la que nos comunicaremos, en nuestro caso creamos previamente la base de datos "base1" y finalmente el último dato obligatorio es indicar "integrated security = true", esto hace que se utilice el usuario propio de Windows y no necesitemos por el momento crear otros usuarios propios de SQL Server.
         */
        private static DataProvider dataProvider = new SqlDataProvider();
        private static IDbConnection connection = dataProvider.connection(connectionString);

        public static void connect()
        {
            connection.Open();
        }

        public static void disconnect()
        {
            connection.Close();
        }

        public static Int32 exectuteNonQuery(string command, Parameter[] parameters)
        {
            Int32 FilasAfectadas = 0;
            // insert - update -delete
            try
            {
                connect();
                IDbCommand cmd = dataProvider.command(command);
                cmd.Connection = connection;
                foreach (Parameter parameter in parameters)
                {
                    cmd.Parameters.Add(dataProvider.parameter(parameter));
                }
              FilasAfectadas =  cmd.ExecuteNonQuery();
            }
            finally
            {
                disconnect();
            }
            return FilasAfectadas;
        }

        public static DataSet executeDataset(string command, Parameter[] parameters)
        {
            // select
            DataSet dts;
            try
            {
                connect();
                IDbDataAdapter adp = dataProvider.adapter(command, connection);
                foreach (Parameter parameter in parameters)
                {
                    adp.SelectCommand.Parameters.Add(dataProvider.parameter(parameter));
                }
                dts = new DataSet();
                adp.Fill(dts);
            }
            finally
            {
                disconnect();
            }
            return dts;
        }
    }
}
