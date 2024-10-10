
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class CuentaIntermedia
    {
        private string laCuentaCliente;
        private string elCodigoDePais;

        private string losDigitosVerificadores;
        public CuentaIntermedia(Cuenta laCuenta)
        {
            laCuentaCliente = ObtengaLaCuenta(laCuenta);
            elCodigoDePais = ObtengaElCodigoDePais(laCuenta);
            losDigitosVerificadores = ObtengaLosDigitosVerificadores(laCuenta);
        }

        private string ObtengaLosDigitosVerificadores(Cuenta laCuenta)
        {
            return laCuenta.DigitosVerificadores;
        }

        private string ObtengaLaCuenta(Cuenta laCuenta)
        {
            return new CuentaCliente(laCuenta).ComoHilera();
        }


        private string ObtengaElCodigoDePais(Cuenta laCuenta)
        {
            return laCuenta.CodigoDePais;
        }

        public string ComoHilera()
        {
            return laCuentaCliente + elCodigoDePais + losDigitosVerificadores;
        }
    }
}

 