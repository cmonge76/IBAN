using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class CuentaSinLetrasParaLaPosicion
    {
        private ResultadoDeLaCuentaSinLetras elResultado;
        private char elCaracter;

        private string laCuentaSinLetras;
        public CuentaSinLetrasParaLaPosicion(ResultadoDeLaCuentaSinLetras elResultado)
        {
            this.elResultado = elResultado;
            elCaracter = ObtengaLaLetraEnLaPosicion(elResultado);
            laCuentaSinLetras = ObtengaLaCuentaSinLetras(elResultado);
        }

        private string ObtengaLaCuentaSinLetras(ResultadoDeLaCuentaSinLetras elResultado)
        {
            return elResultado.CuentaSinLetras;
        }

        private char ObtengaLaLetraEnLaPosicion(ResultadoDeLaCuentaSinLetras elResultado)
        {
            return elResultado.Caracter;
        }

        public string ComoHilera()
        {
            if (!Information.IsNumeric(elCaracter))
            {
                return new CaracteresNumerico(elResultado).ConLaLetraReemplazada();
            }
            else
            {
                return laCuentaSinLetras;
            }
        }
    }
}
