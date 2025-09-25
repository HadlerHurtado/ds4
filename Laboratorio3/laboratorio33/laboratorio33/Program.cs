using System;

class Cliente
{
    // Método para calcular el perímetro de un rectángulo
    public double CalculoPerimetroRectangulo(double lado1, double lado2)
    {
        return 2 * (lado1 + lado2);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente();

        Console.Write("Ingrese el valor del primer lado del rectángulo: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor del segundo lado del rectángulo: ");
        double lado2 = double.Parse(Console.ReadLine());

        double perimetro = cliente.CalculoPerimetroRectangulo(lado1, lado2);


        Console.WriteLine("El perímetro del rectángulo es: {0}", perimetro);
    }
}
