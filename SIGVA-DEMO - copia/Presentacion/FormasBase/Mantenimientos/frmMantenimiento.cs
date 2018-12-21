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
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento()
        {
            InitializeComponent();
        }

        string vtitulo = "";
        string vDescripcion = "";
        bool mMostrarAgregar = true;
        bool mMostrarModificar = true;
        bool mMostrarEliminar = true;
        bool mMostrarConsultar = true;
        bool mMostrarImprimir = true;

        public ISynchronizeInvoke EventSyncInvoke { get; set; }
        public event EventHandler Evento_Aceptar;
        public event EventHandler Evento_Salir;

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

        public bool MostrarAgregar
        {

            get { return mMostrarAgregar; }
            set { 
                mMostrarAgregar = value;
                this.btnAceptar.Visible = value;
            }
        }

        public bool MostrarEliminar
        {
            get { return mMostrarEliminar; }
            set
            {
                mMostrarEliminar = value;
                this.btnEliminar.Visible = value;
            }
        }

        public bool MostrarConsultar
        {
            get { return mMostrarConsultar; }
            set
            {
                mMostrarConsultar = value;
                this.btnConsultar.Visible = value;
            }
        }

        public bool MostrarModificar
        {
            get { return mMostrarModificar; }
            set
            {
                mMostrarModificar = value;
                this.btnModificar.Visible = value;
            }
        }

        public bool MostrarImprimir
        {
            get { return mMostrarImprimir; }
            set
            {
                mMostrarImprimir = value;
                this.btnImprimir.Visible = value;
            }
        }

        #endregion

        private void RaiseTestEventoAceptar(EventArgs e, EventHandler pEvento)
        {
            try
            {
                //EventHandler EjecutarEvento = this.Evento_Aceptar;
                EventHandler EjecutarEvento = pEvento;

                if (EjecutarEvento == null)
                    return;

                if (EventSyncInvoke == null)
                    EjecutarEvento(this, e);
                else
                    EventSyncInvoke.Invoke(EjecutarEvento, new object[] { this, e });
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void RaiseTestEventoCerrar(EventArgs e)
        {
            try
            {
                EventHandler testEvent = this.Evento_Salir;

                // Check for no subscribers
                if (testEvent == null)
                    return;

                if (EventSyncInvoke == null)
                    testEvent(this, e);
                else
                    EventSyncInvoke.Invoke(testEvent, new object[] { this, e });
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Aceptar()
        {
            try
            {
                RaiseTestEventoAceptar(EventArgs.Empty, this.Evento_Aceptar);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Cerrar()
        {
            try
            {
                RaiseTestEventoAceptar(EventArgs.Empty, this.Evento_Salir);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name)
                {
                    case "btnAceptar":
                    case "btnModificar":
                    case "btnImprimir":
                        Aceptar();
                        break;
                    case "btnEliminar":
                        if (MessageBox.Show("El registro seleccionado va a ser eliminado.  ¿Desea Continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Aceptar();
                        }
                        break;
                    case "btnSalir":
                    case "btnConsultar":
                        Cerrar();
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
