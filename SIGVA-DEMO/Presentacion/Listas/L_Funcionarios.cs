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
using Negocios;
using Entidades;
using Presentacion;

namespace Presentacion
{
    public partial class L_Funcionarios : frmListaBase
    {
        #region "Variables"
        Int32 valorPrimerCelda = -1;
        #endregion
        public L_Funcionarios()
        {
            InitializeComponent();
        }

        private void L_Funcionarios_Load(object sender, EventArgs e)
        {
            try
               {
                   this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
                   Neg_Funcionarios Nfuncionaros =new Neg_Funcionarios();
                   DataTable dt = new DataTable();
                   dt = Nfuncionaros.Llenar_data_grid0();
                   dataGridView1.DataSource = dt;
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
            DialogResult dr = MessageBox.Show("Realmente desea eliminar el funcionario tome en cuenta que se eliminaran tambien los dias disponibles,utilizados,devueltos y los reportes", "Eliminar el funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                
            }
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
                Neg_Funcionarios Nfuncionarios = new Neg_Funcionarios();
                DataTable dt = new DataTable();
                dt = Nfuncionarios.Llenar_data_grid1(Convert.ToInt32(this.Cbo_Departamentos.SelectedValue.ToString()));
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex) {
                //MessageBox.Show("ERROR: "+ex.ToString());
            }
        }

        private void Txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Buscar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al buscar los datos: "+ex);
            }
        }

        private void Buscar()
        {
            try
            {
                Neg_Funcionarios Nfuncionarios = new Neg_Funcionarios();
                dataGridView1.DataSource = Nfuncionarios.Llenar_data_grid2(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
            }catch(Exception ex)
            {
                MessageBox.Show("Error al buscar los datos: " + ex);
            }
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.Txt_Cedula.Text.ToString() != "")
                {
                    Buscar();
                }else
                {
                    MessageBox.Show("Debe llenar el campo de cedula");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al buscar los datos: "+ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorPrimerCelda = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
    }
}
