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
    public partial class I_Funcionarios : frmIngresos
    {
        public I_Funcionarios()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = Txt_Fecha_Ingreso.Value.Date;
            DateTime fechaFinal = DateTime.Now; 

            TimeSpan tSpan = fechaFinal - fechaInicio;

            int dias = tSpan.Days;

            Decimal  res =  0.0333m;

            Decimal resa = dias * res;

            DateTime F  = fechaInicio.AddMonths(1);

            if (fechaInicio < fechaFinal)
            {
                for (int i = 0; i < 5; i++)
                {
                   // DateTime F = fechaInicio.AddMonths(12);
                }
                
            }

            MessageBox.Show("Cantidad de dias:" + dias +" V: "+resa+"Ano despues:"+F);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
