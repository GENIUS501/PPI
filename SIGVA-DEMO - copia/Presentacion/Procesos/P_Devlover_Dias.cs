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
using System.Globalization;

namespace Presentacion
{
    public partial class P_Devlover_Dias : frmProcesos
    {
        #region "Variables"
        Neg_Funcionarios Nfuncionarios;
        Ent_Funcionarios Efuncionarios;
        Neg_Dias_Devolucion Ndias_devolucion;
        Ent_Dias_Devolucion Edias_devolucion;
        Neg_Dias_Disponibles Ndias_disponibles;
        Neg_Dias_Reservados Ndias_reservados;
        Ent_Dias_Reservados Edias_reservados;
        Ent_Dias_Disponibles Edias_Disponibles;
        Neg_Anualidades Nanualidades;
        Ent_Anualidades Eanualidades;
        Neg_Anos_Institucion_Anterior Nanos;
        Ent_Anos_Institucion_Anterior Eanos;

        #endregion
        public P_Devlover_Dias()
        {
            InitializeComponent();
        }

        private void P_Devlover_Dias_Load(object sender, EventArgs e)
        {
            try
            {
                this.Txt_Telefono.Enabled = false;
                this.Txt_Nombre.Enabled = false;
                this.Txt_Apellido1.Enabled = false;
                this.Txt_Apellido2.Enabled = false;
                this.Txt_Fecha_Ingreso.Enabled = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al buscar datos del funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Buscar()
        {
            try
            {
                if (this.Txt_Cedula.Text != "")
                {
                    if (this.Txt_Cedula.Text.Length > 7 && this.Txt_Cedula.Text.Length < 10)
                    {
                        Efuncionarios = new Ent_Funcionarios();
                        Nfuncionarios = new Neg_Funcionarios();
                        Ndias_devolucion = new Neg_Dias_Devolucion();
                        Ndias_disponibles = new Neg_Dias_Disponibles();
                        Ndias_reservados = new Neg_Dias_Reservados();
                        Efuncionarios = Nfuncionarios.LeerCodigoLlave(Convert.ToInt32(this.Txt_Cedula.Text));
                        if (Efuncionarios.Cedula > 0)
                        {
                            this.Txt_Nombre.Text = Efuncionarios.Nombre;
                            this.Txt_Apellido1.Text = Efuncionarios.Apellido1;
                            this.Txt_Apellido2.Text = Efuncionarios.Apellido2;
                            this.Txt_Fecha_Ingreso.Text = Efuncionarios.Fecha_De_Ingreso.ToString();
                            this.Txt_Telefono.Text = Efuncionarios.Telefono.ToString();
                            this.Dat_Dias_Devolucion.DataSource = Ndias_devolucion.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                            this.Dat_Dias_Disponibles.DataSource = Ndias_disponibles.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                            this.Dat_Dias_Reservados.DataSource = Ndias_reservados.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                        }
                        else
                        {
                            MessageBox.Show("Funcionario no encontrado", "Funcionario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error en formato de cedula", "Error en formato de cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error debe digitar la cedula", "Error debe digitar la cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al devolver dias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dat_Dias_Reservados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Txt_Numero_Boleta.Text = Dat_Dias_Reservados.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Cmd_Devolver_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
                Devolver();
                MessageBox.Show("Dias devueltos exitosamente", "Dias devueltos exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiarcampos();
                A_Personal frm = new A_Personal();
                frm.Modo = "M";
                frm.titulo = "Accion de Personal";
                frm.Descripcion = "Accion de Personal";
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al devolver dias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiarcampos()
        {
            this.Txt_Apellido1.Text = "";
            this.Txt_Apellido2.Text = "";
            this.Txt_Cantidad_Dias.Text = "";
            this.Txt_Telefono.Text = "";
            this.Txt_Nombre.Text = "";
            this.Txt_Numero_Boleta.Text = "";
            this.Txt_Fecha_Ingreso.Text = "";
            this.Txt_Cedula.Text = "";
            this.Dat_Dias_Devolucion.DataSource = "";
            this.Dat_Dias_Disponibles.DataSource = "";
            this.Dat_Dias_Reservados.DataSource = "";
        }

        private void Devolver()
        {
            Edias_reservados = new Ent_Dias_Reservados();
            try
            {
                if (this.Txt_Cantidad_Dias.Text != "")
                {
                    if (this.Txt_Numero_Boleta.Text != "")
                    {
                        Edias_reservados = Ndias_reservados.LeerCodigoLlave(Convert.ToInt32(this.Txt_Numero_Boleta.Text));
                        if (Edias_reservados.Id_Reservacion != 0)
                        {
                            if(Convert.ToDouble(Edias_reservados.Cantidad_dias)>=Convert.ToDouble(this.Txt_Cantidad_Dias.Text))
                            {
                                Calcular();
                            }else
                            {
                                MessageBox.Show("La cantidad de dias digitados es mayor a los que posee la boleta", "La cantidad de dias digitados es mayor a los que posee la boleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Boleta no existe", "Boleta no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error debe indicar el numero de boleta", "Error debe indicar el numero de boleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error debe indicar la cantidad de dias a devolver", "Error debe indicar la cantidad de dias a devolver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al devolver dias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calcular()
        {
            try
            {
                Edias_Disponibles = new Ent_Dias_Disponibles();
                Eanualidades = new Ent_Anualidades();
                Nanualidades = new Neg_Anualidades();
                Eanos = new Ent_Anos_Institucion_Anterior();
                Nanos = new Neg_Anos_Institucion_Anterior();
                Ndias_disponibles = new Neg_Dias_Disponibles();
                Edias_devolucion = new Ent_Dias_Devolucion();
                Ndias_devolucion = new Neg_Dias_Devolucion();
                Edias_reservados = new Ent_Dias_Reservados();
                Ndias_reservados = new Neg_Dias_Reservados();
                Double Cantidad_dias = Convert.ToDouble(this.Txt_Cantidad_Dias.Text);
                for (int i = 0; Cantidad_dias > 0; i++)
                {
                    Edias_Disponibles = Ndias_disponibles.Leerespecial(Convert.ToInt32(this.Txt_Cedula.Text));
                    if (Edias_Disponibles.Ano!=0)
                    {
                        Edias_Disponibles = Ndias_disponibles.Leerespecial(Convert.ToInt32(this.Txt_Cedula.Text));
                        for (int e = 0; Edias_Disponibles.Cantidad_Dias < 12 && Edias_Disponibles.Cantidad_Dias>-1 && Cantidad_dias>0 && Edias_Disponibles.Ano>0; e++)
                        {
                            Cantidad_dias = Cantidad_dias - 0.1;
                            if (Cantidad_dias <= 0)
                            {

                            }
                            else
                            {
                                Edias_Disponibles.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                                Edias_Disponibles.Cantidad_Dias = Convert.ToDecimal(Convert.ToDouble(Edias_Disponibles.Cantidad_Dias) + 0.1);
                                Ndias_disponibles.Actualizar(Edias_Disponibles);
                            }
                        }
                    }
                    else
                    {
                        if (Cantidad_dias <= 0)
                        {

                        }
                        else
                        {
                            Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text));
                            Eanualidades.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                            Eanualidades.Cantidad_Dias = Convert.ToDecimal(Convert.ToDouble(Eanualidades.Cantidad_Dias) + Cantidad_dias);
                            Nanualidades.Actualizar(Eanualidades);
                            Cantidad_dias = Cantidad_dias - Cantidad_dias;
                        }
                    }
                }
                Edias_reservados = Ndias_reservados.LeerCodigoLlave(Convert.ToInt32(this.Txt_Numero_Boleta.Text));
                Edias_reservados.Cantidad_dias = Convert.ToDecimal(Convert.ToDouble(Edias_reservados.Cantidad_dias)-Convert.ToDouble(this.Txt_Cantidad_Dias.Text));
                Edias_reservados.Id_Reservacion = Convert.ToInt32(this.Txt_Numero_Boleta.Text);
                Ndias_reservados.Devolucion(Edias_reservados);
                Edias_devolucion.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                Edias_devolucion.Cantidad_dias = Convert.ToDecimal(this.Txt_Cantidad_Dias.Text);
                Edias_devolucion.Detalle = this.Txt_Detalle.Text;
                Edias_devolucion.Fecha_de_devolucion = DateTime.Now;
                Edias_devolucion.Id_Reservacion = Convert.ToInt32(this.Txt_Numero_Boleta.Text);
                Ndias_devolucion.Insertar(Edias_devolucion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al devolver dias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Txt_Numero_Boleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            textbox_numer(e);
        }
    }
}
