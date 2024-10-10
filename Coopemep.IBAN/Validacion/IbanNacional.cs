
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Validacion
{
    public class IbanNacional
    {
        private bool tieneElTamanoCorrecto;
        private bool esNacional;

        private bool losDigitosSonValidos;
        public IbanNacional(string laCuenta)
        {
            tieneElTamanoCorrecto = new Tamaño(laCuenta).EsCorrecto();
            if (tieneElTamanoCorrecto)
            {
                esNacional = new CodigoDePais(laCuenta).EsNacional();
            }
            else
            {
                esNacional = false;
            }
            if (tieneElTamanoCorrecto & esNacional)
            {
                losDigitosSonValidos = new DigitosVerificadores(laCuenta).SonValidos();
            }
            else
            {
                losDigitosSonValidos = false;
            }
        }

        public bool EsValida()
        {
            if (tieneElTamanoCorrecto & esNacional & losDigitosSonValidos)
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

