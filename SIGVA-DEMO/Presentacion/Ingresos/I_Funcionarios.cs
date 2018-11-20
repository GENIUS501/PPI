﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class I_Funcionarios : frmIngresos
    {
        #region "Variables"
        Neg_Funcionarios Nfuncionarios;
        Ent_Funcionarios Efuncionarios;
        Neg_Dias_Disponibles Ndias;
        Ent_Dias_Disponibles Edias;
        #endregion
        public I_Funcionarios()
        {
            InitializeComponent();
        }
        private void LlenarCombo()
        {
            try
            {
                Neg_Puestos Npuestos = new Neg_Puestos();
                DataTable Dt = new DataTable();
                Dt = Npuestos.Llenarcombobox(Convert.ToInt32(Cbo_Departamento.SelectedValue.ToString()));
                Cbo_Puesto.DataSource = Dt;
                Cbo_Puesto.DisplayMember = "Nombre_Puesto";
                Cbo_Puesto.ValueMember = "Id_Puesto";
            }catch(Exception ex)
            {
                 
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region "Funcionarios"
            Efuncionarios = new Ent_Funcionarios();
            Nfuncionarios = new Neg_Funcionarios();
            Efuncionarios.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
            Efuncionarios.Nombre = this.Txt_Nombre.Text.ToString();
            Efuncionarios.Apellido1 = this.Txt_Apellido1.Text.ToString();
            Efuncionarios.Apellido2 = this.Txt_Apellido2.Text.ToString();
            Efuncionarios.Id_Departamento = Convert.ToInt32(this.Cbo_Departamento.SelectedValue.ToString());

            #endregion
            #region "Calculo de dias"
            Ndias = new Neg_Dias_Disponibles();
            Edias = new Ent_Dias_Disponibles();
            DateTime fechaInicio = Txt_Fecha_Ingreso.Value.Date;
            DateTime fechaFinal = DateTime.Now;
            DateTime fecha_trabajo;

            TimeSpan tSpan = fechaFinal - fechaInicio;

            int dias = tSpan.Days;
            int Ano = 0;
            bool Salir = false;
            Int32 Ejecutar = 0;

            Decimal  res =  0.0333m;

            Decimal resa = dias * res;

            DateTime F  = fechaInicio.AddMonths(1);

            if (fechaInicio < fechaFinal)
            {
                fecha_trabajo = fechaInicio;
                for (int j = 0; fecha_trabajo > fechaFinal||Salir==true;j++ )
                {
                    fecha_trabajo = fecha_trabajo.AddYears(1);
                    Ano=fecha_trabajo.Year;
                    Edias.Ano = Ano;
                    Edias.Cantidad_Dias = 12;
                    Edias.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                    Ejecutar = Ndias.Insertar(Edias);
                    if(Ejecutar>0)
                    {

                    }
                    else
                    {
                        Salir = true;
                    }
                }
                
            }

            MessageBox.Show("Cantidad de dias:" + dias +" V: "+resa+"Ano despues:"+F);
            #endregion
        }


        private void I_Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
                LlenarCombo();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: "+ex);
            }

        }
    }
}
