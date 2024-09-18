using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.Herencia;

public class Persona
{
   protected long _dni;

   protected string _nombre;

   protected string _domicilioParticular;

   public Persona()
   {
       _dni = 0;
       _nombre = string.Empty;
       _domicilioParticular = string.Empty;
   }

   public Persona(long dni, string nombre, string domicilioParticular)
   {
       _dni = dni;
       _nombre = nombre;
       _domicilioParticular = domicilioParticular;
   }

    //Virtual
    public virtual void MostrarDatos()
    {
        Console.WriteLine("DNI: " + _dni);
        Console.WriteLine("Nombre: " + _nombre);
        Console.WriteLine("Domicilio Particular: " + _domicilioParticular);
    }

    public override string ToString()
    {
        return $"DNI: {_dni}, Nombre: {_nombre}, Domicilio Particular: {_domicilioParticular}";
    }

    public override bool Equals(object? obj)
    {
        if(obj == null) return false;
        Persona otraPersona = (Persona)obj;
        return this._dni == otraPersona._dni;
    }

    public static int EdadMayoriaDeEdad()
    {
        return 18;
    }
}

public class Empleado : Persona
{

    protected string _legajo;

    public Empleado() : base()
    {
        _legajo = string.Empty;
    }

    public Empleado(string legajo, long dni, string nombre, string domicilioParticular)
        : base(dni, nombre, domicilioParticular)
    {
        {
            _legajo = legajo;
        }
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine("Legajo: " + _legajo);
    }
}

public class Estudiante : Persona
{
    protected string _carrera;

    public Estudiante() : base()
    {
        _carrera = string.Empty;
    }

    public Estudiante(string carrera, long dni, string nombre, string domicilioParticular)
        : base(dni, nombre, domicilioParticular)
    {
        _carrera = carrera;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine("Carrera: " + _carrera);
    }
}

public static class EjemplosHerencia
{
    public static void Correr()
    {
        Persona persona1 = new Persona(12345678, "Juan Perez", "Calle 123");

        Estudiante estudiante1 = new Estudiante("CSharp", 87654321, "Maria Lopez", "Calle 456");

        Empleado empleado1 = new Empleado("1234", 12345678, "Juan Perez", "Calle 123");


        Persona persona2 = estudiante1;
        Persona persona3 = empleado1;
        Estudiante estudiante2 = (Estudiante)persona2;

        estudiante1.MostrarDatos();
        empleado1.MostrarDatos();

        persona2.MostrarDatos();

        if (persona1.Equals(empleado1))
        {
            Console.WriteLine($"El empleado {empleado1.ToString()} es igual a la persona {persona1.ToString()}");
        }
        else
        {
            Console.WriteLine(
                $"El empleado {empleado1.ToString()} no es la persona {persona1.ToString()}"
                );
        }
        Console.WriteLine(Persona.EdadMayoriaDeEdad());
    }
    
}