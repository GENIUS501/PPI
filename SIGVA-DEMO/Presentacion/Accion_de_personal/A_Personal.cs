﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;
using Presentacion;

namespace Presentacion
{
    public partial class A_Personal : frmAccionpersonal
    {
        #region "Variables"
        Neg_Anos_Institucion_Anterior Nanos;
        Ent_Anos_Institucion_Anterior Eanos;
        Neg_Anualidades Nanualidades;
        Ent_Anualidades Eanulidades;
        Neg_Dias_Disponibles Ndias;
        Ent_Dias_Disponibles Edias;
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        #endregion
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
            try
            {
                if(Modo == "L")
                {
                    if (this.Txt_Cedula.Text != "")
                    {
                        Eanos = new Ent_Anos_Institucion_Anterior();
                        Nanos = new Neg_Anos_Institucion_Anterior();
                        Eanulidades = new Ent_Anualidades();
                        Nanualidades = new Neg_Anualidades();
                        Edias = new Ent_Dias_Disponibles();
                        Ndias = new Neg_Dias_Disponibles();
                        Eanos.Cantidad_Dias = 0;
                        Eanos.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                        Nanos.Actualizar(Eanos);
                        Eanulidades.Cantidad_Dias = 0;
                        Eanulidades.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                        Nanualidades.Actualizar(Eanulidades);
                        Edias.Cantidad_Dias = 0;
                        Edias.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                        Ndias.Actualizar2(Edias);
                    }
                    else
                    {
                        MessageBox.Show("Error debe digitar la cedula para liquidar el funcionario", "Error debe digitar la cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                Visor.Aumentos_actual = this.Txt_Aumentos_Actual.Text;
                Visor.recargo_actual = this.Txt_Recargo_actual.Text;
                Visor.Programa_Propuesto = this.Txt_Programa_Propuesto.Text;
                Visor.Direccion_Propuesto = this.Txt_Departamento_Propuesto.Text;
                Visor.Clase_de_propuesto = this.Txt_Puesto_Propuesto.Text;
                Visor.Forma_pago_propuesto = this.Txt_Forma_Pago_Propuesto.Text;
                Visor.Horario_Propuesto = this.Txt_Horario_Propuesto.Text;
                Visor.Salario_Base_Propuesto = this.Txt_Salario_Base_Propuesto.Text;
                Visor.Aumento_Propuesto = this.Txt_Aumento_Propuesto.Text;
                Visor.Recargo_Propuesto = this.Txt_Recargo_Propuesto.Text;
                Visor.Prohibicion_actual = this.Txt_Prohibicion_Actual.Text;
                Visor.Prohibicion_propuesto = this.Txt_Prohibicion_Propuesto.Text;
                Visor.Sobre_sueldo_actual = this.Txt_Otros_Actual.Text;
                Visor.Salario_bruto_actual = this.Txt_Salbruto_Actual.Text;
                Visor.Sobre_sueldo_actual = this.Txt_Otros_Actual.Text;
                Visor.Sobre_sueldo_Puesto = this.Txt_Otros_Propuesta.Text;
                Visor.Salario_bruto_propuesto = this.Txt_Salbruto_Propuesto.Text;
                Visor.Explicacion = this.txt_explicacion.Text;
                Visor.Saldo_Vacaciones = this.Txt_Saldos.Text;
                Visor.Periodo_Correspon = this.Txt_Periodos.Text;
                this.Txt_Fecha_Accion.Text = DateTime.Now.ToString();
                Visor.Fecha_Accion = Convert.ToDateTime(this.Txt_Fecha_Accion.Text);
                Visor.MdiParent = this.MdiParent;
                Visor.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al generar el reporte",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
