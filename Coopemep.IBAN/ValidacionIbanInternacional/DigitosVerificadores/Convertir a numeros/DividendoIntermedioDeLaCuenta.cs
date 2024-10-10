using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class DividendoIntermedioDeLaCuenta
    {
        public static string Obtenga(RequerimientoParaLaCuentaSinLetras elRequerimiento)
        {
            ResultadoDeLaCuentaSinLetras elResultado = new ResultadoDeLaCuentaSinLetras(elRequerimiento);

            while (elResultado.HayMasPosiciones())
            {
                elResultado.CuentaSinLetras = ObtengaLaCuentaSinLetras(elResultado);
                elResultado.IncrementeLaPosicion();
            }

            return elResultado.CuentaSinLetras;
        }

        private static string ObtengaLaCuentaSinLetras(ResultadoDeLaCuentaSinLetras elResultado)
        {
            return new CuentaSinLetrasParaLaPosicion(elResultado).ComoHilera();
        }
    }
}
