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
    public partial class VR_Rpt_Saldos_Disponibles : Form
    {
        #region "Propiedades"
        public Int32 Codigo_Reporte { get; set; }
        public Int32 Cedula { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string Fecha_Ingreso { get; set; }
        public Int32 Anualidades { get; set; }
        #endregion
        public VR_Rpt_Saldos_Disponibles()
        {
            InitializeComponent();
        }

        private void VR_Rpt_Saldos_Disponibles_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'Saldos_Disponibles.Dias_Disponibles' Puede moverla o quitarla según sea necesario.
                this.Dias_DisponiblesTableAdapter.Fill(this.Saldos_Disponibles.Dias_Disponibles);
                // TODO: esta línea de código carga datos en la tabla 'Saldos_Disponibles.Dias_Reservados' Puede moverla o quitarla según sea necesario.
                this.Dias_ReservadosTableAdapter.Fill(this.Saldos_Disponibles.Dias_Reservados);
                // TODO: esta línea de código carga datos en la tabla 'Saldos_Disponibles.FUNCIONARIOS' Puede moverla o quitarla según sea necesario.
                this.FUNCIONARIOSTableAdapter.Fill(this.Saldos_Disponibles.FUNCIONARIOS);
                ReportParameter[] parameters = new ReportParameter[7];
                parameters[0] = new ReportParameter("Cedula", Cedula.ToString());
                parameters[1] = new ReportParameter("Codigo_Reporte", Codigo_Reporte.ToString());
                parameters[2] = new ReportParameter("Nombre", Nombre);
                parameters[3] = new ReportParameter("Departamento", Departamento);
                parameters[4] = new ReportParameter("Fecha_Ingreso", Fecha_Ingreso);
                parameters[5] = new ReportParameter("Puesto", Puesto);
                parameters[6] = new ReportParameter("Anualidades", Anualidades.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
 