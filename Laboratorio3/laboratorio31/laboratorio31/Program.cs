internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero;
        double suma;

        Console.WriteLine("introduce el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Introduce el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Calcular calcular = new Calcular(primerNumero, segundoNumero);

        suma = calcular.Resultado();

        Console.WriteLine("el resultado (a+b) * (a-b) es: {0} ", suma);
    }
    public class Calcular
    {
        public double A { get; set; }
        public double B { get; set; }

        public Calcular(double a, double b)
        {
            A = a;
            B = b;
        }

        public double Resultado()
        {
            return (A + B) * (A - B);
        }


    }
}