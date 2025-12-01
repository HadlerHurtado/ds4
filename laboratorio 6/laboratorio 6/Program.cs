internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("DIgite el numero deseado");
        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("mp ha introducido un digito valido", ex.Message);
            num = -1;
        }
        Console.WriteLine(num);
    }
}