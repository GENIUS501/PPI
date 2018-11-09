using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Ent_Usuarios
   {
       #region "Propiedades"
       public int Cedula { get; set; }
       public string Nombre { get; set; }
       public string Apellido1 {get;set;}
       public string Apellido2 {get;set;}
       public string Usuario {get; set;}
       public string Clave { get; set; }
       public int Rol { get; set; }

       #endregion
       #region"Constructor sin paramentros"

       public Ent_Usuarios()
       {
           Cedula = 0;
           Nombre = "";
           Apellido1 = "";
           Apellido2 = "";
           Usuario = "";
           Clave = "";
           Rol = 0;
       }
       #endregion
       #region "constructor con parametros
       public Ent_Usuarios(int cedula, string nombre, string apellido1,string apellido2, string usuario,string clave,int rol) 
       {
           this.Cedula = cedula;
           this.Nombre = nombre;
           this.Apellido1 = apellido1;
           this.Apellido2 = apellido2;
           this.Usuario = usuario;
           this.Clave = clave;
           this.Rol = rol;
       }
       #endregion
   }
}
