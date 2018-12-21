using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Rpt_Base : Form
    {
        string vtitulo = "";
        string vDescripcion = "";
        public Rpt_Base()
        {
            InitializeComponent();
        }
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
