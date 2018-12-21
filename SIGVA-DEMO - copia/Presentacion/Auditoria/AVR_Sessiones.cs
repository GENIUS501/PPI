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
using Entidades;
using System.Collections;

namespace Presentacion
{
    public partial class AVR_Sessiones : Form
    {
        #region"Propiedades"
        public string usuario { get; set; }
        #endregion
        public AVR_Sessiones()
        {
            InitializeComponent();
        }

        private void AVR_Sessiones_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet.Sessiones' Puede moverla o quitarla según sea necesario.
                this.SessionesTableAdapter.Fill(this.SIGVADataSet.Sessiones);
                ReportParameter p = new ReportParameter("Usuario", usuario);
                reportViewer1.LocalReport.SetParameters(p);
                this.reportViewer1.RefreshReport();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al generar el reporte",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
