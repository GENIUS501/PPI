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
    public partial class frmListaBase : Form
    {
        public frmListaBase()
        {
            InitializeComponent();
        }

        #region "Declaración de Variables"

        string vtitulo;
        string vDescripcion;
        string vPieFormulario;

        public ISynchronizeInvoke EventSyncInvoke { get; set; }
        public event EventHandler Evento_Agregar;
        public event EventHandler Evento_Modificar;
        public event EventHandler Evento_Borrar;
        public event EventHandler Evento_Consultar;
        public event EventHandler Evento_Cerrar;

        #endregion

        #region "Declaración de Propiedades"

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

        public string PieFormulario
        {
            get { return vPieFormulario; }
            set
            {
                vPieFormulario = value;
                this.lblPiePagina.Text = value;
                this.Text = value;
            }
        }

        #endregion

        #region "Declaración de Eventos"

        private void RaiseTestEvento(EventArgs e, EventHandler pEvento)
        {
            try
            {
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
                EventHandler testEvent = this.Evento_Cerrar;

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

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name)
                {
                    case "btnAgregar":
                        Agregar();
                        break;
                    case "btnModificar":
                        Modificar();
                        break;
                    case "btnConsultar":
                        Consultar();
                        break;
                    case "btnBorrar":
                        Borrar();
                        break;
                    case "btnCerrar":
                        Cerrar();
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region "Declaración de Métodos"

        public void Agregar()
        {
            try
            {
                RaiseTestEvento(EventArgs.Empty, this.Evento_Agregar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Modificar()
        {
            try
            {
                RaiseTestEvento(EventArgs.Empty, this.Evento_Modificar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Borrar()
        {
            try
            {
                RaiseTestEvento(EventArgs.Empty, this.Evento_Borrar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Consultar()
        {
            try
            {
                RaiseTestEvento(EventArgs.Empty, this.Evento_Consultar);
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
                RaiseTestEvento(EventArgs.Empty, this.Evento_Cerrar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        private void frmListaBase_Load(object sender, EventArgs e)
        {

        }

    }
}
