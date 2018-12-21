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
using Negocios;
using Entidades;

namespace Presentacion
{
    public partial class M_Departamentos : frmMantenimiento
    {
        #region "Variables"
        Ent_Departamentos Edepartamentos;
        Neg_Departamentos Ndepartamentos;
        private string vModo;
        private string vNombreBoton;
        #endregion
        public M_Departamentos()
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
        public int Codigo { get; set; }


        #endregion
        private void M_Departamento_Evento_Aceptar(object sender, EventArgs e)
        {
            try
            {
                if (Modo == "M")
                {
                    Int32 Actualizar = 0;
                    Edepartamentos = new Ent_Departamentos();
                    Ndepartamentos = new Neg_Departamentos();
                    Edepartamentos.Id_Departamamento = Convert.ToInt32(this.Txt_Id_Departamento.Text.ToString());
                    Edepartamentos.Nombre_Departamento = this.Txt_Nombre_Departamento.Text.ToString();
                    Actualizar = Ndepartamentos.Actualizar(Edepartamentos);
                    if (Actualizar > 0)
                    {
                        MessageBox.Show("Datos Actualizados", "Datos Actualizados",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos", "Error al actualizar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                if (Modo == "C")
                {
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al actualizar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void M_Departamento_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_Departamentos_Load(object sender, EventArgs e)
        {
            try
            {
                Leer();
                if (Modo == "C")
                {
                    this.Txt_Id_Departamento.Enabled = false;
                    this.Txt_Nombre_Departamento.Enabled = false;
                }
                if (Modo == "M")
                {
                    this.Txt_Id_Departamento.Enabled = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Leer()
        {
            try
            {
                Ent_Departamentos Edepartamentos = new Ent_Departamentos();
                Neg_Departamentos Ndepartamentos = new Neg_Departamentos();
                Edepartamentos = Ndepartamentos.LeerCodigoLlave(Codigo);
                this.Txt_Id_Departamento.Text = Edepartamentos.Id_Departamamento.ToString();
                this.Txt_Nombre_Departamento.Text = Edepartamentos.Nombre_Departamento.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error al cargar los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
