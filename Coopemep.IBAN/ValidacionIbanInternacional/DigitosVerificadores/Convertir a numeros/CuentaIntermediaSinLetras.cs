using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class CuentaIntermediaSinLetras
    {

        private RequerimientoParaLaCuentaSinLetras elRequerimiento;
        public CuentaIntermediaSinLetras(string laCuentaIntermedia)
        {
            elRequerimiento = new RequerimientoParaLaCuentaSinLetras(laCuentaIntermedia);
            elRequerimiento.DiccionarioDeLetras = ObtengaElDiccionaroDeLetras();
            elRequerimiento.UltimaPosicion = ObtengaLaUltimaPosicion(laCuentaIntermedia);
        }

        private Dictionary<char, int> ObtengaElDiccionaroDeLetras()
        {
            return new DiccionarioDeLetras().ComoDiccionario();
        }

        private int ObtengaLaUltimaPosicion(string laCuenta)
        {
            return new Hilera(laCuenta).UltimaPosicion;
        }

        public string ComoHilera()
        {
            return DividendoIntermedioDeLaCuenta.Obtenga(elRequerimiento);
        }
    }
}
 
