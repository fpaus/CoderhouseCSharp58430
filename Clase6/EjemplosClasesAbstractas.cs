using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.Abstract;

public abstract class FiguraGeometrica : I2DMedidasCalculables
{
    public abstract double Area();

    public abstract double Perimetro();
}

interface I2DMedidasCalculables
{
    double Area();
    double Perimetro();
}

interface I3DMedidasCalculables
{
    double Volumen();
}

public class Circulo : FiguraGeometrica
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }
    public override double Area()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    public override double Perimetro()
    {
        return 2 * Math.PI * Radio;
    }
}


class Rectángulo : FiguraGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectángulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    public override double Area()
    {
        return Base * Altura;
    }

    public override double Perimetro()
    {
        return 2 * (Base + Altura);
    }
}

public class Cubo : FiguraGeometrica, I3DMedidasCalculables
{
    public double Lado { get; set; }

    public Cubo(double lado)
    {
        Lado = lado;
    }

    public override double Area()
    {
        return 6 * Math.Pow(Lado, 2);
    }

    public override double Perimetro()
    {
        return 12 * Lado;
    }

    public double Volumen()
    {
        return Math.Pow(Lado, 3);
    }
}

public static class EjemplosClasesAbstractas
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
    }
}
