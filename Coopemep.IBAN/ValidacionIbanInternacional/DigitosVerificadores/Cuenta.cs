using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class Cuenta
    {
        private string elIban;

        private int elTamaño;
        public Cuenta(string elIban)
        {
            this.elIban = elIban;
            elTamaño = elIban.Length;
        }

        public string CodigoDePais
        {
            get { return elIban.Substring(0, 2); }
        }

        public string DigitosVerificadores
        {
            get { return elIban.Substring(2, 2); }
        }


        public string Iban
        {
            get { return elIban; }
        }

        public int TamañoDeLaCuentaCliente
        {
            get { return elTamaño - 4; }
        }

        public bool LosDigitosNoSonCero()
        {
            return DigitosVerificadores != "00";
        }
    }
}
