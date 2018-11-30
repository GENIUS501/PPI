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
    public partial class AVR_Personal : Form
    {
        #region "Propiedades"
        public Int32 Cedula { get; set; }
        public string Numero_Boleta { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_rige { get; set; }
        public DateTime Fecha_Vence { get; set; }
        public string Tipo_Accion { get; set; }
        public string Programa_actual { get; set; }
        public string Direccion_actual { get; set; }
        public string Clase_de_Puesto_actual { get; set; }
        public string Forma_de_pago_actualizar { get; set; }
        public string Hora_actual { get; set; }
        public string Salario_base_actual { get; set; }
        public string Aumentos_actual { get; set; }
        public string recargo_actual { get; set; }
        public string Programa_Propuesto { get; set; }
        public string Direccion_Propuesto { get; set; }
        public string Clase_de_propuesto { get; set; }
        public string Forma_pago_propuesto { get; set; }
        public string Horario_Propuesto { get;set;}
        public string Salario_Base_Propuesto { get; set; }
        public string Aumento_Propuesto { get; set; }
        public string Recargo_Propuesto { get; set; }
        public string Prohibicion_actual { get; set; }
        public string Sobre_sueldo_actual { get; set; }
        public string Salario_bruto_actual { get; set; }
        public string Sobre_sueldo_Puesto { get; set; }
        public string Salario_bruto_propuesto { get; set; }
        public string Explicacion { get; set; }
        public string Saldo_Vacaciones { get; set; }
        public string Periodo_Correspon { get; set; }
        public DateTime Fecha_Accion { get; set; }
        public string Prohibicion_propuesto { get; set; }
        #endregion
        public AVR_Personal()
        {
            InitializeComponent();
        }

        private void AVR_Personal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SIGVADataSet3.Anualidades' Puede moverla o quitarla según sea necesario.
            this.AnualidadesTableAdapter.Fill(this.SIGVADataSet3.Anualidades);
            ReportParameter[] parameters = new ReportParameter[33];
            parameters[0] = new ReportParameter("Cedula", Cedula.ToString());
            parameters[1] = new ReportParameter("Numero_Boleta", Numero_Boleta);
            parameters[2] = new ReportParameter("Nombre", Nombre);
            parameters[3] = new ReportParameter("Fecha_Ingreso", Fecha_Ingreso.ToString());
            parameters[4] = new ReportParameter("Fecha_Rige", Fecha_rige.ToString());
            parameters[5] = new ReportParameter("Fecha_Vence", Fecha_Vence.ToString());
            parameters[6] = new ReportParameter("Tipo_Accion", Tipo_Accion);
            parameters[7] = new ReportParameter("Programa_actual", Programa_actual);
            parameters[8] = new ReportParameter("Direccion_actual", Direccion_actual);
            parameters[9] = new ReportParameter("Clase_de_puesto_actual", Clase_de_Puesto_actual);
            parameters[10] = new ReportParameter("Forma_pago_actualizar", Forma_de_pago_actualizar);
            parameters[11] = new ReportParameter("Horario_actual", Hora_actual);
            parameters[12] = new ReportParameter("Salario_Base_Actual", Salario_base_actual);
            parameters[13] = new ReportParameter("Aumentos_Actual", Aumentos_actual);
            parameters[14] = new ReportParameter("Recargo_Actual", recargo_actual);
            parameters[15] = new ReportParameter("Programa_Propuesto", Programa_Propuesto);
            parameters[16] = new ReportParameter("Direccion_Propuesto", Direccion_Propuesto);
            parameters[17] = new ReportParameter("Clase_de_puesto_propuesto", Clase_de_propuesto);
            parameters[18] = new ReportParameter("Forma_pago_propuesto", Forma_pago_propuesto);
            parameters[19] = new ReportParameter("Horario_Propuesto", Horario_Propuesto);
            parameters[20] = new ReportParameter("Salario_Base_Propuesto", Salario_Base_Propuesto);
            parameters[21] = new ReportParameter("Aumento_Propuesto", Aumento_Propuesto);
            parameters[22] = new ReportParameter("Recargo_Propuesto", Recargo_Propuesto);
            parameters[23] = new ReportParameter("Prohibicion_actual", Prohibicion_actual);
            parameters[24] = new ReportParameter("Otros_Sobre_Sueldos_Actual", Sobre_sueldo_actual);
            parameters[25] = new ReportParameter("Salario_Bruto_Actual", Salario_bruto_actual);
            parameters[26] = new ReportParameter("Prohibicion_Propuesta", Prohibicion_propuesto);
            parameters[27] = new ReportParameter("Sobresueldos_Propuesto", Sobre_sueldo_Puesto);
            parameters[28] = new ReportParameter("Salario_Bruto_Propuesto", Salario_bruto_propuesto);
            parameters[29] = new ReportParameter("Explicacion", Explicacion);
            parameters[30] = new ReportParameter("Saldo_Vacaciones", Saldo_Vacaciones);
            parameters[31] = new ReportParameter("Periodo_Correspon", Periodo_Correspon);
            parameters[32] = new ReportParameter("Fecha_Accion", Fecha_Accion.ToString());
            reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
