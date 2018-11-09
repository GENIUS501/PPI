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
    public partial class P_Devlover_Dias : frmProcesos
    {
        public P_Devlover_Dias()
        {
            InitializeComponent();
        }

        private void P_Devlover_Dias_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSetdiasdevueltos.DIAS_DEVOLUCION' Puede moverla o quitarla según sea necesario.
                this.dIAS_DEVOLUCIONTableAdapter.Fill(this.sIGVADataSetdiasdevueltos.DIAS_DEVOLUCION);
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSetdiasreservados.Dias_Reservados' Puede moverla o quitarla según sea necesario.
                this.dias_ReservadosTableAdapter.Fill(this.sIGVADataSetdiasreservados.Dias_Reservados);
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSetDias_Disponibles.Dias_Disponibles' Puede moverla o quitarla según sea necesario.
                this.dias_DisponiblesTableAdapter.Fill(this.sIGVADataSetDias_Disponibles.Dias_Disponibles);
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
    }
}
