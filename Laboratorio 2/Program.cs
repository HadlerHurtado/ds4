
using System; // Librería principal
namespace laboratorio2
{
class Program
{
    static void Main() 
    {
            //Asignando valor a variables estetica.
            MyClass.Valor = 1;

            Console.WriteLine(MyClass.Valor);

    }
}

public class MyClass
{
        //declarando variables de intancias en clase
        public static int Valor;
    
}
}