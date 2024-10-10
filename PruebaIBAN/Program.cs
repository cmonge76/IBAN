using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIBAN
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite la Cuenta cliente:");
            string cc = Console.ReadLine();

            CuentasIban.Generacion.IbanNacional iban = new CuentasIban.Generacion.IbanNacional(cc);
            Console.WriteLine("Cuenta IBAN:" + iban.NumeroDeCuenta);
            Console.ReadLine();

        }
    }
}
