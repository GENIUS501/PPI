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
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try{
            string usuario = Txt_Usuario.Text.ToString();
            string password = Txt_Clave.Text.ToString();
            string hash = Helper.EncodePassword(string.Concat(usuario, password));
            Ent_Usuarios Euser = new Ent_Usuarios();
            Neg_Usuarios Nuser = new Neg_Usuarios();
            Euser = Nuser.Login(usuario,hash);
            if(Euser.Cedula !=0)
            {
            MenuPrincipal Ingresos = new MenuPrincipal();
            Ingresos.Rol = Euser.Rol;
            Ingresos.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Clave invalido");
            }
           }catch(Exception ex)
           {
               MessageBox.Show("Error al ingresar al sistema: " + ex);
           }

        }
    }
}
