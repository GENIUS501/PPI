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
using Negocios;
using Entidades;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class I_Puestos : frmIngresos
    {
        #region "Variables"
        Neg_Puestos Npuestos;
        Ent_Puestos Epuestos;
        #endregion
        public I_Puestos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void I_Puestos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
                DataTable dt = new DataTable();
                Npuestos = new Neg_Puestos();
                Epuestos = new Ent_Puestos();
                dt = Npuestos.Leer();
                Dat_Puestos.DataSource = dt;
                Cbo_Departamento.DropDownStyle = ComboBoxStyle.DropDownList; 
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmd_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Txt_Nombre_Puestos.Text != "")
                {
                    Int32 Agregar = 0;
                    Npuestos = new Neg_Puestos();
                    Epuestos = new Ent_Puestos();
                    Epuestos.Id_Departamento = Convert.ToInt32(this.Cbo_Departamento.SelectedValue.ToString());
                    Epuestos.Nombre_Puesto = this.Txt_Nombre_Puestos.Text.ToString();
                    Agregar = Npuestos.Insertar(Epuestos);
                    if (Agregar > 0)
                    {
                        MessageBox.Show("Puesto Agregado");
                        this.Txt_Nombre_Puestos.Text = "";
                        this.Cbo_Departamento.SelectedValue = 1;
                        I_Puestos_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar puesto", "Error al agregar puesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Error faltan campos por llenar", "Error faltan campos por llenar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    MessageBox.Show("El Puesto: " + this.Txt_Nombre_Puestos + " ya existe", "Puesto ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show(ex.ToString(), "Error al agregar puesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
