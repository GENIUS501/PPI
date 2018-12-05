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
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class I_Funcionarios : frmIngresos
    {
        #region "Variables"
        Neg_Funcionarios Nfuncionarios;
        Ent_Funcionarios Efuncionarios;
        Neg_Dias_Disponibles Ndias;
        Ent_Dias_Disponibles Edias;
        Neg_Puestos Npuestos;
        DataTable Dt;
        DateTime fechaInicio;
        DateTime fechaFinal;
        DateTime fecha_trabajo;
        #endregion
        public I_Funcionarios()
        {
            InitializeComponent();
        }
        private void LlenarCombo()
        {
            try
            {
                Npuestos = new Neg_Puestos();
                Dt = new DataTable();
                Dt = Npuestos.Llenarcombobox(Convert.ToInt32(Cbo_Departamento.SelectedValue.ToString()));
                Cbo_Puesto.DataSource = Dt;
                Cbo_Puesto.DisplayMember = "Nombre_Puesto";
                Cbo_Puesto.ValueMember = "Id_Puesto";
            }catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarCombo();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.Txt_Nombre.Text.ToString()==""||this.Txt_Apellido1.Text.ToString()==""||this.Txt_Apellido2.Text.ToString()==""||this.Txt_Cedula.Text.ToString()==""||this.Txt_Direccion.Text.ToString()==""||this.Txt_Cedula.Text.ToString()=="")
                {
                    MessageBox.Show("Error faltan campos por llenar", "Error faltan campos por llenar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }else
                {
                    if(Txt_Email.Text.ToString()!="")
                    {
                        if(Txt_Email.Text.Contains("@"))
                        {
                            if(Txt_Email.Text.Contains(".com"))
                            {
                                Agregar_funcionario();
                            }else
                            {
                                MessageBox.Show("Formato de correo incorrecto", "Formato de correo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }else
                        {
                            MessageBox.Show("Formato de correo incorrecto", "Formato de correo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Agregar_funcionario();
                    }
                }
            }catch(SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("El funcionario: " + this.Txt_Nombre.Text + this.Txt_Apellido1.Text + this.Txt_Apellido2.Text + " ya existe.", "El funcionario ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show(ex.ToString(),"Error al agregar datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void Agregar_funcionario()
        {
            try
            {
                if (this.Txt_Cedula.Text.Length > 7 && this.Txt_Cedula.Text.Length < 10)
                {
                    Int32 Agregar = 0;
                    Efuncionarios = new Ent_Funcionarios();
                    Nfuncionarios = new Neg_Funcionarios();
                    Ndias = new Neg_Dias_Disponibles();
                    Edias = new Ent_Dias_Disponibles();
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
                    Efuncionarios.Anos_Institucion_anterior = Convert.ToInt32(this.Txt_Cantidad_Anos.Text.ToString());
                    Efuncionarios.Estatus = "Activo";
                    Agregar = Nfuncionarios.Insertar(Efuncionarios);
                    if (Agregar > 0)
                    {
                        Calcular_dias();
                        Calcular_Anualidad();
                        if (Rad_Posee.Checked == true)
                        {
                            Calcular_Anteriores();
                        }
                        MessageBox.Show("Funcionario Agregado", "Funcionario Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar_Campos();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el funcionario", "Error al agregar el funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato de cedula incorrecto", "Formato de cedula incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
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
            I_Funcionarios_Load(null, null);
        }
        private void Calcular_Anteriores()
        {
            try
            {
                int Ejecutar = 0;
                Ent_Anos_Institucion_Anterior Eano = new Ent_Anos_Institucion_Anterior();
                Neg_Anos_Institucion_Anterior Nano = new Neg_Anos_Institucion_Anterior();
                Eano.Cantidad_Dias = Convert.ToInt32(this.Txt_Cantidad_Anos.Text.ToString()) * 12;
                Eano.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                Ejecutar = Nano.Insertar(Eano);
                if (Ejecutar > 0)
                {

                }
                else
                {
                    MessageBox.Show("Error al calcular los años anteriores", "Error al calcular los años anteriores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al calcular los años anteriores", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        
                        if(contador<=4)
                        {
                            Anualidad = Anualidad + 3;
                        }
                        if(contador==5)
                        {
                            Anualidad = Anualidad + 5;
                        }
                        if(contador>=6 && contador<10)
                        {
                            Anualidad = Anualidad + 7;
                        }
                        if(contador>=10)
                        {
                            Anualidad = Anualidad + 15;
                        }
                       fecha_Anualidad = fecha_Anualidad.AddYears(1);
                        contador++;
                    }
                }
                Eanu.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                Eanu.Cantidad_Dias = Anualidad;
                Ejecutar = Nanu.Insertar(Eanu);
                if(Ejecutar>0)
                {

                }
                else
                {
                    MessageBox.Show("Error al agregar las anualidades", "Error al agregar las anualidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al agregar las anualidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Calcular_dias()
        {
            try
            {
                Ndias = new Neg_Dias_Disponibles();
                Edias = new Ent_Dias_Disponibles();
                fechaInicio = Convert.ToDateTime(Txt_Fecha_Ingreso.Value.Date);
                fechaFinal = DateTime.Now;
                //bool Salir = false;

                TimeSpan tSpan = fechaFinal - fechaInicio;

                int dias = tSpan.Days;
                
                Int32 Ejecutar = 0;

                Decimal res = 0.0333m;

                Decimal resa = dias * res;

             //   MessageBox.Show(""+resa);

                DateTime F = fechaInicio.AddMonths(1);

                if (fechaInicio < fechaFinal)
                {
                    fecha_trabajo = fechaInicio;
                    fecha_trabajo = fecha_trabajo.AddMonths(1);
                    while ( fecha_trabajo <= fechaFinal)
                    {
                        int Ano = 0;
                         
                        Ano = fecha_trabajo.Year;

                        fecha_trabajo = fecha_trabajo.AddMonths(1);

                        Edias = Ndias.LeerDia(Edias.Cedula,Ano);
                        if(Edias.Cantidad_Dias>0)
                        {
                            Edias.Ano = Ano;
                            Edias.Cantidad_Dias = Edias.Cantidad_Dias+1;
                            Edias.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                            Ejecutar = Ndias.Actualizar(Edias);
                            if (Ejecutar > 0)
                            {

                               // fecha_trabajo = fecha_trabajo.AddMonths(1);
                              //  fecha_trabajo.AddYears(1);
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar los dias calculados");
                            }
                        }else{
                            Edias.Ano = Ano;
                            Edias.Cantidad_Dias = 1;
                            Edias.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                            Ejecutar = Ndias.Insertar(Edias);
                            if (Ejecutar > 0)
                            {

                             //   fecha_trabajo = fecha_trabajo.AddMonths(1);
                              //  fecha_trabajo.AddYears(1);
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void I_Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
                LlenarCombo();
                this.Cbo_Departamento.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Cbo_Puesto.DropDownStyle = ComboBoxStyle.DropDownList;
                Rad_noposee.Checked = true;
                if (Rad_noposee.Checked == true)
                {
                    Txt_Cantidad_Anos.Enabled = false;
                    Txt_Cantidad_Anos.Text = Convert.ToString(0);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Rad_noposee_Click(object sender, EventArgs e)
        {
            this.Rad_noposee.Checked = true;
            Txt_Cantidad_Anos.Enabled = false;
            Txt_Cantidad_Anos.Text = Convert.ToString(0);
        }

        private void Rad_Posee_Click(object sender, EventArgs e)
        {
            this.Rad_Posee.Checked = true;
            Txt_Cantidad_Anos.Enabled = true;
        }
    }
}
