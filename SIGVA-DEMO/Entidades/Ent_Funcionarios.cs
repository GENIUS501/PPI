using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ent_Funcionarios
    {
        #region "Propiedades"
        public Int32 Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public Int32 Id_Puesto {get;set;}
        public Int32 Id_Departamento {get;set;}
        public DateTime Fecha_De_Ingreso {get;set;}
        public string Direccion {get;set;}
        public Int32 Telefono {get;set;}
        public string Email {get;set;}
        public DateTime Fecha_de_Anualidad {get;set;}
        public string Estatus { get; set; }
        public Int32 Anos_Institucion_anterior { get; set; }
        #endregion

        #region "Constructor sin parametros"
        public Ent_Funcionarios()
        {
            Cedula = 0;
            Nombre = "";
            Apellido1 = "";
            Apellido2 = "";
            Id_Puesto = 0;
            Id_Departamento = 0;
            Direccion = "";
            Telefono = 0;
            Email = "";
            Estatus = "";
            Anos_Institucion_anterior = 0;
        }
        #endregion

        #region "Constructor con parametros"
        public Ent_Funcionarios(Int32 cedula,string nombre,string apellido1,string apellido2,Int32 id_puesto,Int32 id_departamento,DateTime fecha_ingreso,string direccion,Int32 telefono,string email,DateTime fecha_anualidad,string estatus,Int32 anos_institucion_anterior)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = Apellido2;
            Id_Puesto = id_puesto;
            Id_Departamento = id_departamento;
            Fecha_De_Ingreso = fecha_ingreso;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Fecha_de_Anualidad = fecha_anualidad;
            Estatus = estatus;
            Anos_Institucion_anterior = anos_institucion_anterior;
        }
        #endregion
    }
}
