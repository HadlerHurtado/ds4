internal class Program
{
    public class Persona
    {
        //campo de cada onjeto persona que almacena su nombre
        public string Nombre;
        //campo de cada objeto persona que almacena su edad
        public int Edad;
        //campo de cada objeto persona que almacena su NIF
        public string NIF;

        void Cumpleaños()//Incrementa en uno de edad del objeto personal
        {
            Edad++;
        } 

        //contructor de persona
        public Persona (string nombre, int edad, string nif)
        {
            Nombre = nombre;
            Edad = edad;
            NIF = nif;
        }
    }

    public class Trabajador : Persona
    {
        //campo de cada objeto trabajador que almacena cuanto gana 
        public int Sueldo;

            public Trabajador(string nombre, int edad, string nif, int sueldo)
            :base(nombre, edad, nif)
        {//inicializamos cada trabajador en base al constructor de persona
            Sueldo = sueldo;
        }
    }

    public static void Main()
    {
        Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
        Console.WriteLine("Nombre="+ p.Nombre);
        Console.WriteLine("Edad=" + p.Edad);
        Console.WriteLine("NIF=" + p.NIF);
        Console.WriteLine("Sueldo=" + p.Sueldo);
        Console.ReadKey();
    }
}