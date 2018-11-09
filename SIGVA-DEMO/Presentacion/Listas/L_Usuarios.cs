using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
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
        //Negocios
        Neg_Usuarios Nusuarios;
        // Cliente Icliente;
        string valorPrimerCelda = null;
        #endregion
        private void L_cliente_Load(object sender, EventArgs e)
        {

            try 
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSetUsuarios.Usuarios' Puede moverla o quitarla según sea necesario.
                this.usuariosTableAdapter.Fill(this.sIGVADataSetUsuarios.Usuarios);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void L_cliente_Evento_Borrar(object sender, EventArgs e)
        {
            if (valorPrimerCelda == null)
            {
                MessageBox.Show("Favor de seleccionar los datos a Eliminar");
                return;
            }
            else
            {
                Nusuarios = new Neg_Usuarios();
                Int32 Filasafectadas = 0;
                Filasafectadas = Nusuarios.Eliminar(valorPrimerCelda);
                if (Filasafectadas > 0)
                {
                    L_cliente_Load(null, null);
                    MessageBox.Show("Datos eliminados exitosamente", "Eliminacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Eliminar datos");
                }
            }
        }

        private void L_cliente_Evento_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void L_cliente_Evento_Modificar(object sender, EventArgs e)
        {
            try
            {
                if (valorPrimerCelda == null)
                {
                    MessageBox.Show("Favor de seleccionar los datos a modificar");
                    return;
                }
                else
                {
                    M_Usuarios frm = new M_Usuarios();
                    frm.Modo = "M";
                    frm.titulo = "Mantenimiento de Usuarios";
                    frm.Descripcion = "Modificar Usuarios";
                    frm.Codigo = valorPrimerCelda;
                    frm.MostrarAgregar = false;
                    frm.MostrarEliminar = false;
                    frm.MostrarConsultar = false;
                    frm.MostrarImprimir = false;
                    frm.ShowDialog();
                    L_cliente_Load(null, null);
                }
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
               if (valorPrimerCelda == null)
                {
                    MessageBox.Show("Favor de seleccionar los datos a consultar");
                    return;
                }
               else 
               {
                M_Usuarios frm = new M_Usuarios();
                frm.Modo = "C";
                frm.titulo = "Mantenimiento de Clientes";
                frm.NombreBoton = "Volver";
                frm.Descripcion = "Consultar Cliente";
                frm.Codigo = valorPrimerCelda;
                frm.MostrarAgregar = false;
                frm.MostrarModificar = false;
                frm.MostrarEliminar = false;
                frm.MostrarImprimir = false;
                frm.ShowDialog();
                L_cliente_Load(null, null);
               }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Dat_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                valorPrimerCelda = Dat_Usuarios.Rows[e.RowIndex].Cells[4].Value.ToString(); 
            }catch(Exception)
            {

            }
            
        }
    }
}
