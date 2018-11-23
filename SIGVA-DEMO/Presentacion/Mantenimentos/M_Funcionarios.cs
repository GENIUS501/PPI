using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;
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
                LlenarComboEstatus();
                    // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                    this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
                    Leer();
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

        private void LlenarComboEstatus()
        {
            try
            {
                this.Cbo_Estatus.DisplayMember = "Text";
                this.Cbo_Estatus.ValueMember = "Value";

                var items = new[] { 
                                    new { Text = "Activo", Value = "Activo" }, 
                                    new { Text = "Inactivo", Value = "Inactivo" }, 
                                    };
                this.Cbo_Estatus.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }
        private void LlenarCombo()
        {
            try
            {
                Neg_Puestos  Npuestos = new Neg_Puestos();
                DataTable Dt = new DataTable();
                Dt = Npuestos.Llenarcombobox(Convert.ToInt32(Cbo_Departamento.SelectedValue.ToString()));
                Cbo_Puesto.DataSource = Dt;
                Cbo_Puesto.DisplayMember = "Nombre_Puesto";
                Cbo_Puesto.ValueMember = "Id_Puesto";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        private void Leer()
        {
            Ent_Funcionarios Efuncionarios = new Ent_Funcionarios();
            Neg_Funcionarios Nfuncionarios = new Neg_Funcionarios();
            Efuncionarios = Nfuncionarios.LeerCodigoLlave(Codigo);
            this.Txt_Cedula.Text = Efuncionarios.Cedula.ToString();
            this.Txt_Nombre.Text = Efuncionarios.Nombre;
            this.Txt_Apellido1.Text = Efuncionarios.Apellido1;
            this.Txt_Apellido2.Text = Efuncionarios.Apellido2;
            this.Txt_Email.Text = Efuncionarios.Email;
            this.Txt_Direccion.Text = Efuncionarios.Direccion;
            this.Txt_Telefono.Text = Efuncionarios.Telefono.ToString();
            this.Cbo_Departamento.SelectedValue = Efuncionarios.Id_Departamento;
            LlenarCombo();
            this.Cbo_Puesto.SelectedValue = Efuncionarios.Id_Puesto;
            this.Cbo_Estatus.SelectedValue = Efuncionarios.Estatus;
            this.Txt_Anos_Institucion.Text = Efuncionarios.Anos_Institucion_anterior.ToString();
            this.Txt_Fecha_Ingreso.Text = Efuncionarios.Fecha_De_Ingreso.ToString();
            this.Txt_Fecha_Anualidad.Text = Efuncionarios.Fecha_de_Anualidad.ToString();
        }

    }
}
