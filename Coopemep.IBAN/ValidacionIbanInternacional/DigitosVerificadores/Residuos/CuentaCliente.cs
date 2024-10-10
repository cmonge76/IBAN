using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class CuentaCliente
    {
        private int elTamañoDeLaCuentaCliente;

        private string elIban;
        public CuentaCliente(Cuenta laCuenta)
        {
            elTamañoDeLaCuentaCliente = ObtengaElTamañoDeLaCuentaCliente(laCuenta);
            elIban = ObtengaTodoElNumeroDeCuenta(laCuenta);
        }

        private static string ObtengaTodoElNumeroDeCuenta(Cuenta laCuenta)
        {
            return laCuenta.Iban;
        }

        private int ObtengaElTamañoDeLaCuentaCliente(Cuenta laCuenta)
        {
            return laCuenta.TamañoDeLaCuentaCliente;
        }

        public string ComoHilera()
        {
            return elIban.Substring(4, elTamañoDeLaCuentaCliente);
        }
    }
}

