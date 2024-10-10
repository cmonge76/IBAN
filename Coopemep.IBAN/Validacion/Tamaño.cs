
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Validacion
{
    public class Tamaño
    {

        private int elTamanoDeLaCuenta;
        public Tamaño(string laCuenta)
        {
            elTamanoDeLaCuenta = laCuenta.Length;
        }

        public bool EsCorrecto()
        {
            if (elTamanoDeLaCuenta == 22)
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
