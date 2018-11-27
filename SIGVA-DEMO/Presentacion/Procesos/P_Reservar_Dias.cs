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
                MessageBox.Show(ex.ToString());
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
                Nanualidades = new Neg_Anualidades();
                Eanualidades = new Ent_Anualidades();
                Nanos = new Neg_Anos_Institucion_Anterior();
                Eanos = new Ent_Anos_Institucion_Anterior();
                Decimal Resultado = 0;
                Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text));
                Eanos = Nanos.LeerAnos_Anterior(Convert.ToInt32(this.Txt_Cedula.Text));
                Decimal Anos_Anterior = Eanos.Cantidad_Dias;
                Decimal Anualidades = Eanualidades.Cantidad_Dias;
                Decimal Cantidad_dias = Convert.ToDecimal(this.Txt_Cantidad_Dias.Text);
                Int32 Ano = 0;
                DataTable Dias_Disponibles = new DataTable();
                Dias_Disponibles = Ndias_disponibles.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                for (int i = 0; i < Dias_Disponibles.Rows.Count; i++)
                {
                    if (Cantidad_dias <= Convert.ToDecimal(Dias_Disponibles.Rows[i]["Cantidad_Dias"].ToString()) && Cantidad_dias != -1)
                    {
                        Resultado = Cantidad_dias -Convert.ToDecimal(Dias_Disponibles.Rows[i]["Cantidad_Dias"].ToString());
                        Dias_Disponibles.Rows[i]["Cantidad_Dias"] = Convert.ToString(Convert.ToDecimal(Dias_Disponibles.Rows[i]["Cantidad_Dias"].ToString())-Cantidad_dias);
                        MessageBox.Show("Prueba: " + Dias_Disponibles.Rows[i]["Cantidad_Dias"].ToString());
                        Cantidad_dias = -1;
                    }
                    else
                    {
                        
                    }
                    //aca haces las operaciones con cada fila de la tabla ej:
                    //Dias_Disponibles.Rows[i]["Ano"].ToString()
                    //Resultado = Cantidad_dias -Convert.ToDecimal(Dias_Disponibles.Rows[i]["Cantidad_Dias"].ToString());
                    //MessageBox.Show("" + Ano);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Txt_Cedula.Text != "")
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
                    }else
                    {
                        MessageBox.Show("Error funcionario no existe");
                    }
                }
                else
                {
                    MessageBox.Show("Debe digitar la cedula.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
