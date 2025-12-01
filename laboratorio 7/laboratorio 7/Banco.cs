using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_7
{
    internal class Banco
    {
        private Cliente Cliente1, Cliente2,Cliente3;
        public Banco()
        {
            Cliente1 = new Cliente("Yhoanas");
            Cliente2 = new Cliente("Ana");
            Cliente3 = new Cliente("Pedro");
        }
        public void Operador()
        {
            Cliente1.Depositar(100);
            Cliente2.Depositar(150);
            Cliente3.Depositar(200);
            Cliente3.Extraer(150);
        }

        public void DepositosTotales()
        {
            int t = Cliente1.RetornarMonto()+
                    Cliente2.RetornarMonto()+
                    Cliente3.RetornarMonto();
            Console.WriteLine("el total de dinero en el banco es: "+ t);
            Cliente1.Imprimir();
           Cliente2.Imprimir();
            Cliente3.Imprimir();
        }
    }
}
