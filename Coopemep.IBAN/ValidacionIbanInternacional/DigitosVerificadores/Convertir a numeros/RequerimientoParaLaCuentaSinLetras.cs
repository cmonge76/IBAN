using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class RequerimientoParaLaCuentaSinLetras
    {

        private string laCuentaEnMayusculas;
        public RequerimientoParaLaCuentaSinLetras(string laCuentaIntermedia)
        {
            laCuentaEnMayusculas = ConviertaAMayusculas(laCuentaIntermedia);
        }

        private string ConviertaAMayusculas(string laCuenta)
        {
            return laCuenta.ToUpper();
        }

        public string CuentaEnMayusculas
        {
            get { return laCuentaEnMayusculas; }
        }

        public Dictionary<char, int> DiccionarioDeLetras;
        public int UltimaPosicion { get; set; }
    }
}

