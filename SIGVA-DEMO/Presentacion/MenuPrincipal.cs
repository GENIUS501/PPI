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
using Negocios;
using Entidades;


namespace Principal
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;


        public MenuPrincipal()
        {
            InitializeComponent();
        }

        #region "Propiedades"
        public Int32 Rol { get; set; }
        public Int32 Id_session { get; set; }
        #endregion

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            L_cliente L_Usuario = new L_cliente();
            L_Usuario.titulo = "Mantenimiento de Usuarios";
            L_Usuario.Descripcion = "SIGVA";
            L_Usuario.PieFormulario = "Mantenimiento de Usuarios";
            L_Usuario.MdiParent = this;
            L_Usuario.Show();

        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Funcionarios L_FUN = new L_Funcionarios();
            L_FUN.titulo = "Mantenimiento de Funcionarios";
            L_FUN.Descripcion = "SIGVA";
            L_FUN.PieFormulario = "Mantenimiento de Funcionarios";
            L_FUN.MdiParent = this;
            L_FUN.Show();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Usuarios In = new I_Usuarios();
            In.titulo = "Ingreso de Usuarios";
            In.Descripcion = "SIGVA";
            In.MdiParent = this;
            In.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Funcionarios Ingresos = new I_Funcionarios();
            Ingresos.titulo = "Ingreso de Funcionarios";
            Ingresos.Descripcion = "SIGVA";
            Ingresos.MdiParent = this;
            Ingresos.Show();
            //L_cliente ListaSistema = new L_cliente();
            //ListaSistema.titulo = "Matenimiento de clientes";
            //ListaSistema.Descripcion = "Sistema de facturacion y reporte";
            //ListaSistema.PieFormulario = "Matenimiento de clientes";
            //ListaSistema.MdiParent = this;
            //ListaSistema.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Departamentos ing = new I_Departamentos();
            ing.titulo = "Ingreso de Departamentos";
            ing.Descripcion = "SIGVA";
            ing.MdiParent = this;
            ing.Show();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I_Puestos ing = new I_Puestos();
            ing.titulo = "Ingreso de Puestos";
            ing.Descripcion = "SIGVA";
            ing.MdiParent = this;
            ing.Show();
        }

        private void mantenimientoDePuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Departamentos L_DEP = new L_Departamentos();
            L_DEP.titulo = "Mantenimiento de Departamentos";
            L_DEP.Descripcion = "SIGVA";
            L_DEP.PieFormulario = "Mantenimiento de Departamentos";
            L_DEP.MdiParent = this;
            L_DEP.Show();
        }

        private void mantenimientoDePuestosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            L_Puestos L_pue = new L_Puestos();
            L_pue.titulo = "Mantenimiento de Puestos";
            L_pue.Descripcion = "SIGVA";
            L_pue.PieFormulario = "Mantenimiento de Puestos";
            L_pue.MdiParent = this;
            L_pue.Show();
        }

        private void reservarDiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Reservar_Dias Proceso = new P_Reservar_Dias();
            Proceso.titulo = "Proceso de reservar dias";
            Proceso.Descripcion = "SIGVA";
            Proceso.MdiParent = this;
            Proceso.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Neg_Sessiones Nsessiones = new Neg_Sessiones();
            Ent_Sessiones Esessiones = new Ent_Sessiones();
            Int32 salida = 0;
            Esessiones.Id_Session = Id_session;
            Esessiones.Salida = DateTime.Now;
            salida = Nsessiones.Salir(Esessiones);
            Application.Exit();
        }

        private void reintegrarDiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Devlover_Dias Proceso = new P_Devlover_Dias();
            Proceso.titulo = "Proceso de reintegrar dias";
            Proceso.Descripcion = "SIGVA";
            Proceso.MdiParent = this;
            Proceso.Show();
        }

        private void saldosDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rpt_Saldos_Disponibles Reporte = new Rpt_Saldos_Disponibles();
            Reporte.titulo = "Saldos diponibles";
            Reporte.Descripcion = "SIGVA";
            Reporte.MdiParent = this;
            Reporte.Show();
        }

        private void rangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rpt_Rango Reporte = new Rpt_Rango();
            Reporte.titulo = "Por rango dado";
            Reporte.Descripcion = "SIGVA";
            Reporte.MdiParent = this;
            Reporte.Show();
        }

        private void totalDeVacacionesEnUnPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rpt_Rango_Fechas Reporte = new Rpt_Rango_Fechas();
            Reporte.titulo = "Total de vacaciones disponibles por periodo";
            Reporte.Descripcion = "SIGVA";
            Reporte.MdiParent = this;
            Reporte.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de a = new Acerca_de();
            a.MdiParent = this;
            a.Show();
        }

        private void sessionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_Sessiones ses = new A_Sessiones();
            ses.titulo = "Sessiones";
            ses.Descripcion = "SIGVA";
            ses.MdiParent = this;
            ses.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_Movimientos mov = new A_Movimientos();
            mov.titulo = "Movimientos";
            mov.Descripcion = "SIGVA";
            mov.MdiParent = this;
            mov.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if(Rol == 2)
            {
                archivoToolStripMenuItem.Visible = false;
                procesosToolStripMenuItem.Visible = false;
                reservarDiasToolStripMenuItem.Visible = false;
                reintegrarDiasToolStripMenuItem.Visible = false;
                auditoriaToolStripMenuItem1.Visible = false;
                liquidacionToolStripMenuItem.Visible = false;
            }
            if(Rol == 3)
            {
                archivoToolStripMenuItem.Visible = false;
                procesosToolStripMenuItem.Visible = false;
                reservarDiasToolStripMenuItem.Visible = false;
                reintegrarDiasToolStripMenuItem.Visible = false;
                liquidacionToolStripMenuItem.Visible = false;
            }
        }

        private void liquidacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_Personal A = new A_Personal();
            A.Modo = "L";
            A.titulo = "Accion de Personal";
            A.Descripcion = "SIGVA";
            A.MdiParent = this;
            A.Show();
            
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Neg_Sessiones Nsessiones = new Neg_Sessiones();
            Ent_Sessiones Esessiones = new Ent_Sessiones();
            Int32 salida = 0;
            Esessiones.Id_Session = Id_session;
            Esessiones.Salida = DateTime.Now;
            salida = Nsessiones.Salir(Esessiones);
            Application.Exit();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rpt_Ayuda ay = new Rpt_Ayuda();
            ay.MdiParent = this;
            ay.Show();
        }
    }
}
