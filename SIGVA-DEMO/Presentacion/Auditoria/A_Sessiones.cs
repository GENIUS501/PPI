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
    public partial class A_Sessiones : frm_auditoria
    {
        #region "Variables"
        Neg_Sessiones Nsessiones;
        #endregion
        public A_Sessiones()
        {
            InitializeComponent();
        }
        private void A_Sessiones_Load(object sender, EventArgs e)
        {
            try
            {
                Nsessiones = new Neg_Sessiones();
                Dat_Sessiones.DataSource = Nsessiones.Leer();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: "+ex);
            }
        }

        private void Cmd_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Txt_Usuario.Text != "")
                {
                    Dat_Sessiones.DataSource = Nsessiones.LeerCodigoLlave(this.Txt_Usuario.Text.ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al buscar: "+ex);
            }
        }

        private void Txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (this.Txt_Usuario.Text != "")
                {
                    Dat_Sessiones.DataSource = Nsessiones.LeerCodigoLlave(this.Txt_Usuario.Text.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex);
            }
        }

        private void Cmd_Imprimir_Click(object sender, EventArgs e)
        {
            Nsessiones = new Neg_Sessiones();
            AVR_Sessiones Visor = new AVR_Sessiones();
            Visor.usuario = this.Txt_Usuario.Text;
            Visor.MdiParent = this.MdiParent;
            Visor.Show();
        }
    }
}
