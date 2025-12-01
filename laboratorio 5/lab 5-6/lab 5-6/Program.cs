using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño de la matriz (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        int filaCentral = n / 2;

        for (int j = 0; j < n; j++)
        {
            matriz[filaCentral, j] = j + 1;
        }

        Console.WriteLine("\nMatriz resultante:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}