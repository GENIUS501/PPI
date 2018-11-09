using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Negocios;
//using Entidades;
//using Utiles;

namespace Presentacion
{
    public partial class L_cliente : frmListaBase 
    {
        public L_cliente()
        {
            InitializeComponent();
        }
        #region "Declaración Variable"
        // Cliente Icliente;
        #endregion
        private void L_cliente_Load(object sender, EventArgs e)
        {
            try 
            { 
            // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.sIGVADataSet.Usuarios);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.ToString()); 
            }

        }
        private void L_cliente_Evento_Agregar(object sender, EventArgs e)
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

        private void L_cliente_Evento_Borrar(object sender, EventArgs e)
        {

        }

        private void L_cliente_Evento_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void L_cliente_Evento_Modificar(object sender, EventArgs e)
        {
            try
            {
                /**if (this.lstDatos.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor de seleccionar los datos a modificar");
                    return;
                }*/
                M_Usuarios frm = new M_Usuarios();
                frm.Modo = "M";
                frm.titulo = "Mantenimiento de Usuarios";
                frm.Descripcion = "Modificar Usuarios";
              //  frm.Codigo = this.lstDatos.SelectedItems[0].Text;
                frm.MostrarAgregar = false;
                frm.MostrarEliminar = false;
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

        private void L_cliente_Evento_Consultar(object sender, EventArgs e)
        {
            try{
             /*   if (this.dataGridView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor de seleccionar los datos a consultar");
                    return;
                }*/
                
                M_Usuarios frm = new M_Usuarios();
                frm.Modo = "C";
                frm.titulo = "Mantenimiento de Clientes";
                frm.Descripcion = "Consultar Cliente";
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
    }
}
