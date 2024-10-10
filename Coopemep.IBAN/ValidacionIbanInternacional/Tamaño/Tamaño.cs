
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class Tamaño
    {

        private int elTamañoDelIBAN;
        public Tamaño(string elIBAN)
        {
            elTamañoDelIBAN = elIBAN.Length;
        }

        public bool EsValido()
        {
            if (elTamañoDelIBAN > 4 & elTamañoDelIBAN < 35)
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

 