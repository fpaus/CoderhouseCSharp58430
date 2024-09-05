using Clase6.Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.Interfaces;

interface I2DMedidasCalculables
{
    double Area();
    double Perimetro();
}

interface I3DMedidasCalculables
{
    double Volumen();
}


public class Circulo : I2DMedidasCalculables
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    public double Perimetro()
    {
        return 2 * Math.PI * Radio;
    }
}

class Rectángulo : I2DMedidasCalculables
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectángulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    public double Area()
    {
        return Base * Altura;
    }

    public double Perimetro()
    {
        return 2 * (Base + Altura);
    }
}

public class Cubo : I2DMedidasCalculables, I3DMedidasCalculables
{
    public double Lado { get; set; }

    public Cubo(double lado)
    {
        Lado = lado;
    }

    public double Area()
    {
        return 6 * Math.Pow(Lado, 2);
    }

    public double Perimetro()
    {
        return 12 * Lado;
    }

    public double Volumen()
    {
        return Math.Pow(Lado, 3);
    }
}
public static class EjemplosInterfaces
{
    public static void Correr()
    {
        Cubo cubo = new(1);
        Rectángulo rectángulo = new(2, 3);
        Circulo circulo = new(4);

        Console.WriteLine(
            $"Cubo: Area: {cubo.Area()}, Perimetro: {cubo.Perimetro()}, Volumen: {cubo.Volumen()}"
        );
        Console.WriteLine($"Rectángulo: Area: {rectángulo.Area()}, Perimetro: {rectángulo.Perimetro()}");
        Console.WriteLine($"Circulo: Area: {circulo.Area()}, Perimetro: {circulo.Perimetro()}");

        I2DMedidasCalculables unaFiguraGeometrica = new Circulo(3);
        unaFiguraGeometrica.Perimetro();
        unaFiguraGeometrica = new Rectángulo(5, 6);
        I2DMedidasCalculables otraFiguraGeometrica = new Circulo(5);
        I3DMedidasCalculables otroCubo = new Cubo(6);
        otroCubo.Volumen();

        I2DMedidasCalculables[] elementos = [
            cubo, rectángulo, circulo, unaFiguraGeometrica
            ];
        foreach(I2DMedidasCalculables elemento in elementos)
        {
            Console.WriteLine(elemento.Area());
        }
    }
}
