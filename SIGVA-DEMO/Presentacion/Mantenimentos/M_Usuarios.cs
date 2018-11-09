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
    public partial class M_Usuarios : frmMantenimiento
    {
        #region "Variables"
        private string vModo;
        private string vNombreBoton;
        //Entidades
        Ent_Usuarios Eusuarios;
        //Negocios
        Neg_Usuarios Nusuarios;
        #endregion
        public M_Usuarios()
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
        public string Codigo { get; set; }


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
        private void M_Usuario_Evento_Aceptar(object sender, EventArgs e)
        {
            if (Txt_Cedula.Text == "" || Txt_Nombre.Text == "" || Txt_Apellido1.Text == "" || Txt_Apellido2.Text == "" || Txt_Clave.Text == "")
            {
                MessageBox.Show("No se ha llenado uno o varios campos");
            }
            else
            {
                try 
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

                    switch(Modo)
                    {
                        case "M":
                            Int32 Filasafectadas = 0;
                            Filasafectadas = Nusuarios.Actualizar(Eusuarios);
                            if(Filasafectadas>0)
                            {
                                MessageBox.Show("Datos modificados exitosamente", "Modificacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }else
                            {
                                MessageBox.Show("Error al Modificar datos");
                            }
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error"+ex);
                }
            }
        }
        private void M_Usuario_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_Usuarios_Load(object sender, EventArgs e)
        {

            LlenarCombo();
            if (Modo == "M")
            {
                this.Txt_Cedula.Enabled = false;
                this.Txt_Usuario.Enabled = false;
            }
            if (Modo == "C")
            {
                this.Txt_Cedula.Enabled = false;
                this.Txt_Usuario.Enabled = false;
                this.Txt_Nombre.Enabled = false;
                this.Txt_Cedula.Enabled = false;
                this.Txt_Apellido1.Enabled = false;
                this.Txt_Apellido2.Enabled = false;
                this.Txt_Clave.Enabled = false;
                this.Cbo_Rol.Enabled = false;
            }
            Leer();
        }
        private void Leer()
        {
            Eusuarios = new Ent_Usuarios();
            Nusuarios = new Neg_Usuarios();

            try
            {
                Eusuarios = Nusuarios.LeerCodigoLlave(Codigo);

                if (Eusuarios != null)
                {
                    this.Txt_Cedula.Text = Convert.ToString(Eusuarios.Cedula);
                    this.Txt_Nombre.Text = Eusuarios.Nombre;
                    this.Txt_Apellido1.Text = Eusuarios.Apellido1;
                    this.Txt_Apellido2.Text = Eusuarios.Apellido2;
                    this.Txt_Usuario.Text = Eusuarios.Usuario;
                    this.Txt_Clave.Text = Eusuarios.Clave;
                    this.Cbo_Rol.SelectedValue = Eusuarios.Rol.ToString();
                }
                else
                {
                    MessageBox.Show("No se pudieron recuperar los datos", "Recuperación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }
    }
}
