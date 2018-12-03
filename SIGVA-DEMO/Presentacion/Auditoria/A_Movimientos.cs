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
using Entidades;

namespace Presentacion
{
    public partial class A_Movimientos : frm_auditoria
    {
        #region "Variables"
        Neg_Bitacora Nbitacora;
        #endregion
        public A_Movimientos()
        {
            InitializeComponent();
        }

        private void A_Movimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet_Bitacora.Bitacora' Puede moverla o quitarla según sea necesario.
            this.bitacoraTableAdapter1.Fill(this.sIGVADataSet_Bitacora.Bitacora);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet2.Bitacora' Puede moverla o quitarla según sea necesario.
                // this.bitacoraTableAdapter.Fill(this.sIGVADataSet2.Bitacora);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmd_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Nbitacora = new Neg_Bitacora();
                if (this.Txt_Usuario.Text != "")
                {
                    Dat_Bitacora.DataSource = Nbitacora.Leer(this.Txt_Usuario.Text);
                    VR_A_Movimientos Visor = new VR_A_Movimientos();
                    Visor.usuario = this.Txt_Usuario.Text;
                    Visor.MdiParent = this.MdiParent;
                    Visor.Show();
                }
                else
                {
                    MessageBox.Show("Debe llenar el campo Usuarios", "Debe llenar el campo Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Nbitacora = new Neg_Bitacora();
                if(this.Txt_Usuario.Text!="")
                {
                    Dat_Bitacora.DataSource = Nbitacora.Leer(this.Txt_Usuario.Text);
                }else
                {
                    MessageBox.Show("Debe llenar el campo Usuarios","Debe llenar el campo Usuarios",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al buscar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
