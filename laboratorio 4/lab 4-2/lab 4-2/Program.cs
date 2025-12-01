internal class Program
{
    private static void Main(string[] args)
    {
        int fac = 1, n;
        string linea;
        Console.WriteLine("ingrese un numero enterp: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);
        for (int i = 1; i < n; i++) {
            fac = fac + 1;
    }
        Console.WriteLine("la factoria es: " + fac);
        Console.ReadKey();
}