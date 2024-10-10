using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ResultadoDeLaCuentaSinLetras
    {
        public ResultadoDeLaCuentaSinLetras(RequerimientoParaLaCuentaSinLetras elRequerimiento)
        {
            CuentaSinLetras = elRequerimiento.CuentaEnMayusculas;
            UltimaPosicion = elRequerimiento.UltimaPosicion;
            CuentaEnMayusculas = elRequerimiento.CuentaEnMayusculas;
            DiccionarioDeLetras = elRequerimiento.DiccionarioDeLetras;
            Posicion = 0;
        }

        public bool HayMasPosiciones()
        {
            return Posicion <= UltimaPosicion;
        }

        public int ObtengaElPesoActual()
        {
            return DiccionarioDeLetras[Caracter];
        }

        public void IncrementeLaPosicion()
        {
            Posicion = Posicion + 1;
        }

        public string CuentaSinLetras { get; set; }
        public int UltimaPosicion { get; set; }
        public string CuentaEnMayusculas { get; set; }
        public Dictionary<char, int> DiccionarioDeLetras { get; set; }
        public int Posicion { get; set; }

        public char Caracter
        {
            get { return Convert.ToChar(CuentaEnMayusculas.Substring(Posicion, 1)); }
        }
    }
}

 