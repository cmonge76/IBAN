using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class RequerimientoParaElResiduo
    {
        public string CuentaSinLetras { get; set; }

        public int TamañoDeLaCuenta
        {
            get { return CuentaSinLetras.Length; }
        }

        public int CantidadDeIntervalos
        {
            get
            {
                if (TamañoDeLaCuenta < 10)
                {
                    return 1;
                }
                else
                {
                    return (TamañoDeLaCuenta / 10);
                }

            }
        }
    }
}

