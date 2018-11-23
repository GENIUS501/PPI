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
    public partial class M_Funcionarios : frmMantenimiento
    {
        private string vModo;
        private string vNombreBoton;
        public M_Funcionarios()
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
        private void M_Funcionarios_Evento_Aceptar(object sender, EventArgs e)
        {
          
        }

        private void M_Funcionarios_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                    // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                    this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
                    if(Modo == "C")
                    {
                        this.Txt_Cedula.Enabled = false;
                        this.Txt_Nombre.Enabled = false;
                        this.Txt_Apellido1.Enabled = false;
                        this.Txt_Apellido2.Enabled = false;
                        this.Txt_Telefono.Enabled = false;
                        this.Txt_Email.Enabled = false;
                        this.Txt_Direccion.Enabled = false;
                        this.Cbo_Departamento.Enabled = false;
                        this.Cbo_Puesto.Enabled = false;
                        this.Cbo_Estatus.Enabled = false;
                        this.Txt_Anos_Institucion.Enabled = false;
                        this.Txt_Fecha_Ingreso.Enabled = false;
                        this.Txt_Fecha_Anualidad.Enabled = false;
                    }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: "+ex);
            }
        }

        private void Leer()
        {

        }

    }
}
