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
    public partial class Rpt_Rango_Fechas : Rpt_Base
    {
        #region "Variables"
        Neg_Dias_Reservados Ndias_Reservados;
        //Ent_Dias_Reservados Edias_Reservados;
        #endregion
        public Rpt_Rango_Fechas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Ndias_Reservados = new Neg_Dias_Reservados();
                Dat_Rango.DataSource = Ndias_Reservados.Llenardatagridreporte(Convert.ToDateTime(this.Txt_Fecha_Ini.Text),Convert.ToDateTime(this.Txt_Fecha_Fin.Text));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los de busqueda",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Cmd_Generar_Click(object sender, EventArgs e)
        {
            try
            {
                VR_Rpt_Rango_Fechas Visor = new VR_Rpt_Rango_Fechas();
                Visor.Fecha_ini = Convert.ToDateTime(this.Txt_Fecha_Ini.Text);
                Visor.Fecha_Fin = Convert.ToDateTime(this.Txt_Fecha_Fin.Text);
                Visor.MdiParent = this.MdiParent;
                Visor.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los datos de busqueda",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
