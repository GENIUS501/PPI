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
        Ent_Puestos Epuestos;
        Neg_Puestos Npuestos;
        Ent_Departamentos Edepartamento;
        Neg_Departamentos Ndepartamento;
        Neg_Saldos_Disponibles Nsaldos;
        Ent_Saldos_Disponibles Esaldos;
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

        }

        private void Cmd_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Txt_Cedula.Text != "")
                {
                    Efuncionarios = new Ent_Funcionarios();
                    Nfuncionarios = new Neg_Funcionarios();
                    Nsaldos = new Neg_Saldos_Disponibles();
                    Nanualidades = new Neg_Anualidades();
                    Eanualidades = new Ent_Anualidades();
                    Ndias_disponibles = new Neg_Dias_Disponibles();
                    Ndias_reservados = new Neg_Dias_Reservados();
                    Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                    Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                    Efuncionarios = Nfuncionarios.LeerCodigoLlave(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
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
