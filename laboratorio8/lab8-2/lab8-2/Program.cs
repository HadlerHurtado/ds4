
    public class Cuenta
    {
        private string idCuenta;
        public Cuenta( string prmtIdCuenta)
        {
            this.idCuenta=prmtIdCuenta;
            System.Console.WriteLine(
                "Cuenta.CalcularIntereses() efecuado para la cuenta {0}",
                this.idCuenta );
        }
        public virtual void CalcularIntereses()
    {
        System.Console.WriteLine (
            "Cuenta CalcularIntereses() efectuando paa la cuenta{0}",
            this.idCuenta );
    }
        public string getIdCuenta()
        {
            return this.idCuenta;
        }
    }
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmtIdCorriente) : base(prmtIdCorriente)
        {
        }
        public override void CalcularIntereses()
        {
            System.Console.WriteLine (
                "CuentaCorriente.CalcularIntereses() efectuando para "+
                "la cienta {0}", getIdCuenta());
        }
    }

    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine (
            "CuentaAhorro.CalcularIntereses() efectuando para"+
            "la cuenta {0}", getIdCuenta());
        }
    }
internal class Program
{
    private static void Main(string[] args)
    {
        const string CUENTA = "100";

            Cuenta cuenta = new Cuenta(CUENTA);
        CuentaCorriente cuentaCorriente= new CuentaCorriente(CUENTA);
        CuentaAhorro cuentaAhorro= new CuentaAhorro(CUENTA);
        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();
    }
}