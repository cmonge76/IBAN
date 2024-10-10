using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class DigitosVerificadores
    {
        private int elResiduoComoNumero;

        private Cuenta laCuenta;
        public DigitosVerificadores(string elIban)
        {
            laCuenta = new Cuenta(elIban);
            elResiduoComoNumero = ObtengaElResiduoComoNumero(laCuenta);
        }

        private int ObtengaElResiduoComoNumero(Cuenta laCuenta)
        {
            return new Residuo(laCuenta).ComoNumero();
        }

        public bool SonValidos()
        {
            if (elResiduoComoNumero == 1 && laCuenta.LosDigitosNoSonCero())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
