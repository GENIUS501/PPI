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
using Entidades;

namespace Presentacion
{
    public partial class P_Devlover_Dias : frmProcesos
    {
        #region "Variables"
        Neg_Funcionarios Nfuncionarios;
        Ent_Funcionarios Efuncionarios;

        #endregion
        public P_Devlover_Dias()
        {
            InitializeComponent();
        }

        private void P_Devlover_Dias_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.Txt_Cedula.Text!="")
                {
                    if (this.Txt_Cedula.Text.Length > 7 && this.Txt_Cedula.Text.Length < 10)
                    {
                        Efuncionarios = new Ent_Funcionarios();
                        Nfuncionarios = new Neg_Funcionarios();
                        Efuncionarios = Nfuncionarios.LeerCodigoLlave(Convert.ToInt32(this.Txt_Cedula.Text));
                        this.Txt_Nombre.Text = Efuncionarios.Nombre;
                        this.Txt_Apellido1.Text = Efuncionarios.Apellido1;
                    }else
                    {
                        MessageBox.Show("Error en formato de cedula", "Error en formato de cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error debe digitar la cedula", "Error debe digitar la cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al buscar datos del funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
