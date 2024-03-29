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
using Negocios;
using Entidades;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class I_Departamentos : frmIngresos
    {
        #region "Variables"
        Neg_Departamentos Ndepartamentos;
        Ent_Departamentos Edepartamentos;
        #endregion
        public I_Departamentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (this.Txt_Departamento.Text != "")
                {
                    Ndepartamentos = new Neg_Departamentos();
                    Edepartamentos = new Ent_Departamentos();
                    Edepartamentos.Nombre_Departamento = Txt_Departamento.Text.ToString();
                    Int32 Agregar = 0;
                    Agregar = Ndepartamentos.Insertar(Edepartamentos);
                    if (Agregar > 0)
                    {
                        MessageBox.Show("Departamento agregado exitosamente", "Departamento agregado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Txt_Departamento.Text = "";
                        I_Departamentos_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Departamento", "Error al agregar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error faltan campos por llenar", "Error faltan campos por llenar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("El departamento: "+this.Txt_Departamento.Text+" ya existe.","El departamento ya existe",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show(ex.ToString(), "Error al agregar el departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        private void I_Departamentos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
