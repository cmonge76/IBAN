using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class NumerosRestantes
    {
        private double laCantidadRestante;
        private string elResiduoAcumulado;

        private int elTamañodelIntervalo;
        public NumerosRestantes(ResultadoDelResiduo elResultado)
        {
            laCantidadRestante = ObtengaLaCantidadRestanteDeDigitos(elResultado);
            elResiduoAcumulado = ObtengaElResiduoAcumulado(elResultado);
            elTamañodelIntervalo = ObtengaElTamañodelIntervalo(elResultado);
        }

        private int ObtengaElTamañodelIntervalo(ResultadoDelResiduo elResultado)
        {
            return elResultado.TamañodelIntervalo;
        }

        private string ObtengaElResiduoAcumulado(ResultadoDelResiduo elResultado)
        {
            return elResultado.ResiduoAcumulado;
        }

        private double ObtengaLaCantidadRestanteDeDigitos(ResultadoDelResiduo elResultado)
        {
            return elResultado.CantidadRestanteDeDigitos;
        }

        public string ComoHilera()
        {
            return elResiduoAcumulado.Substring(elTamañodelIntervalo, Convert.ToInt32(laCantidadRestante));
        }
    }
}

