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
using System.Globalization;

namespace Presentacion
{
    public partial class P_Reservar_Dias : frmProcesos
    {
        #region "Variables"
        Ent_Anos_Institucion_Anterior Eanos;
        Neg_Anos_Institucion_Anterior Nanos;
        Ent_Funcionarios Efuncionarios;
        Neg_Funcionarios Nfuncionarios;
        Ent_Anualidades Eanualidades;
        Neg_Anualidades Nanualidades;
        Neg_Dias_Disponibles Ndias_disponibles;
        Ent_Dias_Disponibles Edias_disponibles;
        Ent_Dias_Reservados Edias_reservados;
        Neg_Dias_Reservados Ndias_reservados;
        #endregion
        public P_Reservar_Dias()
        {
            InitializeComponent();
        }

        private void P_Reservar_Dias_Load(object sender, EventArgs e)
        {
            try 
            {
                this.Txt_Nombre.Enabled = false;
                this.Txt_Apellido1.Enabled = false;
                this.Txt_Telefono.Enabled = false;
                this.Txt_Apellido2.Enabled = false;
                this.Txt_Fecha_Ingreso.Enabled = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmd_Reservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Txt_Cedula.Text != "")
                {
                    llenar2();
                }
                   
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Txt_Cedula.Text != "")
                {
                    llenar();
                }
                else
                {
                    MessageBox.Show("Debe digitar la cedula.", "Debe digitar la cedula",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void llenar()
        {
            try
            {
                Efuncionarios = new Ent_Funcionarios();
                Nfuncionarios = new Neg_Funcionarios();
                Ndias_disponibles = new Neg_Dias_Disponibles();
                Ndias_reservados = new Neg_Dias_Reservados();
                Nanualidades = new Neg_Anualidades();
                Eanualidades = new Ent_Anualidades();
                Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                Efuncionarios = Nfuncionarios.LeerCodigoLlave(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                if (Efuncionarios.Cedula > 0)
                {
                    this.Txt_Nombre.Text = Efuncionarios.Nombre;
                    this.Txt_Apellido1.Text = Efuncionarios.Apellido1;
                    this.Txt_Apellido2.Text = Efuncionarios.Apellido2;
                    this.Txt_Telefono.Text = Efuncionarios.Telefono.ToString();
                    this.Txt_Fecha_Ingreso.Text = Efuncionarios.Fecha_De_Ingreso.ToString();
                    this.Dat_Dias_Disponibles.DataSource = Ndias_disponibles.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                    this.Dat_Dias_Reservados.DataSource = Ndias_reservados.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                }
                else
                {
                    MessageBox.Show("Error funcionario no existe", "Error funcionario no existe",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenar2()
        {
            try
            {
                Efuncionarios = new Ent_Funcionarios();
                Nfuncionarios = new Neg_Funcionarios();
                Ndias_disponibles = new Neg_Dias_Disponibles();
                Ndias_reservados = new Neg_Dias_Reservados();
                Nanualidades = new Neg_Anualidades();
                Eanualidades = new Ent_Anualidades();
                Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                Efuncionarios = Nfuncionarios.LeerCodigoLlave(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                if (Efuncionarios.Cedula > 0)
                {
                    this.Txt_Nombre.Text = Efuncionarios.Nombre;
                    this.Txt_Apellido1.Text = Efuncionarios.Apellido1;
                    this.Txt_Apellido2.Text = Efuncionarios.Apellido2;
                    this.Txt_Telefono.Text = Efuncionarios.Telefono.ToString();
                    this.Txt_Fecha_Ingreso.Text = Efuncionarios.Fecha_De_Ingreso.ToString();
                    this.Dat_Dias_Disponibles.DataSource = Ndias_disponibles.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                    this.Dat_Dias_Reservados.DataSource = Ndias_reservados.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                    if (this.Txt_Cantidad_Dias.Text != "")
                    {
                        calcular();
                    }
                    else
                    {
                        MessageBox.Show("Debe indicar cuantos dias desea disfrutar", "Debe indicar cuantos dias desea disfrutar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Error funcionario no existe", "Error funcionario no existe",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void calcular()
        {
            try
            {
                Edias_reservados = new Ent_Dias_Reservados();
                Ndias_reservados = new Neg_Dias_Reservados();
                Nanualidades = new Neg_Anualidades();
                Eanualidades = new Ent_Anualidades();
                Nanos = new Neg_Anos_Institucion_Anterior();
                Eanos = new Ent_Anos_Institucion_Anterior();
                Ndias_disponibles = new Neg_Dias_Disponibles();
                Edias_disponibles = new Ent_Dias_Disponibles();
                Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text));
                Eanos = Nanos.LeerAnos_Anterior(Convert.ToInt32(this.Txt_Cedula.Text));
                Double Saldosa = Convert.ToDouble(Ndias_disponibles.LeerSaldo(Convert.ToInt32(this.Txt_Cedula.Text)));
                Double Anos_Anterior = Convert.ToDouble(Eanos.Cantidad_Dias);
                Double Anualidades = Convert.ToDouble(Eanualidades.Cantidad_Dias);
                Double Saldos = Anos_Anterior + Anualidades + Saldosa;
                Double Cantidad_dias = Convert.ToDouble(this.Txt_Cantidad_Dias.Text.ToString());
                if (Cantidad_dias <= Saldos)
                {
                    Double res = 0;
                    res = Cantidad_dias;
                    Int32 Var = Dat_Dias_Disponibles.Rows.Count;
                    if (Saldosa == 0)
                    {

                    }
                    else
                    {
                        for (int i = 0; i < Dat_Dias_Disponibles.Rows.Count; i++)
                        {
                            if (res <= Convert.ToDouble(Dat_Dias_Disponibles.Rows[i].Cells[1].Value) && res != 0)
                            {
                                //Dat_Dias_Disponibles.Rows[i].Cells[2].Value = Convert.ToString(Convert.ToDouble(Dat_Dias_Disponibles.Rows[i].Cells[1].Value.ToString()) - Cantidad_dias);

                                Edias_disponibles.Ano = Convert.ToInt32(Dat_Dias_Disponibles.Rows[i].Cells[0].Value.ToString());
                                Edias_disponibles.Cantidad_Dias = Convert.ToDecimal(Convert.ToDouble(Dat_Dias_Disponibles.Rows[i].Cells[1].Value.ToString()) - res);
                                Edias_disponibles.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                                Ndias_disponibles.Actualizar(Edias_disponibles);
                                res = 0;
                            }
                            else
                            {
                                if (res >= Convert.ToDouble(Dat_Dias_Disponibles.Rows[i].Cells[1].Value.ToString()) && res != 0)
                                {


                                    if (res == 0)
                                    {

                                    }
                                    if (res < 0)
                                    {

                                    }
                                    if (res > 0)
                                    {
                                        res = res - Convert.ToDouble(Dat_Dias_Disponibles.Rows[i].Cells[1].Value.ToString());
                                        Edias_disponibles.Ano = Convert.ToInt32(Dat_Dias_Disponibles.Rows[i].Cells[0].Value.ToString());
                                        Edias_disponibles.Cantidad_Dias = Convert.ToDecimal(Convert.ToDouble(Dat_Dias_Disponibles.Rows[i].Cells[1].Value.ToString()) - Convert.ToDouble(Dat_Dias_Disponibles.Rows[i].Cells[1].Value.ToString()));
                                        Edias_disponibles.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                                        Ndias_disponibles.Actualizar(Edias_disponibles);
                                    }
                                }
                            }
                        }
                    }
                    if (res > 0)
                    {
                        if (res >= Anualidades)
                        {
                            res = res - Anualidades;
                            Eanualidades.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                            Eanualidades.Cantidad_Dias = 0;
                            Nanualidades.Actualizar(Eanualidades);
                        }
                        else if (res < Anualidades)
                        {
                            Anualidades = Anualidades - res;
                            Eanualidades.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                            Eanualidades.Cantidad_Dias = Convert.ToDecimal(Anualidades);
                            Nanualidades.Actualizar(Eanualidades);
                            res = 0;
                        }

                        if (res > 0)
                        {
                            if (res > Anos_Anterior)
                            {
                                res = res - Anos_Anterior;
                                Eanos.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                                Eanos.Cantidad_Dias = 0;
                                Nanos.Actualizar(Eanos);
                            }
                            else if (res < Anos_Anterior)
                            {
                                Anos_Anterior = Anos_Anterior - res;
                                Eanos.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                                Eanos.Cantidad_Dias = Convert.ToDecimal(Anos_Anterior);
                                Nanos.Actualizar(Eanos);
                            }
                        }

                    }

                    Edias_reservados.Cedula = Convert.ToInt32(this.Txt_Cedula.Text.ToString());
                    Edias_reservados.Fecha_Inicial = Convert.ToDateTime(this.Txt_Fecha_Inicial.Text);
                    Edias_reservados.Fecha_Final = Convert.ToDateTime(this.Txt_Fecha_Final.Text);
                    Edias_reservados.Detalle = this.Txt_Detalle.Text;
                    Edias_reservados.Reservado_El = DateTime.Now;
                    Edias_reservados.Cantidad_dias = Convert.ToDecimal(Convert.ToDouble(this.Txt_Cantidad_Dias.Text));
                    Int32 Ejecutar = Ndias_reservados.Insertar(Edias_reservados);
                    if (Ejecutar > 0)
                    {
                        MessageBox.Show("Dias reservados correctamente", "Dias reservados correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        A_Personal frm = new A_Personal();
                        frm.MdiParent = this.MdiParent;
                        frm.Modo = "M";
                        frm.titulo = "Accion de Personal";
                        frm.Descripcion = "Accion de Personal";
                        frm.Show();
                        limpiarcampos();
                    }
                }
                else
                {
                    MessageBox.Show("No posee suficientes dias", "No posee suficientes dias",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                }

            private void limpiarcampos()
            {
                P_Reservar_Dias_Load(null, null);
                this.Txt_Apellido1.Text = "";
                this.Txt_Apellido2.Text = "";
                this.Txt_Nombre.Text = "";
                this.Txt_Detalle.Text = "";
                this.Txt_Cantidad_Dias.Text = "";
                this.Txt_Cedula.Text = "";
                this.Txt_Telefono.Text = "";
                this.Txt_Fecha_Final.Text = "";
                this.Txt_Fecha_Ingreso.Text = "";
                this.Txt_Fecha_Inicial.Text = "";
                this.Dat_Dias_Disponibles.DataSource = "";
                this.Dat_Dias_Reservados.DataSource = "";
            }

            private void Txt_Cantidad_Dias_KeyPress(object sender, KeyPressEventArgs e)
            {
                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

                if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }



