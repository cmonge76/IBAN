using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class Residuo
    {

        private string elResiduo;
        public Residuo(Cuenta laCuenta)
        {
            elResiduo = new ResiduoDeLaCuentaIntermedia(laCuenta).ComoHilera();
        }

        public int ComoNumero()
        {
            return Convert.ToInt32(elResiduo);
        }
    }
}

