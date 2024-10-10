using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class CalculoDelResiduoAcumulado
    {
        public static string Obtenga(RequerimientoParaElResiduo elRequerimiento)
        {
            ResultadoDelResiduo elResultado = new ResultadoDelResiduo(elRequerimiento);

            while (elResultado.HayMasIntervalos())
            {
                elResultado.ResiduoAcumulado = ObtengaLosDigitosParaVerificar(elResultado);
                elResultado.IncrementeElIntervalo();
            }

            return elResultado.ResiduoAcumulado;
        }

        private static string ObtengaLosDigitosParaVerificar(ResultadoDelResiduo elResultado)
        {
            return new ResiduoAcumuladoParaElIntervalo(elResultado).ComoHilera();
        }
    }
}

