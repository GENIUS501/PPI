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
    public partial class VRrpt_rango : Form
    {
        #region "Propiedades"
        public Int32 Cedula{get;set;}
        public string Id_Departamento { get; set; }
        public string Id_Puesto { get; set; }
        public string Saldo { get; set; }
        #endregion
        public VRrpt_rango()
        {
            InitializeComponent();
        }

        private void VRrpt_rango_Load(object sender, EventArgs e)
        {
            try
            {
                
                // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet1.FUNCIONARIOS' Puede moverla o quitarla según sea necesario.
                this.FUNCIONARIOSTableAdapter.Fill(this.SIGVADataSet1.FUNCIONARIOS);
                // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet1.Anos_Institucion_Anterior' Puede moverla o quitarla según sea necesario.
                this.Anos_Institucion_AnteriorTableAdapter.Fill(this.SIGVADataSet1.Anos_Institucion_Anterior);
                // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet1.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                this.DEPARTAMENTOSTableAdapter.Fill(this.SIGVADataSet1.DEPARTAMENTOS);
                // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet1.PUESTOS' Puede moverla o quitarla según sea necesario.
                this.PUESTOSTableAdapter.Fill(this.SIGVADataSet1.PUESTOS);
                // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet1.Dias_Disponibles' Puede moverla o quitarla según sea necesario.
                this.Dias_DisponiblesTableAdapter.Fill(this.SIGVADataSet1.Dias_Disponibles);
                
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("Cedula", Cedula.ToString());
                parameters[1] = new ReportParameter("Id_Puesto", Id_Puesto);
                parameters[2] = new ReportParameter("Id_Departamento", Id_Departamento);
                parameters[3] = new ReportParameter("Saldo", Saldo);
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
