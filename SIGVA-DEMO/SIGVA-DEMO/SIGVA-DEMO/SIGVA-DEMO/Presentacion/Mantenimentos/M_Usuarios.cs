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

namespace Presentacion
{
    public partial class M_Usuarios : frmMantenimiento
    {
        private string vModo;
        private string vNombreBoton;
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
        private void M_Usuario_Evento_Aceptar(object sender, EventArgs e)
        {

        }
        private void M_Usuario_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
