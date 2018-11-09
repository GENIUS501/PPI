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
            string usuario = Txt_Usuario.ToString();
            string password = Txt_Clave.ToString();
            string hash = Helper.EncodePassword(string.Concat(usuario, password));
            MessageBox.Show(hash);
            MenuPrincipal Ingresos = new MenuPrincipal();
            Ingresos.Show();
            
        }
    }
}
