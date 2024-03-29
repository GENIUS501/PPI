﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Negocios
{
   public class Neg_Dias_Reservados
    {
       #region "Insertar"
       public Int32 Insertar(Ent_Dias_Reservados Data)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Dias_Reservados IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Dias_Reservados();
               FilasAfectadas = IControlador.Insertar(Data);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           return FilasAfectadas;
       }
       #endregion

       #region "Devolucion"
       public Int32 Devolucion(Ent_Dias_Reservados Data)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Dias_Reservados IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Dias_Reservados();
               FilasAfectadas = IControlador.Devolucion(Data);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           return FilasAfectadas;
       }
       #endregion

       #region "Leer Especifico"
       public Ent_Dias_Reservados LeerCodigoLlave(Int32 pCodigo)
       {
           AccesoDatos.AD_Dias_Reservados IControlador;
           try
           {
               IControlador = new AccesoDatos.AD_Dias_Reservados();
               return IControlador.LeerCodigoLlave(pCodigo);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }
       }
       #endregion

       #region "Llenar datagrid reporte"
       public DataTable Llenardatagridreporte(DateTime Fecha_Ini,DateTime Fecha_Fin)
       {
           AccesoDatos.AD_Dias_Reservados IControlador;
           try
           {
               IControlador = new AccesoDatos.AD_Dias_Reservados();
               return IControlador.llenar_datagrid_reporte(Fecha_Ini,Fecha_Fin);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }
       }
       #endregion

       #region "Llenar datagrid"
       public DataTable Llenardatagrid(Int32 Cedula)
       {
           AccesoDatos.AD_Dias_Reservados IControlador;
           try
           {
               IControlador = new AccesoDatos.AD_Dias_Reservados();
               return IControlador.llenar_datagrid(Cedula);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }
       }
       #endregion

       #region "Eliminar"
       public Int32 Eliminar(Int32 Cedula)
       {
           Int32 FilasAfectadas = 0;
           AccesoDatos.AD_Dias_Reservados IControlador;

           try
           {
               IControlador = new AccesoDatos.AD_Dias_Reservados();
               FilasAfectadas = IControlador.Eliminar(Cedula);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           return FilasAfectadas;
       }
       #endregion
    }
}
