
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Validacion
{
    public class CuentaCliente
    {
        private string laCuentaCliente;

        private string losDigitosVerificadores;
        public CuentaCliente(string laCuenta, string losDigitosVerificadores)
        {
            laCuentaCliente = ObtengaLaCuentaCliente(laCuenta);
            this.losDigitosVerificadores = losDigitosVerificadores;
        }

        private static string ObtengaLaCuentaCliente(string laCuenta)
        {
            return laCuenta.Substring(4, 18);
        }

        public string CuentaIntermedia()
        {
            return laCuentaCliente + "1227" + losDigitosVerificadores;
        }
    }
}
