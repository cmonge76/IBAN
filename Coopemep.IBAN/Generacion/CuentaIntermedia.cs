
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Generacion
{
    public class CuentaIntermedia
    {

        private string elRequerimiento;
        public CuentaIntermedia(string laCuentaCliente)
        {
            elRequerimiento = laCuentaCliente + NumeroISODelPais + CodigoDelPais;
        }

        public string NumeroISODelPais
        {
            get { return "1227"; }
        }

        public string CodigoDelPais
        {
            get { return "00"; }
        }

        public decimal ComoNumero()
        {
            return decimal.Parse(elRequerimiento);
        }
    }
}