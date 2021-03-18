using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_de_Taller
{
    class Usuario
    {
        string nombre;
        string apellido;
        int telefono;
        string mail;
               

        public Usuario(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            string nombreCompleto = nombre + apellido;
        }
    }
}
