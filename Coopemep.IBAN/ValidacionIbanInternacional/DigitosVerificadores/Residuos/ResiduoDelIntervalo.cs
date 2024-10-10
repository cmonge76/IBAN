using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ResiduoDelIntervalo
    {

        private string losDigitosEnElIntervalo;
        public ResiduoDelIntervalo(ResultadoDelResiduo elResultado)
        {
            losDigitosEnElIntervalo = elResultado.ObtengaLosDigitosDelIntervalo();
        }

        public int ComoNumero()
        {
            return new ResiduoDelNumero(losDigitosEnElIntervalo).ComoNumero();
        }
    }
}

 