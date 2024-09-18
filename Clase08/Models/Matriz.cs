namespace Clase8.Models;

public class Matriz
{
    private int[,] _matriz;

    private const int DIMENSION_FILA = 0;
    private const int DIMENSION_COLUMNA = 1;

    public Matriz(int filas, int columnas)
    {
        if(columnas > 0 && filas > 0)
        {
            _matriz = new int[filas, columnas];
        }
        else
        {
            _matriz = new int[2, 3];
        }
    }

    public override string ToString()
    {
        string matrizString = "[\n";
        for (int i = 0; i < _matriz.GetLength(DIMENSION_FILA) ; i++)
        {
            for (int j = 0; j < _matriz.GetLength(DIMENSION_COLUMNA); j++)
            {
                matrizString += _matriz[i, j] + " ";
            }
            matrizString += "\n";
        }
        matrizString += "]";
        return matrizString;
    }

    public void IngresarValor(int fila, int columna, int valor)
    {
        if(fila >= 0 
            && fila < _matriz.GetLength (DIMENSION_FILA)
            && columna >= 0 
            && columna < _matriz.GetLength(DIMENSION_COLUMNA)
            )
        {
            _matriz[fila, columna] = valor;
        }
    }

}
