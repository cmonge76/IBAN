
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Validacion
{
    public class CuentaIntermedia
    {

        private string laCuentaIntermediaComoTexto;
        public CuentaIntermedia(string laCuenta, string losDigitosVerificadores)
        {
            laCuentaIntermediaComoTexto = new CuentaCliente(laCuenta, losDigitosVerificadores).CuentaIntermedia();
        }

        public decimal ComoNumero()
        {
            return decimal.Parse(laCuentaIntermediaComoTexto);
        }
    }
}

