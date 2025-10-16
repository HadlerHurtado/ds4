
public class Producto
{
    public decimal Precio { get; private set; }

    public Producto(decimal precio)
    {
        if (precio <= 0)
            throw new ArgumentException("El precio debe ser mayor a 0.");
        Precio = precio;
    }
}

public class Pago
{
    public string Forma { get; private set; }
    public string NumeroCuenta { get; private set; }

    public Pago(string forma)
    {
        if (forma != "efectivo" && forma != "tarjeta")
            throw new ArgumentException("Forma de pago no válida.");

        Forma = forma;
    }

    public void AsignarNumeroCuenta(string numeroCuenta)
    {
        if (Forma == "tarjeta")
        {
            if (numeroCuenta.Length == 16 && EsNumerico(numeroCuenta))
            {
                NumeroCuenta = numeroCuenta;
            }
            else
            {
                throw new ArgumentException("Número de cuenta inválido. Debe contener exactamente 16 dígitos.");
            }
        }
    }

    private bool EsNumerico(string texto)
    {
        foreach (char c in texto)
        {
            if (!char.IsDigit(c)) return false;
        }
        return true;
    }
}

public class Compra
{
    public Producto Producto { get; private set; }
    public Pago Pago { get; private set; }

    public Compra(Producto producto, Pago pago)
    {
        Producto = producto;
        Pago = pago;
    }

    public void MostrarResumen()
    {
        Console.WriteLine("\n--- Resumen de la compra ---");
        Console.WriteLine($"Precio: {Producto.Precio:C2}");
        Console.WriteLine($"Forma de pago: {Pago.Forma}");

        if (Pago.Forma == "tarjeta")
        {
            Console.WriteLine($"Número de cuenta: {Pago.NumeroCuenta}");
        }

        Console.WriteLine("\n✅ ¡Compra registrada con éxito!");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // --- Pedir datos al usuario ---
        decimal precio = 0;
        while (precio <= 0)
        {
            Console.Write("Ingrese el precio del producto (valor positivo): ");
            if (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.WriteLine("❌ El precio debe ser un número positivo.");
                precio = 0;
            }
        }

        string formaPago = "";
        while (formaPago != "efectivo" && formaPago != "tarjeta")
        {
            Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
            formaPago = Console.ReadLine().Trim().ToLower();

            if (formaPago != "efectivo" && formaPago != "tarjeta")
            {
                Console.WriteLine("❌ Forma de pago no válida.");
            }
        }

        // Crear objeto Producto
        Producto producto = new Producto(precio);

        // Crear objeto Pago
        Pago pago = new Pago(formaPago);

        if (formaPago == "tarjeta")
        {
            string numeroCuenta = "";
            while (true)
            {
                Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                numeroCuenta = Console.ReadLine().Trim();

                try
                {
                    pago.AsignarNumeroCuenta(numeroCuenta);
                    break; // correcto -> salimos
                }
                catch (Exception e)
                {
                    Console.WriteLine($"❌ {e.Message}");
                }
            }
        }

        // Crear la compra
        Compra compra = new Compra(producto, pago);

        // Mostrar resumen
        compra.MostrarResumen();
    }
}
