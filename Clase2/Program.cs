//short corto = -32000;
//ushort cortoPositivo = 64000;

//int entero = 2147483647;
//uint natural = 4000000000;

//long largo = 9223372036854775807;
//ulong largoPositivo = 9923372036854775807;

//Console.WriteLine($"El tamanio del tipo de dato short es {sizeof(short)}");
//Console.WriteLine($"El tamanio del tipo de dato ushort es {sizeof(ushort)}");
//Console.WriteLine($"El tamanio del tipo de dato int es {sizeof(int)}");
//Console.WriteLine($"El tamanio del tipo de dato uint es {sizeof(uint)}");
//Console.WriteLine($"El tamanio del tipo de dato long es {sizeof(long)}");
//Console.WriteLine($"El tamanio del tipo de dato ulong es {sizeof(ulong)}");


//float unDecimal = 123.34532f;
//double unDoble = 12345.12345;

//Console.WriteLine($"El tamanio del tipo de float long es {sizeof(float)}");
//Console.WriteLine($"El tamanio del tipo de double ulong es {sizeof(double)}");

////Console.WriteLine($"{0.3 - 0.2}");


//int a = 5;
//Console.WriteLine($"El valor de a es {a}");
//Console.WriteLine($"El valor de a al aplicar a++ es {a++}");
//Console.WriteLine($"El valor de a ahora es {a}");
//Console.WriteLine($"El valor de a al aplicar ++a es {++a}");
//Console.WriteLine($"El valor de a ahora es {a}");
//int b = 11;
//Console.WriteLine(b/a);
//double aa = 7;
//double bb = 11;
//Console.WriteLine(bb / aa);
//a = b;
//b = 32;
//Console.WriteLine($"a = {a}, b = {b}");

//Console.WriteLine("El valor de a es " + a.ToString() + " en este momento");
//Console.WriteLine("El valor de a es {0} en este momento, y el valor de b es {1}", a, b);

//Console.WriteLine($"El tamanio de un caracter (char) es de {sizeof(char)}");

//char x = 'A';
//char emoji = '\u263A';
//char japaneseKanji = '日';
//Console.WriteLine(emoji);
//Console.WriteLine(japaneseKanji);

//string cadena = "Hola Mundo";
//cadena = "Adios Mundo cruel";

//Console.WriteLine($"El tamanio de un booleano (bool) es de {sizeof(bool)}");


//// Condicionales
//short edadUsuario = 70;
//short edadMayorDeEdad = 18;
//short edadJubilatoria = 65;

//bool esMayorDeEdad = edadUsuario >= edadMayorDeEdad;
//bool estaJubilado = edadUsuario >= edadJubilatoria;

//if(esMayorDeEdad)
//{
//    if(estaJubilado)
//    {
//        Console.WriteLine("Si queres, podes dejar de trabajar");
//    }
//    Console.WriteLine("Felicidades, podes tener un trabajo en blanco");
//} else
//{
//    Console.WriteLine("Todavia no trabajes, termina el colegio");
//}

//Ejemplo en vivo

//int cantidadProductosVendidos;
//int cantidadDeProductosEnDeposito = 50;
//int stock;

//Console.WriteLine("Ingrese la cantidad de productos vendidos");
//cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());
//if(cantidadProductosVendidos > cantidadDeProductosEnDeposito)
//{
//    Console.WriteLine("No se pueden vender tantos productos");
//} 
//else
//{
//    stock = cantidadDeProductosEnDeposito - cantidadProductosVendidos;

//    if (stock == 0)
//    {
//        Console.WriteLine("Reponer stock de productos");
//        cantidadDeProductosEnDeposito = cantidadDeProductosEnDeposito + 10;
//        Console.WriteLine("Productos cargados al deposito");
//    }
//    else
//    {
//        Console.WriteLine($"Informar al área de ventas que quedan {stock} productos sin vender");
//    }
//}

//Console.WriteLine("Defina su categoria: ");
//char categoria = Console.ReadKey().KeyChar;
//Console.WriteLine();
//switch (categoria)
//{
//    case 'A':
//        Console.WriteLine("Sos un administrativo");
//        break;
//    case 'B':
//        Console.WriteLine("Sos un empleado profesional");
//        break;
//    case 'C':
//    case 'D':
//        Console.WriteLine("Empleado de maestranza");
//        break;
//    default:
//        Console.WriteLine("Sin categoria");
//        break;
//}

//Ejemplo en vivo
Console.WriteLine("BIENVENIDOS A LA UNIVERSIDAD CODERHOUSE!!");
Console.WriteLine("EL MEJOR LUGAR PARA ESTUDIAR DEL MUNDO!");

Console.Write("Ingrese la comision (A, B, C): ");
char comision = Console.ReadKey().KeyChar;
Console.WriteLine();
switch (comision)
{
    case 'A':
    case 'a':
        Console.WriteLine("Turno mañana");
        break;
    case 'B':
    case 'b':
        Console.WriteLine("Turno tarde");
        break;
    case 'C':
    case 'c':
        Console.WriteLine("Turno noche");
        break;
    default:
        Console.WriteLine("Sin turno fijo");
        break;
}

Console.WriteLine("Ingrese la nota del alumno: ");
int nota = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
Console.WriteLine();
if(nota > 7)
{
    Console.WriteLine("Promociona la materia");
}
else
{
    if (nota > 4)
    {
        Console.WriteLine("Regular");
    }
    else
    {
        Console.WriteLine("Desaprobó");
    }
}