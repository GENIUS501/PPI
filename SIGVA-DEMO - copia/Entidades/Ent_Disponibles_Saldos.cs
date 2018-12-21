using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Disponibles_Saldos
    {
        #region "Propiedades"
        public Int32 Codigo_Reporte { get; set; }
        public Int32 Ano { get; set; }
        public Decimal Cantidad_Dias { get; set; }
        public Int32 Cedula { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Disponibles_Saldos()
        {
            Codigo_Reporte = 0;
            Ano = 0;
            Cantidad_Dias = 0;
            Cedula = 0;
        }
        #endregion

        #region "Constructor con parametros"
        public Ent_Disponibles_Saldos(Int32 codigo_reporte,Int32 ano, Decimal cantidad_dias,Int32 cedula)
        {
            Codigo_Reporte = codigo_reporte;
            Ano = ano;
            Cantidad_Dias = cantidad_dias;
            Cedula = cedula;
        }
        #endregion

    }
}
