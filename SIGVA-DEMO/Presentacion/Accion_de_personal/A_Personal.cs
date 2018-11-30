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
    public partial class A_Personal : frmAccionpersonal
    {
        public A_Personal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmd_Generar_Click(object sender, EventArgs e)
        {
            AVR_Personal Visor = new AVR_Personal();
            Visor.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
            Visor.Numero_Boleta = this.Txt_Numero_Boleta.Text.ToString();
            Visor.Nombre = this.Txt_Nombre_Completo.Text.ToString();
            Visor.Fecha_Ingreso = Convert.ToDateTime(this.Txt_Fecha_Ingreso.Text);
            Visor.Fecha_rige = Convert.ToDateTime(this.Txt_Fecha_que_rige.Text);
            Visor.Fecha_Vence = Convert.ToDateTime(this.Txt_Fecha_que_vence.Text);
            Visor.Tipo_Accion = this.Txt_Tipo_de_accion.Text;
            Visor.Programa_actual = this.Txt_Programa_actual.Text;
            Visor.Direccion_actual = this.Txt_Departamento_Actual.Text;
            Visor.Clase_de_Puesto_actual = this.Txt_Puesto_Actual.Text;
            Visor.Forma_de_pago_actualizar = this.Txt_Forma_de_pago_actual.Text;
            Visor.Hora_actual = this.Txt_Horario_actual.Text;
            Visor.Salario_base_actual = this.Txt_Salario_Base_actual.Text;
        }

    }
}
