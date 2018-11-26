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
using Presentacion;

namespace Presentacion
{
    public partial class Rpt_Rango : Rpt_Base
    {
        #region "Variables"
        Int32 Cedula;
        string Nombre_Departamento;
        string Nombre_Puesto;
        string Saldo;
        #endregion
        public Rpt_Rango()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rpt_Rango_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Cant_Dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    cargar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: "+ex);
            }
        }

        private void cargar()
        {
            Neg_Funcionarios Nfuncionaros = new Neg_Funcionarios();
            dat_rango.DataSource = Nfuncionaros.Llenar_data_reporte(Convert.ToInt32(this.Txt_Cant_Dias.Text));
        }
        private void Cmd_Generar_Click(object sender, EventArgs e)
        {
            VRrpt_rango Visor = new VRrpt_rango();
            Visor.Id_Departamento = Nombre_Departamento;
            Visor.Id_Puesto = Nombre_Puesto;
            Visor.Cedula = Cedula;
            Visor.Saldo = Saldo;
            Visor.MdiParent = this.MdiParent;
            Visor.Show();
            Rpt_Rango_Load(null, null);
        }

        private void dat_rango_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cedula = Convert.ToInt32(dat_rango.Rows[e.RowIndex].Cells[0].Value.ToString());
                Nombre_Puesto = dat_rango.Rows[e.RowIndex].Cells[11].Value.ToString();
                Nombre_Departamento = dat_rango.Rows[e.RowIndex].Cells[12].Value.ToString();
                Saldo = dat_rango.Rows[e.RowIndex].Cells[13].Value.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }
    }
}
