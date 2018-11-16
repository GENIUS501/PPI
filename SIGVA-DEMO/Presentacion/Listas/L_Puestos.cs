using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;
using Negocios;

namespace Presentacion
{
    public partial class L_Puestos : frmListaBase
    {
        #region "Variables"
        Int32 valorPrimerCelda = -1;
        Neg_Puestos Npuestos;
        #endregion
        public L_Puestos()
        {
            InitializeComponent();
        }

        private void L_Puestos_Load(object sender, EventArgs e)
        {
            try 
            {
                Npuestos = new Neg_Puestos();
                DataTable dt = new DataTable();
                dt = Npuestos.Leer();
                Dat_Puestos.DataSource = dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void L_Puestos_Evento_Agregar(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_Puestos_Evento_Borrar(object sender, EventArgs e)
        {
            try
            {
                if(valorPrimerCelda == -1)
                {
                    MessageBox.Show("Favor de seleccionar los datos a eliminar");
                }else
                {
                    Npuestos = new Neg_Puestos();
                    Int32 Eliminar = 0;
                    Eliminar = Npuestos.Eliminar(valorPrimerCelda);
                    if(Eliminar>0)
                    {
                        MessageBox.Show("Datos eliminados exitosamente");
                        valorPrimerCelda = -1;
                        L_Puestos_Load(null,null);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar: "+ex);
            }
        }

        private void L_Puestos_Evento_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void L_Puestos_Evento_Modificar(object sender, EventArgs e)
        {
            try
            {
                if (valorPrimerCelda == -1)
                {
                    MessageBox.Show("Favor de seleccionar los datos a modificar");
                    return;
                }
                else
                {
                    M_Puestos frm = new M_Puestos();
                    frm.Modo = "M";
                    frm.titulo = "Mantenimiento de Puestos";
                    frm.Descripcion = "Modificar Puesto";
                    frm.Codigo = valorPrimerCelda;
                    frm.MostrarAgregar = false;
                    frm.MostrarEliminar = false;
                    frm.MostrarConsultar = false;
                    frm.MostrarImprimir = false;
                    frm.ShowDialog();
                    valorPrimerCelda = -1;
                    L_Puestos_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_Puestos_Evento_Consultar(object sender, EventArgs e)
        {
            try
            {
                 if (valorPrimerCelda == -1)
                 {
                     MessageBox.Show("Favor de seleccionar los datos a consultar");
                     return;
                 }else
                 {
                     M_Puestos frm = new M_Puestos();
                     frm.Modo = "C";
                     frm.titulo = "Mantenimiento de Puestos";
                     frm.Descripcion = "Consultar Puesto";
                     frm.Codigo = valorPrimerCelda;
                     frm.MostrarAgregar = false;
                     frm.MostrarModificar = false;
                     frm.MostrarEliminar = false;
                     frm.MostrarImprimir = false;
                     valorPrimerCelda = -1;
                     frm.ShowDialog();
                     L_Puestos_Load(null, null);
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Dat_Puestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorPrimerCelda = Convert.ToInt32(Dat_Puestos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
