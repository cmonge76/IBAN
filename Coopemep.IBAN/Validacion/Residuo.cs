
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Validacion
{
    public class Residuo
    {

        private decimal laCuentaIntermedia;
        public Residuo(string laCuenta, string losDigitosVerificadores)
        {
            laCuentaIntermedia = new CuentaIntermedia(laCuenta, losDigitosVerificadores).ComoNumero();
        }

        public int ComoNumero()
        {
            return (int)(laCuentaIntermedia % 97);
        }
    }
}
