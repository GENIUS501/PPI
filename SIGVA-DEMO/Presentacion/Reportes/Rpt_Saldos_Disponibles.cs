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
    public partial class Rpt_Saldos_Disponibles : Rpt_Base
    {
        public Rpt_Saldos_Disponibles()
        {
            InitializeComponent();
        }

        private void Rpt_Saldos_Disponibles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGVADataSetdiasreservados.Dias_Reservados' Puede moverla o quitarla según sea necesario.
            this.dias_ReservadosTableAdapter.Fill(this.sIGVADataSetdiasreservados.Dias_Reservados);
            // TODO: esta línea de código carga datos en la tabla 'sIGVADataSetDias_Disponibles.Dias_Disponibles' Puede moverla o quitarla según sea necesario.
            this.dias_DisponiblesTableAdapter.Fill(this.sIGVADataSetDias_Disponibles.Dias_Disponibles);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
