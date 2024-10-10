using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ResiduoComoTexto
    {

        private string elResiduoConvertido;
        public ResiduoComoTexto(int elResiduoComoNumero)
        {
            elResiduoConvertido = elResiduoComoNumero.ToString();
        }

        public string CompletadoCon(string losNumerosRestantes)
        {
            return elResiduoConvertido + losNumerosRestantes;
        }
    }
}

 