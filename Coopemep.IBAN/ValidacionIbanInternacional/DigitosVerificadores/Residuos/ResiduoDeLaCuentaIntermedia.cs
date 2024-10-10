using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ResiduoDeLaCuentaIntermedia
    {

        string laCuentaIntermedia;
        public ResiduoDeLaCuentaIntermedia(Cuenta laCuenta)
        {
            laCuentaIntermedia = new CuentaIntermedia(laCuenta).ComoHilera();
        }

        public string ComoHilera()
        {
            return new ResiduoAcumulado(laCuentaIntermedia).ComoHilera();
        }
    }
}

 