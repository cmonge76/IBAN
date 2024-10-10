using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ArregloDeLetras
    {
        private int laUltimaPosicion;

        private char[] elArregloDeLetras;
        public ArregloDeLetras(char[] elArregloDeLetras)
        {
            laUltimaPosicion = ObtengaLaUltimaPosicion(elArregloDeLetras);
            this.elArregloDeLetras = elArregloDeLetras;
        }

        private int ObtengaLaUltimaPosicion(char[] elArregloDeLetras)
        {
            return new Hilera(new string(elArregloDeLetras)).UltimaPosicion;
        }

        public Dictionary<char, int> ComoDiccionario()
        {
            return FormacionDelDiccionario.Obtenga(laUltimaPosicion, elArregloDeLetras);
        }
    }
}
