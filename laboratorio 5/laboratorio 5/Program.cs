internal class Program
{
    public class PruebaVector1
    {
        private int[] sueldos; //declaramos un vector
        public void Cargar()
        {
            sueldos = new int[6]; //inicializamos el vector en 5
            for (int f = 1; f <= 5; f++)
            {
                Console.WriteLine("ingrese sueldo del operario " + f + ": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);  //asignamos los 5 sueldos al vector
            }
        }
        //muestra los sueldo de los operarios en el vector sueldos [f]

        public void Imprimir()
        {
            Console.Write("los 5 sueldos de los aperarios \n");
            for (int f = 1; f <= 5; f++)
            {
                Console.WriteLine("[" + sueldos[f] + "]");
            }
            Console.ReadKey();
        }
    }
    //main principal
    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
}
