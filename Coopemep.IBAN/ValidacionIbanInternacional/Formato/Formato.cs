
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CuentasIban.ValidacionIbanInternacional
{
    public class Formato
    {
        private string elIBAN;

        private Regex laExpresionRegularParaElIBAN;
        public Formato(string elIBAN)
        {
            this.elIBAN = elIBAN;

            //2 letras mayusculas 2 numeros  n letras minusculas/mayusculas o numeros
            //Ejemplo: MA33MAT3443566334
            laExpresionRegularParaElIBAN = new Regex("^[A-Z]{2}[0-9]{2}[a-zA-Z0-9]+$");
        }

        public bool EsValido()
        {
            return laExpresionRegularParaElIBAN.IsMatch(elIBAN);
        }
    }
}

 