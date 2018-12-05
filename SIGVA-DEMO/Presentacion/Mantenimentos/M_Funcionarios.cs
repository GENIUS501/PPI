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
        Neg_Funcionarios Nfuncionarios;
        Ent_Funcionarios Efuncionarios;
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
            try
            {
                if (this.Txt_Cedula.Text.Length > 7 && this.Txt_Cedula.Text.Length < 10)
                {
                    Int32 Agregar = 0;
                    Efuncionarios = new Ent_Funcionarios();
                    Nfuncionarios = new Neg_Funcionarios();
                    Efuncionarios.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                    Efuncionarios.Nombre = this.Txt_Nombre.Text.ToString();
                    Efuncionarios.Apellido1 = this.Txt_Apellido1.Text.ToString();
                    Efuncionarios.Apellido2 = this.Txt_Apellido2.Text.ToString();
                    Efuncionarios.Id_Departamento = Convert.ToInt32(this.Cbo_Departamento.SelectedValue.ToString());
                    Efuncionarios.Id_Puesto = Convert.ToInt32(this.Cbo_Puesto.SelectedValue.ToString());
                    Efuncionarios.Direccion = this.Txt_Direccion.Text.ToString();
                    Efuncionarios.Email = this.Txt_Email.Text.ToString();
                    Efuncionarios.Telefono = Convert.ToInt32(this.Txt_Telefono.Text.ToString());
                    Efuncionarios.Fecha_De_Ingreso = Convert.ToDateTime(this.Txt_Fecha_Ingreso.Text);
                    Efuncionarios.Fecha_de_Anualidad = Convert.ToDateTime(this.Txt_Fecha_Anualidad.Text);
                    Efuncionarios.Anos_Institucion_anterior = Convert.ToInt32(this.Txt_Anos_Institucion.Text.ToString());
                    Efuncionarios.Estatus = this.Cbo_Estatus.SelectedValue.ToString();
                    Agregar = Nfuncionarios.Actualizar(Efuncionarios);
                    if (Agregar > 0)
                    {
                        Calcular_Anualidad();
                        if (Convert.ToInt32(this.Txt_Anos_Institucion.Text)>0)
                        {
                            Calcular_Anteriores();
                        }
                        MessageBox.Show("Funcionario Modificado","Funcionario Modificado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar datos.", "Error al Modificar datos.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato de cedula incorrecto", "Formato de cedula incorrecto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Limpiar_Campos()
        {
            this.Txt_Cedula.Text = "";
            this.Txt_Nombre.Text = "";
            this.Txt_Apellido1.Text = "";
            this.Txt_Apellido2.Text = "";
            this.Txt_Direccion.Text = "";
            this.Txt_Email.Text = "";
            this.Txt_Fecha_Anualidad.Text = "";
            this.Txt_Fecha_Ingreso.Text = "";
            this.Txt_Telefono.Text = "";
            this.Txt_Anos_Institucion.Text = "";
            M_Funcionarios_Load(null, null);
        }

        private void Calcular_Anteriores()
        {
            try
            {
                int Ejecutar = 0;
                Ent_Anos_Institucion_Anterior Eano = new Ent_Anos_Institucion_Anterior();
                Neg_Anos_Institucion_Anterior Nano = new Neg_Anos_Institucion_Anterior();
                Eano.Cantidad_Dias = Convert.ToInt32(this.Txt_Anos_Institucion.Text.ToString()) * 12;
                Eano.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                Ejecutar = Nano.Actualizar(Eano);
                if (Ejecutar > 0)
                {

                }
                else
                {
                    MessageBox.Show("Error al calcular los años anteriores", "Error al calcular los años anteriores",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Calcular_Anualidad()
        {
            try
            {
                Ent_Anualidades Eanu = new Ent_Anualidades();
                Neg_Anualidades Nanu = new Neg_Anualidades();
                int contador = 1;
                int Anualidad = 0;
                int Ejecutar = 0;
                DateTime fecha_Anualidad;
                fecha_Anualidad = Convert.ToDateTime(this.Txt_Fecha_Anualidad.Text);
                DateTime fecha_fin = DateTime.Now;
                if (fecha_Anualidad.Year < fecha_fin.Year)
                {
                    while (fecha_Anualidad.Year <= fecha_fin.Year)
                    {

                        if (contador <= 4)
                        {
                            Anualidad = Anualidad + 3;
                        }
                        if (contador == 5)
                        {
                            Anualidad = Anualidad + 5;
                        }
                        if (contador >= 6 && contador < 10)
                        {
                            Anualidad = Anualidad + 7;
                        }
                        if (contador >= 10)
                        {
                            Anualidad = Anualidad + 15;
                        }
                        fecha_Anualidad = fecha_Anualidad.AddYears(1);
                        contador++;
                    }
                }
                Eanu.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                Eanu.Cantidad_Dias = Anualidad;
                Ejecutar = Nanu.Actualizar(Eanu);
                if (Ejecutar > 0)
                {

                }
                else
                {
                    MessageBox.Show("Error al Modificar las anualidades");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
                    this.Cbo_Departamento.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.Cbo_Estatus.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.Cbo_Puesto.DropDownStyle = ComboBoxStyle.DropDownList;
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
                if(Modo == "M")
                {
                    this.Txt_Cedula.Enabled = false;
                    this.Txt_Fecha_Ingreso.Enabled = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            try
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
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void Txt_Anos_Institucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            textbox_numer(e);
        }
        private void textbox_numer(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

    }
}
