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
    public partial class Rpt_Ayuda : Form
    {
        public Rpt_Ayuda()
        {
            InitializeComponent();
        }

        private void Rpt_Ayuda_Load(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(
      System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            MessageBox.Show(path);
            linkLabel1.Links.Add(0,0,path+"/ayuda.pdf");
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
