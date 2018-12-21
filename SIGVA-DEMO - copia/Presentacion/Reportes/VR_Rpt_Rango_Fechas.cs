using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VR_Rpt_Rango_Fechas : Form
    {
        #region "Propiedades"
        public DateTime Fecha_ini { get; set; }
        public DateTime Fecha_Fin { get; set; }
        #endregion
        public VR_Rpt_Rango_Fechas()
        {
            InitializeComponent();
        }

        private void VR_Rpt_Rango_Fechas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SIGVADataSetrpt_rango.Dias_Reservados' Puede moverla o quitarla según sea necesario.
                this.Dias_ReservadosTableAdapter.Fill(this.SIGVADataSetrpt_rango.Dias_Reservados);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Fecha_Ini", Fecha_ini.ToString());
                parameters[1] = new ReportParameter("Fecha_Fin", Fecha_Fin.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
