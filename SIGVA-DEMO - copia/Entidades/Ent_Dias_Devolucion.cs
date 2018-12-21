using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Dias_Devolucion
    {
        #region "Propiedades"
        public Int32 Id_Devolucion { get; set; }
        public DateTime Fecha_de_devolucion { get; set; }
        public string Detalle { get; set; }
        public Decimal Cantidad_dias {get;set;}
        public Int32 Id_Reservacion { get; set;}
        public Int32 Cedula { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Dias_Devolucion()
        {
            Id_Devolucion = 0;
            Detalle = "";
            Cantidad_dias = 0;
            Id_Reservacion = 0;
            Cedula = 0;
        }
        #endregion

        #region "Constructor con parametros"
        public Ent_Dias_Devolucion(Int32 id_devolucion,DateTime fecha_devolucion,string detalle,Decimal cantidad,Int32 id_reservacion,Int32 cedula)
        {
            Id_Devolucion = id_devolucion;
            Fecha_de_devolucion = fecha_devolucion;
            Detalle = detalle;
            Cantidad_dias = cantidad;
            Id_Reservacion = id_reservacion;
            Cedula = cedula;
        }
        #endregion
    }
}
