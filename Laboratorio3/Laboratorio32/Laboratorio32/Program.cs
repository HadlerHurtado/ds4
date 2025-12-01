   using System;

class Cliente
{

    // Método para calcular el área de un círculo
    public double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente();

        // Leer radio del círculo
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        // Calcular área
        double area = cliente.CalculoArea(radio);

        // Mostrar resultado
        Console.WriteLine($"El área del círculo con radio {0} es: ", area);
    }
}

