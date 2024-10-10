using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class CaracteresNumerico
    {
        private int elNumeroAsociado;
        private string laCuentaSinLetras;

        private char elCaracter;
        public CaracteresNumerico(ResultadoDeLaCuentaSinLetras elResultado)
        {
            elNumeroAsociado = ObtengaElPesoParaLaLetra(elResultado);
            laCuentaSinLetras = ObtengaLaCuentaSinLetras(elResultado);
            elCaracter = ObtengaElCaracter(elResultado);
        }

        private static char ObtengaElCaracter(ResultadoDeLaCuentaSinLetras elResultado)
        {
            return elResultado.Caracter;
        }

        private static string ObtengaLaCuentaSinLetras(ResultadoDeLaCuentaSinLetras elResultado)
        {
            return elResultado.CuentaSinLetras;
        }

        private int ObtengaElPesoParaLaLetra(ResultadoDeLaCuentaSinLetras elResultado)
        {
            return elResultado.ObtengaElPesoActual();
        }

        public string ConLaLetraReemplazada()
        {
            return laCuentaSinLetras.Replace(elCaracter, Convert.ToChar(elNumeroAsociado));
        }
    }
}

