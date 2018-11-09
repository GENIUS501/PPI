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

namespace Presentacion
{
    public partial class L_Puestos : frmListaBase
    {
        public L_Puestos()
        {
            InitializeComponent();
        }

        private void L_Puestos_Load(object sender, EventArgs e)
        {
            try 
            {
            // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1.PUESTOS' Puede moverla o quitarla según sea necesario.
            this.pUESTOSTableAdapter.Fill(this.sIGVADataSet1.PUESTOS);
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
                /* m_cliente frm = new m_cliente();
                 frm.Modo = "A";
                 frm.titulo = "Mantenimiento de Clientes";
                 frm.Descripcion = "Agregar Clientes";
                 frm.MostrarEliminar = false;
                 frm.MostrarModificar = false;
                 frm.MostrarConsultar = false;
                 frm.MostrarImprimir = false;
                 frm.ShowDialog();
                 L_cliente_Load(null, null);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_Puestos_Evento_Borrar(object sender, EventArgs e)
        {

        }

        private void L_Puestos_Evento_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void L_Puestos_Evento_Modificar(object sender, EventArgs e)
        {
            try
            {
                /**if (this.lstDatos.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor de seleccionar los datos a modificar");
                    return;
                }*/
                M_Puestos frm = new M_Puestos();
                frm.Modo = "M";
                frm.titulo = "Mantenimiento de Puestos";
                frm.Descripcion = "Modificar Puesto";
               // frm.Codigo = this.lstDatos.SelectedItems[0].Text;
                frm.MostrarAgregar = false;
                frm.MostrarEliminar = false;
                frm.MostrarConsultar = false;
                frm.MostrarImprimir = false;
                frm.ShowDialog();
               // L_cliente_Load(null, null);*/
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
                /* if (this.lstDatos.SelectedItems.Count == 0)
                 {
                     MessageBox.Show("Favor de seleccionar los datos a consultar");
                     return;
                 }

                 m_cliente frm = new m_cliente();
                 frm.Modo = "C";
                 frm.titulo = "Mantenimiento de Clientes";
                 frm.Descripcion = "Consultar Cliente";
                 frm.Codigo = this.lstDatos.SelectedItems[0].Text;
                 frm.MostrarAgregar = false;
                 frm.MostrarModificar = false;
                 frm.MostrarEliminar = false;
                 frm.MostrarImprimir = false;
                 frm.ShowDialog();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
