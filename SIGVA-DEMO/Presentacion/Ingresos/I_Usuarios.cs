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
    public partial class I_Usuarios : frmIngresos
    {
        public I_Usuarios()
        {
            InitializeComponent();
        }

        #region "Declaracion de variables"
        //Entidades
        Ent_Usuarios Eusuarios;
        //Negocios
        Neg_Usuarios Nusuarios;
        #endregion

        private void LlenarCombo()
        {
            try
            {
                this.Cbo_Rol.DisplayMember = "Text";
                this.Cbo_Rol.ValueMember = "Value";

                var items = new[] { 
                                    new { Text = "Administrador", Value = "1" }, 
                                    new { Text = "Consultor", Value = "2" }, 
                                    new { Text = "Auditor", Value = "3" }, 
                                    };
                this.Cbo_Rol.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            Txt_Cedula.Text="";
            Txt_Nombre.Text = "";
            Txt_Apellido1.Text = "";
            Txt_Apellido2.Text = "";
            Txt_Usuario.Text = "";
            Txt_Clave.Text="";
            Txt_Clave1.Text = "";
            Cbo_Rol.SelectedValue = "1";
        }
        private void Cmd_Agregar_Click(object sender, EventArgs e)
        {
            if (Txt_Usuario.Text == ""||Txt_Cedula.Text==""||Txt_Nombre.Text == ""||Txt_Apellido1.Text == ""||Txt_Apellido2.Text == ""||Txt_Clave.Text==""||Txt_Clave1.Text == "")
            {
                MessageBox.Show("Error faltan campos por llenar", "Error faltan campos por llenar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (this.Txt_Cedula.Text.Length > 7 && this.Txt_Cedula.Text.Length < 10)
                    {
                        string c1 = Txt_Clave.Text.ToString();
                        string c2 = Txt_Clave1.Text.ToString();
                        if (c1 == c2)
                        {
                            //Instanciacion
                            Eusuarios = new Ent_Usuarios();
                            Nusuarios = new Neg_Usuarios();
                            //Encripcion de la clave
                            string usuario = Txt_Usuario.Text.ToString();
                            string password = Txt_Clave.Text.ToString();
                            string hash = Helper.EncodePassword(string.Concat(usuario, password));

                            //Llenado de la clase contenedora
                            Eusuarios.Cedula = Convert.ToInt32(this.Txt_Cedula.Text);
                            Eusuarios.Nombre = this.Txt_Nombre.Text;
                            Eusuarios.Apellido1 = this.Txt_Apellido1.Text;
                            Eusuarios.Apellido2 = this.Txt_Apellido2.Text;
                            Eusuarios.Usuario = this.Txt_Usuario.Text;
                            Eusuarios.Clave = hash;
                            Eusuarios.Rol = Convert.ToInt32(this.Cbo_Rol.SelectedValue.ToString());
                            int ejecutar = Nusuarios.Insertar(Eusuarios);
                            if (ejecutar > 0)
                            {
                                MessageBox.Show("Usuario ingresado exitosamente", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("Error al ingresar datos", "Error al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Las claves no coinciden", "Las claves no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formarto de cedula incorrecto", "Formarto de cedula incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }catch( SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("El Usuario: "+this.Txt_Nombre.Text+" ya existe.", "El Usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString(),"Error al agregar usuario",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void I_Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                Cbo_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
                LlenarCombo();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error all cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
