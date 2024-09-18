using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6;

interface IVehiculo
{
    void Encender();
    void Detener();
}

public abstract class Vehiculo : IVehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Color { get; set; }
    public string NumeroSerie { get; set; }
    protected int _velocidad;

    public Vehiculo(string marca, string modelo, string color, string numeroSerie)
    {
        Marca = marca;
        Modelo = modelo;
        Color = color;
        NumeroSerie = numeroSerie;
        _velocidad = 0;
    }

    public abstract void Acelerar();

    public abstract void Encender();

    public abstract void Detener();

}

public class Auto : Vehiculo
{
    public Auto(string marca, string modelo, string color, string numeroSerie)
        : base(marca, modelo, color, numeroSerie) { }

    public override void Encender()
    {
        Console.WriteLine("Encendiendo auto");
    }

    public override void Detener()
    {
        Console.WriteLine("Deteniendo auto");
        this._velocidad = 0;
    }

    public override void Acelerar()
    {
        this._velocidad += 10;
        Console.WriteLine($"Velocidad actual: {this._velocidad}");
    }

    
}
public class Moto : Vehiculo
{
    public Moto(string marca, string modelo, string color, string numeroSerie)
: base(marca, modelo, color, numeroSerie) { }

    public override void Acelerar()
    {
        this._velocidad += 5;
        Console.WriteLine($"Velocidad actual: {this._velocidad}");
    }

    public override void Detener()
    {
        Console.WriteLine("Deteniendo moto");
        this._velocidad = 0;
    }

    public override void Encender()
    {
        Console.WriteLine("Encendiendo moto");
    }
}
public static class EjemploClase
{
    public static void Correr()
    {
        Auto auto = new Auto("Ford", "K", "Negro", "123456");
        Moto moto = new Moto("Honda", "XR", "azul", "54231");

        auto.Encender();
        auto.Acelerar();
        auto.Acelerar();
        auto.Acelerar();
        auto.Detener();

        moto.Encender();
        moto.Acelerar();
        moto.Acelerar();
        moto.Acelerar();
        moto.Detener();
    }
}
