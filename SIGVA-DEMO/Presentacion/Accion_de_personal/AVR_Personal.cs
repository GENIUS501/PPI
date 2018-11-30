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
        public string Prohibicion_actual { get; set; }
        public string Sobre_sueldo_Puesto { get; set; }
        public string Salario_bruto_propuesto { get; set; }
        public string Explicacion { get; set; }
        public string Saldo_Vacaciones { get; set; }
        public string Periodo_Correspon { get; set; }
        public string Fecha_Accion { get; set; }
        #endregion
        public AVR_Personal()
        {
            InitializeComponent();
        }

        private void AVR_Personal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
