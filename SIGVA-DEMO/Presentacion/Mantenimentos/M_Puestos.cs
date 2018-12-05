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
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class M_Puestos : frmMantenimiento
    {
        #region "Variables"
        private string vModo;
        private string vNombreBoton;
        Ent_Puestos Epuestos;
        Neg_Puestos Npuestos;
        #endregion
        public M_Puestos()
        {
            InitializeComponent();
        }
        #region "Propiedades"

        public string Modo
        {
            //modos es para determinar que es lo que voy hacer, eliminar, modificar, etc
            get { return vModo; }
            set { vModo = value; }
        }

        public string NombreBoton
        {
            //modos es para determinar que es lo que voy hacer, eliminar, modificar, etc
            get { return vNombreBoton; }
            set { vNombreBoton = value; }
        }
        public Int32 Codigo { get; set; }


        #endregion
        private void M_Puestos_Evento_Aceptar(object sender, EventArgs e)
        {
            try
            {
                if (Modo == "M")
                {
                    Int32 Actualizar = 0;
                    Epuestos = new Ent_Puestos();
                    Npuestos = new Neg_Puestos();
                    Epuestos.Id_Departamento = Convert.ToInt32(this.Cbo_Departamento.SelectedValue.ToString());
                    Epuestos.Id_Puesto = Convert.ToInt32(this.Txt_Id_Puesto.Text.ToString());
                    Epuestos.Nombre_Puesto = this.Txt_Nombre_Puesto.Text.ToString();
                    Actualizar = Npuestos.Actualizar(Epuestos);
                    if (Actualizar > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente","Datos actualizados correctamente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos", "Error al actualizar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                if(Modo == "C")
                {
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al actualizar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void M_Puestos_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_Puestos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
                leer();
                this.Cbo_Departamento.DropDownStyle = ComboBoxStyle.DropDownList;
                if(Modo == "M")
                {
                    this.Txt_Id_Puesto.Enabled = false;
                }
                if(Modo == "C")
                {
                    this.Txt_Id_Puesto.Enabled = false;
                    this.Txt_Nombre_Puesto.Enabled = false;
                    this.Cbo_Departamento.Enabled = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al Cargar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void leer()
        {
            try
            {
                Epuestos = new Ent_Puestos();
                Npuestos = new Neg_Puestos();
                Epuestos = Npuestos.LeerCodigoLlave(Codigo);
                this.Txt_Id_Puesto.Text = Epuestos.Id_Puesto.ToString();
                this.Txt_Nombre_Puesto.Text = Epuestos.Nombre_Puesto;
                this.Cbo_Departamento.SelectedValue = Epuestos.Id_Departamento;

            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
