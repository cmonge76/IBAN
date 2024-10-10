using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ResiduoAcumuladoParaElIntervalo
    {
        private string losNumerosRestantes;
        private int elResiduo;

        private int elTamañoDelResiduo;
        public ResiduoAcumuladoParaElIntervalo(ResultadoDelResiduo elResultado)
        {
            elTamañoDelResiduo = ObtengaElTamañoDelResiduo(elResultado);
            losNumerosRestantes = GenereLosNumerosRestantes(elResultado);
            elResiduo = ObtengaElResiduoDelIntervalo(elResultado);
        }

        private int ObtengaElTamañoDelResiduo(ResultadoDelResiduo elResultado)
        {
            return Convert.ToInt32(elResultado.TamañoDelResiduo);
        }

        private int ObtengaElResiduoDelIntervalo(ResultadoDelResiduo elResultado)
        {
            return new ResiduoDelIntervalo(elResultado).ComoNumero();
        }

        private string GenereLosNumerosRestantes(ResultadoDelResiduo elResultado)
        {
            return new NumerosRestantes(elResultado).ComoHilera();
        }

        public string ComoHilera()
        {
            return new ResiduoComoTexto(elResiduo).CompletadoCon(losNumerosRestantes);
        }


    }
}

 