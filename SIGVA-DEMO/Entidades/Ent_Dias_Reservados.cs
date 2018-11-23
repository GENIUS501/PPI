using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Dias_Reservados
    {
        #region "Propiedades"
        public Int32 Cedula { get; set; }
        public DateTime Fecha_Inicial { get; set; }
        public DateTime Fecha_Final { get; set; }
        public string Detalle { get; set; }
        public DateTime Reservado_El { get; set; }
        public Int32 Id_Reservacion { get; set; }
        public Decimal Cantidad_dias { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Dias_Reservados()
        {
            Cedula = 0;
            Detalle = "";
            Id_Reservacion = 0;
            Cantidad_dias = 0;
        }
        #endregion

        #region "Constructor con parametros"
        public Ent_Dias_Reservados(Int32 cedula,DateTime fecha_inicial,DateTime fecha_final,string detalle,DateTime reservado_el,Int32 id_reservacion,Decimal cantidad_dias)
        {
            Cedula = cedula;
            Fecha_Inicial = fecha_inicial;
            Fecha_Final = fecha_final;
            Detalle = detalle;
            Reservado_El = reservado_el;
            Id_Reservacion = id_reservacion;
            Cantidad_dias = cantidad_dias;
        }
        #endregion
    }
}
