
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Generacion
{
    public class NumeroVerificador
    {

        private decimal elRequerimiento;
        public NumeroVerificador(string laCuentaCliente)
        {
            elRequerimiento = new CuentaIntermedia(laCuentaCliente).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return 98 - elRequerimiento % 97;
        }
    }
}

 