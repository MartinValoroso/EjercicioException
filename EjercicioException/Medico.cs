using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Medico
    {
        /*
         Id
        Nombre
        Apellido
        Domicilio
        Telefono
        Email
        Especialidad
        Matricula
         */
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }

        public Medico(string nombre)
        {
            if (Nombre.Length > 50)
            {
                throw new Exception("El nombre es demasiado extenso");
                 
                 
            }
           
            if (Nombre.Length < 1)
            {
                throw new Exception("El nombre es demasiado corto o el campo está vacío");

            }

            /* otra opción para un solo botón puede ser :
            if (Nombre.Length < 1 || Nombre.Lenght > 50) 
            {
               throw new Exception (“El nombre no puede estar vacío o superar los 50 carácteres”);
            }  */

            Nombre = nombre;

        }
    }
}