using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class IBANInternacional
    {
        private bool elTamañoEsValido;
        private bool elFormatoEsValido;

        private bool losDigitosSonValidos;
        public IBANInternacional(string elIBAN)
        {
            elTamañoEsValido = VerfiqueSiElTamañoEsValido(elIBAN);
            elFormatoEsValido = VerifiqueQueElFormatoSeaCorrecto(elIBAN);
            losDigitosSonValidos = VerifiqueLosDigitosSonValidos(elIBAN);
        }

        private bool VerfiqueSiElTamañoEsValido(string elIban)
        {
            return new Tamaño(elIban).EsValido();
        }

        private bool VerifiqueQueElFormatoSeaCorrecto(string elIban)
        {
            return new Formato(elIban).EsValido();
        }

        private bool VerifiqueLosDigitosSonValidos(string elIban)
        {
            if (elFormatoEsValido & elTamañoEsValido)
            {
                return new DigitosVerificadores(elIban).SonValidos();
            }
            else
            {
                return false;
            }
        }

        public bool EsValido()
        {
            if (elTamañoEsValido & losDigitosSonValidos & elFormatoEsValido)
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

