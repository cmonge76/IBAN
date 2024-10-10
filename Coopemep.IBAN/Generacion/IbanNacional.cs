
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace CuentasIban.Generacion
{
    public class IbanNacional
    {
        private string losDigitos;
        private string laCuentaClienteConFormato;

        public IbanNacional(string laCuentaCliente)
        {
            this.laCuentaClienteConFormato = new CuentaCliente(laCuentaCliente).ConFormato();

            losDigitos = new DigitosVerificadores(laCuentaClienteConFormato).ComoTexto();
        }

        public string NumeroDeCuenta
        {
            get { return InicialesDelPais + losDigitos + laCuentaClienteConFormato; }
        }

        public string InicialesDelPais
        {
            get { return "CR"; }
        }
    }
}
 