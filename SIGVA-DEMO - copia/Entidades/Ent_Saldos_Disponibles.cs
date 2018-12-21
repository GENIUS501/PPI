using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Saldos_Disponibles
    {
        #region "Propiedades"
        public Int32 Codigo_de_reporte { get; set; }
        public DateTime Fecha_Elaboracion { get; set; }
        public Int32 Cedula { get; set; }
        public Decimal Anualidades { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Saldos_Disponibles()
        {
            Codigo_de_reporte = 0;
            Cedula = 0;
            Anualidades = 0;
        }
        #endregion

        #region "Costructor con parametros"
        public Ent_Saldos_Disponibles(Int32 codigo_reporte,DateTime fecha_elaboracion,Int32 cedula,Decimal anualidades)
        {
            Codigo_de_reporte = codigo_reporte;
            Fecha_Elaboracion = fecha_elaboracion;
            Cedula = cedula;
            Anualidades = anualidades;
        }
        #endregion
    }
}
