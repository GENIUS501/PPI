﻿using System;
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
using Entidades;

namespace Presentacion
{
    public partial class L_Departamentos : frmListaBase
    {
        #region "Variables"
        Int32 valorPrimerCelda = -1;
        #endregion
        public L_Departamentos()
        {
            InitializeComponent();
        }

        private void L_Departamentos_Load(object sender, EventArgs e)
        {
            try { 
            // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                 this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }  

        }
        private void L_Departamentos_Evento_Agregar(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_Departamentos_Evento_Borrar(object sender, EventArgs e)
        {
            try
            {
                if (valorPrimerCelda == -1)
                {
                    MessageBox.Show("Favor de seleccionar los datos a eliminar");
                    return;
                }
                else
                {
                    Int32 Eliminar = 0;
                    Neg_Departamentos Ndepartamentos = new Neg_Departamentos();
                    Eliminar = Ndepartamentos.Eliminar(valorPrimerCelda);
                    if(Eliminar>0)
                    {
                        MessageBox.Show("Departamento Eliminado exitosamente");
                        valorPrimerCelda = -1;
                        L_Departamentos_Load(null,null);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar los datos: ");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos: "+ex);
            }
        }

        private void L_Departamentos_Evento_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void L_Departamentos_Evento_Modificar(object sender, EventArgs e)
        {
            try
            {
                if (valorPrimerCelda == -1)
                {
                    MessageBox.Show("Favor de seleccionar los datos a modificar");
                    return;
                }else
                {
                    M_Departamentos frm = new M_Departamentos();
                    frm.Modo = "M";
                    frm.titulo = "Mantenimiento de Departamentos";
                    frm.Descripcion = "Modificar Departamentos";
                    frm.Codigo = valorPrimerCelda;
                    frm.MostrarAgregar = false;
                    frm.MostrarEliminar = false;
                    frm.MostrarConsultar = false;
                    frm.MostrarImprimir = false;
                    valorPrimerCelda = -1;
                    frm.ShowDialog();
                    L_Departamentos_Load(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_Departamentos_Evento_Consultar(object sender, EventArgs e)
        {
            try
            {
                 if (valorPrimerCelda == -1)
                 {
                     MessageBox.Show("Favor de seleccionar los datos a consultar");
                     return;
                 }
                 else
                 {
                     M_Departamentos frm = new M_Departamentos();
                     frm.Modo = "C";
                     frm.titulo = "Mantenimiento de Departamentos";
                     frm.Descripcion = "Consultar Departamentos";
                     frm.Codigo = valorPrimerCelda;
                     frm.MostrarAgregar = false;
                     frm.MostrarModificar = false;
                     frm.MostrarEliminar = false;
                     frm.MostrarImprimir = false;
                     valorPrimerCelda = -1;
                     frm.ShowDialog();
                     L_Departamentos_Load(null, null);
                 }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorPrimerCelda = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
