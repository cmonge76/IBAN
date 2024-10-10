
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ResiduoDelNumero
    {

        private decimal elNumeroEnElIntervalo;
        public ResiduoDelNumero(string losDigitosEnElIntervalo)
        {
            elNumeroEnElIntervalo = ConviertaElIntervaloANumero(losDigitosEnElIntervalo);
        }

        public int ComoNumero()
        {
            return Convert.ToInt32(elNumeroEnElIntervalo % 97);
        }

        private decimal ConviertaElIntervaloANumero(string losDigitosEnElIntervalo)
        {
            return decimal.Parse(losDigitosEnElIntervalo);
        }
    }
}

 