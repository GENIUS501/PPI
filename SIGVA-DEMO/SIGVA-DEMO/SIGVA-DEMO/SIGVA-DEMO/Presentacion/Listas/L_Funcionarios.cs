using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Presentacion;

namespace Presentacion
{
    public partial class L_Funcionarios : frmListaBase
    {
        public L_Funcionarios()
        {
            InitializeComponent();
        }

        private void L_Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
            this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);

           /* 
                using (SqlConnection cnx = new SqlConnection("connection string")) {

		        string query = "SELECT * FROM NombreTabla WHERE CUENTA_CLI LIKE @param + '%'";


		        SqlCommand cmd = new SqlCommand(query, cnx);
		        cmd.Parameters.AddWithValue("@param", TextBox1.Text.Trim);

		        SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
		        DataTable dt = new DataTable();
		        adaptador.Fill(dt);

		        dataGridView1.DataSource = dt;
            */
            try
               {
                    #region "Prueba"
                   string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
                    using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                    {

                        string query = "SELECT FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento, SUM(Dias_Disponibles.Cantidad_Dias) AS saldos FROM FUNCIONARIOS INNER JOIN Dias_Disponibles ON FUNCIONARIOS.Cedula = Dias_Disponibles.Cedula INNER JOIN DEPARTAMENTOS ON FUNCIONARIOS.Id_Departamento = DEPARTAMENTOS.Id_Departamento INNER JOIN PUESTOS ON FUNCIONARIOS.Id_Puesto = PUESTOS.Id_Puesto AND DEPARTAMENTOS.Id_Departamento = PUESTOS.Id_Departamento GROUP BY FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento";

                        SqlCommand cmd = new SqlCommand(query, cnx);
                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                    #endregion
               }
            catch(Exception ex)
               {
                    MessageBox.Show(ex.ToString());
               }
        }
        private void L_Funcionarios_Evento_Agregar(object sender, EventArgs e)
        {
            try
            {
                M_Funcionarios frm = new M_Funcionarios();
                // m_cliente frm = new m_cliente();
               //  frm.Modo = "A";
                 frm.titulo = "Mantenimiento de Funcionarios";
                 frm.Descripcion = "Agregar Funcionarios";
                 frm.MostrarEliminar = false;
                 frm.MostrarModificar = false;
                 frm.MostrarConsultar = false;
                 frm.MostrarImprimir = false;
                 frm.ShowDialog();
                // L_cliente_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_Funcionarios_Evento_Borrar(object sender, EventArgs e)
        {

        }

        private void L_Funcionarios_Evento_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void L_Funcionarios_Evento_Modificar(object sender, EventArgs e)
        {
            try
            {
                /**if (this.lstDatos.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor de seleccionar los datos a modificar");
                    return;
                }*/
                M_Funcionarios frm = new M_Funcionarios();
                frm.Modo = "M";
                frm.titulo = "Mantenimiento de Funcionarios";
                frm.Descripcion = "Modificar Funcionarios";
              //  frm.Codigo = this.lstDatos.SelectedItems[0].Text;
                frm.MostrarAgregar = false;
                frm.MostrarEliminar = false;
                frm.MostrarConsultar = false;
                frm.MostrarImprimir = false;
                frm.ShowDialog();
              //  L_cliente_Load(null, null)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_Funcionarios_Evento_Consultar(object sender, EventArgs e)
        {
            try
            {
                /* if (this.lstDatos.SelectedItems.Count == 0)
                 {
                     MessageBox.Show("Favor de seleccionar los datos a consultar");
                     return;
                 }*/

                 M_Funcionarios frm = new M_Funcionarios();
                 frm.Modo = "C";
                 frm.titulo = "Mantenimiento de Funcionarios";
                 frm.Descripcion = "Consultar Funcionarios";
                // frm.Codigo = this.lstDatos.SelectedItems[0].Text;
                 frm.MostrarAgregar = false;
                 frm.MostrarModificar = false;
                 frm.MostrarEliminar = false;
                 frm.MostrarImprimir = false;
                 frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string vCadenaConexion = ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SIGVAConnectionString"].ConnectionString;
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento, ISNULL(SUM(Dias_Disponibles.Cantidad_Dias),0) AS saldos FROM FUNCIONARIOS INNER JOIN Dias_Disponibles ON FUNCIONARIOS.Cedula = Dias_Disponibles.Cedula INNER JOIN DEPARTAMENTOS ON FUNCIONARIOS.Id_Departamento = DEPARTAMENTOS.Id_Departamento INNER JOIN PUESTOS ON FUNCIONARIOS.Id_Puesto = PUESTOS.Id_Puesto AND DEPARTAMENTOS.Id_Departamento = PUESTOS.Id_Departamento  AND DEPARTAMENTOS.Id_Departamento = @param GROUP BY FUNCIONARIOS.Cedula, FUNCIONARIOS.Nombre, FUNCIONARIOS.Apellido1, FUNCIONARIOS.Apellido2, FUNCIONARIOS.Fecha_De_Ingreso, FUNCIONARIOS.Direccion, FUNCIONARIOS.Telefono, FUNCIONARIOS.Email, PUESTOS.Nombre_Puesto, DEPARTAMENTOS.Nombre_Departamento";

                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@param", Convert.ToInt32(comboBox1.SelectedValue));
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: "+ex.ToString());
            }
        }
    }
}
