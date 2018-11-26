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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_Funcionarios_Evento_Borrar(object sender, EventArgs e)
        {
            try
            {
                if (valorPrimerCelda == -1)
                {
                    MessageBox.Show("Favor de Seleccionar el funcionario que desea eliminar");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Realmente desea eliminar el funcionario tome en cuenta que se eliminaran tambien los dias disponibles,utilizados,devueltos y los reportes", "Eliminar el funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Neg_Disponibles_Saldos Ndisponibles_saldos = new Neg_Disponibles_Saldos();
                        Neg_Saldos_Disponibles Nsaldos_disponibles = new Neg_Saldos_Disponibles();
                        Neg_Anualidades Nanualidades = new Neg_Anualidades();
                        Neg_Anos_Institucion_Anterior Nanos_institucion = new Neg_Anos_Institucion_Anterior();
                        Neg_Dias_Disponibles Ndias_disponibles = new Neg_Dias_Disponibles();
                        Neg_Dias_Reservados Ndias_reservados = new Neg_Dias_Reservados();
                        Neg_Dias_Devolucion Ndias_devolucion = new Neg_Dias_Devolucion();
                        Neg_Funcionarios Nfuncionarios = new Neg_Funcionarios();
                        Int32 Eliminardisponibles_saldos = 0;
                        Int32 Eliminarsaldos_disponibles = 0;
                        Int32 Eliminaranualidades = 0;
                        Int32 Eliminaranos_institucion = 0;
                        Int32 Eliminardias_disponibles = 0;
                        Int32 Eliminardias_reservados = 0;
                        Int32 Eliminardias_devolucion = 0;
                        Int32 Eliminarfuncionarios = 0;
                        Eliminardisponibles_saldos = Ndisponibles_saldos.Eliminar(valorPrimerCelda);
                        Eliminarsaldos_disponibles = Nsaldos_disponibles.Eliminar(valorPrimerCelda);
                        Eliminaranualidades = Nanualidades.Eliminar(valorPrimerCelda);
                        Eliminaranos_institucion = Nanos_institucion.Eliminar(valorPrimerCelda);
                        Eliminardias_disponibles = Ndias_disponibles.Eliminar(valorPrimerCelda);
                        Eliminardias_reservados = Ndias_reservados.Eliminar(valorPrimerCelda);
                        Eliminardias_devolucion = Ndias_devolucion.Eliminar(valorPrimerCelda);
                        Eliminarfuncionarios = Nfuncionarios.Eliminar(valorPrimerCelda);
                        if(Eliminarfuncionarios>0)
                        {
                            MessageBox.Show("Funcionario eliminado exitosamente");
                            L_Funcionarios_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el funcionarios");
                            L_Funcionarios_Load(null, null);
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar datos: "+ex);
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
                if (valorPrimerCelda == -1)
                {
                    MessageBox.Show("Favor de Seleccionar el funcionario a Modificar");
                }
                else
                {
                    M_Funcionarios frm = new M_Funcionarios();
                    frm.Modo = "M";
                    frm.titulo = "Mantenimiento de Funcionarios";
                    frm.Descripcion = "Modificar Funcionarios";
                    frm.Codigo = valorPrimerCelda;
                    frm.MostrarAgregar = false;
                    frm.MostrarEliminar = false;
                    frm.MostrarConsultar = false;
                    frm.MostrarImprimir = false;
                    frm.ShowDialog();
                    valorPrimerCelda = -1;
                    L_Funcionarios_Load(null, null);
                }
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
                if (valorPrimerCelda == -1)
                {
                    MessageBox.Show("Favor de Seleccionar el funcionario a Consultar");
                    return;
                }
                else
                {
                    M_Funcionarios frm = new M_Funcionarios();
                    frm.Modo = "C";
                    frm.titulo = "Mantenimiento de Funcionarios";
                    frm.Descripcion = "Consultar Funcionarios";
                    frm.Codigo = valorPrimerCelda;
                    frm.MostrarAgregar = false;
                    frm.MostrarModificar = false;
                    frm.MostrarEliminar = false;
                    frm.MostrarImprimir = false;
                    frm.ShowDialog();
                    valorPrimerCelda = -1;
                    L_Funcionarios_Load(null,null);
                }
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
                Console.WriteLine("Error: "+ex.ToString());
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
