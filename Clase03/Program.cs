//string cadena1 = "Hola";
//string cadena2 = "Mundo";

//string concatenacion = cadena1 + " " + cadena2;

//string cadenaVacia = string.Empty; // ""


//string nombrecompleto = string.Empty;
//Console.WriteLine("Cual es su primer nombre?");
//string primerNombre = Console.ReadLine();
//nombrecompleto = nombrecompleto + primerNombre;
//Console.WriteLine("Tiene segundo nombre?");
//string tieneSegundoNombre = Console.ReadLine();
//if(tieneSegundoNombre == "S")
//{
//    Console.WriteLine("Cual es su segundo nombre?");
//    string segundoNombre = Console.ReadLine();
//    nombrecompleto = nombrecompleto + " " + segundoNombre;
//}

//Console.WriteLine("Cual es su apellido?");
//string apellido = Console.ReadLine();
//nombrecompleto = nombrecompleto + " " + apellido;

//Console.WriteLine("Su nombre completo es " + nombrecompleto);


//Console.WriteLine(cadenaVacia);

//string unaCadenaNula = null; //<- NO tiene valor todavia, es null

//string unaCadenaVacia = string.Empty;

//if(unaCadenaNula == unaCadenaVacia)
//{
//    Console.WriteLine("me da lo mismo");
//}
//else
//{
//    Console.WriteLine("Hay que tener cuidado");
//}

//unaCadenaNula = unaCadenaNula + "otro valor";
//Console.WriteLine(unaCadenaNula);

//Length

//string cadena = "Hola Mundo";

//Console.WriteLine(cadena.Length);
//string unaCadenaVaciaConStringEmpty = string.Empty;
//string unaCadenaVacia = "";
//string unaCadenaNula = null;
//Console.WriteLine(unaCadenaNula.Length);


//Métodos
//string miNombre = "Fabrizio";
//string miNombrePeroGritado = miNombre.ToUpper();
//Console.WriteLine(miNombrePeroGritado);
//string miNombrePeroSusurrado = miNombre.ToLower();
//Console.WriteLine(miNombrePeroSusurrado);
//Console.WriteLine(miNombre);
//if(miNombrePeroGritado == miNombrePeroSusurrado)
//{
//    Console.WriteLine("Son lo mismo");
//}
//else
//{
//    Console.WriteLine("No es lo mismo gritar que susurrar");
//}


//to and from string

//int unNumero = Convert.ToInt32("25");

//Console.WriteLine(unNumero);

//unNumero = int.Parse("98");

//Console.WriteLine(unNumero);

//short edad = 32;

//bool esVacaciones = false;
//Console.WriteLine("Tengo " + edad.ToString() + esVacaciones.ToString() + " años, ya son vacaciones?" );


//Contains e Equals

//string cadena1 = "Hola Mundo";
//string cadena2 = "Mundo";
//bool estaContenido = cadena1.Contains(cadena2);
//if(estaContenido)
//{
//    Console.WriteLine("Cadena 2 está contenida en cadena 1");
//}

//string miNombre = "Fabrizio";
//string miNombrePeroGritado = miNombre.ToUpper();
//Console.WriteLine(miNombrePeroGritado);
//string miNombrePeroSusurrado = miNombre.ToLower();
//Console.WriteLine(miNombrePeroSusurrado);
//Console.WriteLine(miNombre);
//bool gritarYSusurrarEsLoMismo = miNombrePeroGritado.Equals(miNombrePeroSusurrado, StringComparison.InvariantCultureIgnoreCase);
//if (gritarYSusurrarEsLoMismo)
//{
//    Console.WriteLine("Son lo mismo");
//}
//else
//{
//    Console.WriteLine("No es lo mismo gritar que susurrar");
//}

//if (miNombrePeroGritado.ToUpper() == miNombrePeroSusurrado.ToUpper())
//{
//    Console.WriteLine("Son lo mismo");
//}
//else
//{
//    Console.WriteLine("No es lo mismo gritar que susurrar");
//}


//int unEntero = int.Parse("32");
//double unDoble = double.Parse("32.5");
//Console.WriteLine(unDoble);
//Console.WriteLine(unEntero);

//bool esEntero = int.TryParse("hola", out int valor);

//if(esEntero)
//{
//    Console.WriteLine(valor);
//}
//else
//{
//    Console.WriteLine("No se pudo parsear");
//}

//string cadenaVacia = string.Empty;
//string cadenaNula = null;
//string cadenaConValor = "Hola mundo";

//bool tieneValor = string.IsNullOrEmpty(cadenaConValor);
//Console.WriteLine(tieneValor);

//int x = 0;
//while(true)
//{
//    Console.WriteLine( x );
//    //x++;
//}

// Ejemplo while

//Console.WriteLine("Ingrese contraseña: ");
//string contraseña = Console.ReadLine();
//int posibilidades = 3;
//while(!contraseña.Equals("SuperSecreto") && posibilidades > 0)
//{
//    Console.WriteLine("Su contraseña es incorrecta, ingresela nuevamente.");
//    Console.WriteLine("Ingrese contraseña: ");
//    contraseña = Console.ReadLine();
//    posibilidades--;
//}
//if(posibilidades == 0)
//{
//    Console.WriteLine("Cuenta bloqueada");
//}
//else
//{
//    Console.WriteLine("Bienvenido!");
//}


//for (int i = 0; i < 10; i++ )
//{
//    Console.WriteLine( i );
//}

//int j = 0;
//while( j < 10 )
//{
//    Console.WriteLine( j );
//    j++;
//}

//Ejercicio promedios

//int i;
//int cantidadDeNotasACargar = 0;
//double promedioNotas =  0;
//double nota;
//double sumaNotas = 0;
//// promedio = sumaNotas / cantidadDeNotas

//Console.WriteLine("Ingrese la cantidad de notas a cargar");
//cantidadDeNotasACargar = int.Parse(Console.ReadLine());

//for(i = 1; i <= cantidadDeNotasACargar; i++)
//{
//    Console.WriteLine("Ingrese una nota:");
//    nota = double.Parse(Console.ReadLine());
//    sumaNotas = sumaNotas + nota;
//}
//promedioNotas = sumaNotas / cantidadDeNotasACargar;
//Console.WriteLine("El promedio de notas cargadas es " + promedioNotas);

//int i = 0;
//while (true)
//{
//    i++;
//    if(i == 489)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//    if(i == 500)
//    {
//        break;
//    }
//}

//for(int i = 0; i <= 500; i++)
//{
//    if(i != 489)
//    {
//        Console.WriteLine(i);
//    }
//}
int i = 501;
do
{
    i++;
    Console.WriteLine(i);
} while (i < 500);

//int i = 501;
//while (i < 500)
//{
//    i++;
//    Console.WriteLine(i);
//}