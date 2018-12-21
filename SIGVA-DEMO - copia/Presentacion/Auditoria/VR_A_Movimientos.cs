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
    public partial class VR_A_Movimientos : Form
    {
        #region"Propiedades"
        public string usuario { get; set; }
        #endregion
        public VR_A_Movimientos()
        {
            InitializeComponent();
        }

        private void VR_A_Movimientos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet_Bitacora.Bitacora' Puede moverla o quitarla según sea necesario.
                this.BitacoraTableAdapter.Fill(this.SIGVADataSet_Bitacora.Bitacora);
                ReportParameter p = new ReportParameter("Usuario", usuario);
                reportViewer1.LocalReport.SetParameters(p);
                this.reportViewer1.RefreshReport();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los datos del reporte",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
