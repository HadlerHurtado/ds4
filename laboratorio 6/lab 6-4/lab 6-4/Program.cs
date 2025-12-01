internal class Program
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentOutOfRangeException("acceso negado - no cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("acceso concedido");
        }
    }
    private static void Main(string[] args)
    {
        checkAge(15);
    }
}