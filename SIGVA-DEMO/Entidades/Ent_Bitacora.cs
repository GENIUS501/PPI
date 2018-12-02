using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Bitacora
    {
        #region"Propiedades"
        public Int32 Id_Movimiento { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public string Tabla { get; set; }
        public string Usuario { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Bitacora()
        {
            Id_Movimiento = 0;
            Accion = "";
            Tabla = "";
            Usuario = "";
        }
        #endregion

        #region "Constructor con parametros"
        public Ent_Bitacora(Int32 id_movimiento,string accion, DateTime fecha_hora,string tabla,string usuario)
        {
            Id_Movimiento = id_movimiento;
            Accion = accion;
            Fecha_Hora = fecha_hora;
            Tabla = tabla;
            Usuario = usuario;
        }
        #endregion
    }
}
