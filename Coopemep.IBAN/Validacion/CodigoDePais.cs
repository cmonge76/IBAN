
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.Validacion
{
    public class CodigoDePais
    {

        private string lasLetrasDelPais;
        public CodigoDePais(string laCuenta)
        {
            lasLetrasDelPais = laCuenta.Substring(0, 2);
        }

        public bool EsNacional()
        {
            if (lasLetrasDelPais == "CR")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
