internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("algo slaio mal, valide el indice del arrglo");
        }
        finally
        {
            Console.WriteLine("continuacion de la aplicacion, luego del bloque try/catch");
        }
    }
}