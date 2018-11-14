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
using Principal;
using System.Security.Cryptography;
using Entidades;
using Negocios;

namespace Presentacion
{

    public partial class Login : Form
    {
        Int32 Ingreso = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
               Entrar();
           }catch(Exception ex)
           {
               MessageBox.Show("Error al ingresar al sistema: " + ex);
           }

        }

        private void Entrar()
        {
            string usuario = Txt_Usuario.Text.ToString();
            string password = Txt_Clave.Text.ToString();
            string hash = Helper.EncodePassword(string.Concat(usuario, password));
            Ent_Usuarios Euser = new Ent_Usuarios();
            Neg_Usuarios Nuser = new Neg_Usuarios();
            Ent_Sessiones Esessiones = new Ent_Sessiones();
            Neg_Sessiones Nsessiones = new Neg_Sessiones();
            Euser = Nuser.Login(usuario, hash);

            if (Euser.Cedula != 0)
            {
                Esessiones.Usuario = Euser.Usuario;
                Esessiones.Ingreso = DateTime.Now;
                Ingreso = Nsessiones.Ingresar(Esessiones);
                if (Ingreso > 0)
                {
                    
                    MenuPrincipal Ingresos = new MenuPrincipal();
                    Ingresos.Rol = Euser.Rol;
                    Ingresos.Id_session = Ingreso;
                    Ingresos.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error desconocido");
                }
            }
            else
            {
                MessageBox.Show("Usuario o Clave invalido");
            }
        }

        private void Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    Entrar();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al ingresar al sistema: " + ex);
                }
                
            }
        }
    }
}
