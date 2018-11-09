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
                                    new { Text = "Raso", Value = "2" }, 
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

        private void Cmd_Agregar_Click(object sender, EventArgs e)
        {
            if (Txt_Cedula.Text==""||Txt_Nombre.Text == ""||Txt_Apellido1.Text == ""||Txt_Apellido2.Text == ""||Txt_Clave.Text==""||Txt_Clave1.Text == "")
            {
                MessageBox.Show("No se ha llenado uno o varios campos");
            }
            else
            {
                try
                {
                    string c1 = Txt_Clave.Text.ToString();
                    string c2 = Txt_Clave1.Text.ToString();
                    if(c1==c2)
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
                        Eusuarios.Rol =Convert.ToInt32(this.Cbo_Rol.SelectedValue.ToString());
                        int ejecutar = Nusuarios.Insertar(Eusuarios);
                        if (ejecutar > 0) {
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar datos");
                        }
                        

                     }
                    else
                     {
                         MessageBox.Show("Las claves no coinciden");
                     }

                }catch(Exception ex)
                {
                    MessageBox.Show("Error al agregar : " + ex);
                }
            }
        }

        private void I_Usuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }
    }
}
