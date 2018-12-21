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
    public partial class frmIngresos : Form
    {
        public frmIngresos()
        {
            InitializeComponent();
        }
        string vtitulo = "";
        string vDescripcion = "";
        #region "Propiedades"

        public string titulo
        {
            get { return vtitulo; }
            set
            {
                vtitulo = value;
                this.lblTitulo.Text = value;
                this.Text = value;
            }
        }

        public string Descripcion
        {
            get { return vDescripcion; }
            set
            {
                vDescripcion = value;
                this.lblDescripcion.Text = value;
                this.Text = value;
            }
        }
        #endregion
    }
}
