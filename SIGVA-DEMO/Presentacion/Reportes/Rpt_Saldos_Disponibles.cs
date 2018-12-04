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

namespace Presentacion
{
    public partial class Rpt_Saldos_Disponibles : Rpt_Base
    {
        #region "Variables"
        Ent_Puestos Epuestos;
        Neg_Puestos Npuestos;
        Ent_Departamentos Edepartamento;
        Neg_Departamentos Ndepartamento;
        Neg_Saldos_Disponibles Nsaldos;
        Ent_Funcionarios Efuncionarios;
        Neg_Funcionarios Nfuncionarios;
        Ent_Anualidades Eanualidades;
        Neg_Anualidades Nanualidades;
        Neg_Dias_Disponibles Ndias_disponibles;
        Neg_Dias_Reservados Ndias_reservados;
        Ent_Saldos_Disponibles Esaldos;
        #endregion
        public Rpt_Saldos_Disponibles()
        {
            InitializeComponent();
        }

        private void Rpt_Saldos_Disponibles_Load(object sender, EventArgs e)
        {
            try
            {
                this.Txt_Codigo_Reporte.Enabled = false;
                this.Txt_Nombre.Enabled = false;
                this.Txt_Puesto.Enabled = false;
                this.Txt_Departamento.Enabled = false;
                this.Txt_Anualidades.Enabled = false;
                this.Txt_Fecha_Elaboracion.Enabled = false;
                this.Txt_Fecha_Elaboracion.Text = DateTime.Now.ToString();
                this.Txt_Fecha_Ingreso.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: "+ex);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//Generar
            try
            {
                if (this.Txt_Cedula.Text != "")
                {
                    Efuncionarios = new Ent_Funcionarios();
                    Nfuncionarios = new Neg_Funcionarios();
                    Nsaldos = new Neg_Saldos_Disponibles();
                    Esaldos = new Ent_Saldos_Disponibles();
                    Nanualidades = new Neg_Anualidades();
                    Eanualidades = new Ent_Anualidades();
                    Edepartamento = new Ent_Departamentos();
                    Ndepartamento = new Neg_Departamentos();
                    Epuestos = new Ent_Puestos();
                    Npuestos = new Neg_Puestos();
                    Ndias_disponibles = new Neg_Dias_Disponibles();
                    Ndias_reservados = new Neg_Dias_Reservados();
                    Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                    this.Txt_Codigo_Reporte.Text = Convert.ToString(Nsaldos.numero_reporte(Convert.ToInt32(this.Txt_Cedula.Text.ToString())) + 1);
                    Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                    Efuncionarios = Nfuncionarios.LeerCodigoLlave(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                    Edepartamento = Ndepartamento.LeerCodigoLlave(Efuncionarios.Id_Departamento);
                    Epuestos = Npuestos.LeerCodigoLlave(Efuncionarios.Id_Puesto);
                    this.Txt_Nombre.Text = Efuncionarios.Nombre + Efuncionarios.Apellido1 + Efuncionarios.Apellido2;
                    this.Txt_Fecha_Ingreso.Text = Efuncionarios.Fecha_De_Ingreso.ToString();
                    this.Txt_Anualidades.Text = Eanualidades.Cantidad_Dias.ToString();
                    this.Txt_Puesto.Text = Epuestos.Nombre_Puesto;
                    this.Txt_Departamento.Text = Edepartamento.Nombre_Departamento;
                    this.Dat_Dias_Disponibles.DataSource = Ndias_disponibles.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                    this.Dat_Dias_Reservados.DataSource = Ndias_reservados.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                    Esaldos.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                    Esaldos.Fecha_Elaboracion = DateTime.Now;
                    Esaldos.Anualidades = Convert.ToInt32(this.Txt_Anualidades.Text);
                    Int32 Ejecutar = Nsaldos.Insertar(Esaldos);
                    if (Ejecutar > 0)
                    {
                        VR_Rpt_Saldos_Disponibles Visor = new VR_Rpt_Saldos_Disponibles();
                        Visor.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                        Visor.Codigo_Reporte = Convert.ToInt32(this.Txt_Codigo_Reporte.Text);
                        Visor.Anualidades = Convert.ToInt32(this.Txt_Anualidades.Text);
                        Visor.Nombre = this.Txt_Nombre.Text;
                        Visor.Departamento = this.Txt_Departamento.Text;
                        Visor.Puesto = this.Txt_Puesto.Text;
                        Visor.Fecha_Ingreso = Txt_Fecha_Ingreso.Text.ToString();
                        Visor.MdiParent = this.MdiParent;
                        Visor.Show();
                    }else
                    {
                        MessageBox.Show("Error al guardar el reporte intentelo de nuevo", "Error al guardar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Edepartamento = new Ent_Departamentos();
                    Ndepartamento = new Neg_Departamentos();
                    Epuestos = new Ent_Puestos();
                    Npuestos = new Neg_Puestos();
                    Ndias_disponibles = new Neg_Dias_Disponibles();
                    Ndias_reservados = new Neg_Dias_Reservados();
                    Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                    this.Txt_Codigo_Reporte.Text = Convert.ToString(Nsaldos.numero_reporte(Convert.ToInt32(this.Txt_Cedula.Text.ToString())) + 1);
                    Eanualidades = Nanualidades.LeerAnualidad(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                    Efuncionarios = Nfuncionarios.LeerCodigoLlave(Convert.ToInt32(this.Txt_Cedula.Text.ToString()));
                    Edepartamento = Ndepartamento.LeerCodigoLlave(Efuncionarios.Id_Departamento);
                    Epuestos = Npuestos.LeerCodigoLlave(Efuncionarios.Id_Puesto);
                    this.Txt_Nombre.Text = Efuncionarios.Nombre + Efuncionarios.Apellido1 + Efuncionarios.Apellido2;
                    this.Txt_Fecha_Ingreso.Text = Efuncionarios.Fecha_De_Ingreso.ToString();
                    this.Txt_Anualidades.Text = Eanualidades.Cantidad_Dias.ToString();
                    this.Txt_Puesto.Text = Epuestos.Nombre_Puesto;
                    this.Txt_Departamento.Text = Edepartamento.Nombre_Departamento;
                    this.Dat_Dias_Disponibles.DataSource = Ndias_disponibles.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                    this.Dat_Dias_Reservados.DataSource = Ndias_reservados.Llenardatagrid(Convert.ToInt32(this.Txt_Cedula.Text));
                }
                else
                {
                    MessageBox.Show("Debe digitar la cedula.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }
    }
}
