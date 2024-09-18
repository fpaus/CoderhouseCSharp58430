using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.Clases
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Mail { get; set; }
        public int Edad { get; set; }
        public string Domicilio { get; set; }

        public Usuario(string nombre, string apellido, int dni, string mail, int edad, string domicilio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Mail = mail;
            this.Edad = edad;
            this.Domicilio = domicilio;
        }

        public bool EsMayorDeEdad()
        {
            return this.Edad >= 18;
        }

        public string NombreCompleto()
        {
            return $"Nombre: {Nombre} | Apellido: {Apellido}";
        }

        public void CambiarDireccion(string nuevaDireccion)
        {
            this.Domicilio = nuevaDireccion;
        }

    }
}
