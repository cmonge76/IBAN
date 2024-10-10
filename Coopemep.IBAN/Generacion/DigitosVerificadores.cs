using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Generacion
{
    public class DigitosVerificadores
    {

        private decimal elNumeroVerificador;
        public DigitosVerificadores(string laCuentaCliente)
        {
            elNumeroVerificador = new NumeroVerificador(laCuentaCliente).ComoNumero();
        }

        public string ComoTexto()
        {
            if (TieneSoloUnDigito())
            {
                return ElNumeroPredecidoConUnCero();
            }
            else
            {
                return ElNumeroComoTexto();
            }
        }

        private bool TieneSoloUnDigito()
        {
            return elNumeroVerificador < 10;
        }

        private string ElNumeroPredecidoConUnCero()
        {
            return "0" + elNumeroVerificador;
        }

        private string ElNumeroComoTexto()
        {
            return elNumeroVerificador.ToString();
        }
    }
}
