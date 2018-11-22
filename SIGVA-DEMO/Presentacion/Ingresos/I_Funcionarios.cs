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
    public partial class I_Funcionarios : frmIngresos
    {
        #region "Variables"
        Neg_Funcionarios Nfuncionarios;
        Ent_Funcionarios Efuncionarios;
        Neg_Dias_Disponibles Ndias;
        Ent_Dias_Disponibles Edias;
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
            try
            {
                LlenarCombo();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: "+ex);
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
                    MessageBox.Show("Erro faltan campos por llenar");
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
                                MessageBox.Show("Formato de correo incorrecto");
                            }
                        }else
                        {
                            MessageBox.Show("Formato de correo incorrecto");
                        }
                    }
                    else
                    {
                        Agregar_funcionario();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
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
                        MessageBox.Show("Funcionario Agregado");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar datos.");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de cedula incorrecto");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        private void Calcular_Anualidad()
        {

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
                MessageBox.Show("Error: "+ex);
            }
        }

        private void I_Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sIGVADataSet1Departamentos.DEPARTAMENTOS' Puede moverla o quitarla según sea necesario.
                this.dEPARTAMENTOSTableAdapter.Fill(this.sIGVADataSet1Departamentos.DEPARTAMENTOS);
                LlenarCombo();
                Rad_noposee.Checked = true;
                if (Rad_noposee.Checked == true)
                {
                    Txt_Cantidad_Anos.Enabled = false;
                    Txt_Cantidad_Anos.Text = Convert.ToString(0);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: "+ex);
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
