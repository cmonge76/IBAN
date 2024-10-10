
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Validacion
{
    public class DigitosVerificadores
    {
        private int elResiduo;
        private string losDigitosVerificadores;
        public DigitosVerificadores(string laCuenta)
        {
            losDigitosVerificadores = ObtengaLosDigitosVerificadores(laCuenta);
            elResiduo = new Residuo(laCuenta, losDigitosVerificadores).ComoNumero();
        }

        private static string ObtengaLosDigitosVerificadores(string laCuenta)
        {
            return laCuenta.Substring(2, 2);
        }

        public bool SonValidos()
        {
            if (elResiduo == 1 & losDigitosVerificadores != "00")
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
