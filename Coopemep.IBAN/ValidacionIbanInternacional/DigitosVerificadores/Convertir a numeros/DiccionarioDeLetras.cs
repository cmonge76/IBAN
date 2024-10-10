
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class DiccionarioDeLetras
    {

        private char[] elArregloDeLetras;
        public DiccionarioDeLetras()
        {
            elArregloDeLetras = ObtengaElArregloDeLetras();
        }

        private char[] ObtengaElArregloDeLetras()
        {
            return "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        }

        public Dictionary<char, int> ComoDiccionario()
        {
            return new ArregloDeLetras(elArregloDeLetras).ComoDiccionario();
        }
    }
}

 