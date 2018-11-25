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
        public ArrayList datos = new ArrayList();
        public string usuario { get; set; }
        public AVR_Sessiones()
        {
            InitializeComponent();
        }

        private void AVR_Sessiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet.Sessiones' Puede moverla o quitarla según sea necesario.
            this.SessionesTableAdapter.Fill(this.SIGVADataSet.Sessiones);
          ReportParameter p = new ReportParameter("Usuario",usuario);

           // reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(p);
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
