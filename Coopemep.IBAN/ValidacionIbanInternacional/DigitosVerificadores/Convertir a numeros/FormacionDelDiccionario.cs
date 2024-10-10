
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class FormacionDelDiccionario
    {
        public static Dictionary<char, int> Obtenga(int laUltimaPosicion, char[] elArregloDeLetras)
        {
            Dictionary<char, int> elDiccionarioDeLetras = new Dictionary<char, int>();

            for (int laPosicionDeLaLetra = 0; laPosicionDeLaLetra <= laUltimaPosicion; laPosicionDeLaLetra++)
            {
                char laLetra = '\0';
                laLetra = ObtengaLaLetra(elArregloDeLetras, laPosicionDeLaLetra);

                int elPeso = 0;
                elPeso = CalculeElPeso(laPosicionDeLaLetra);

                elDiccionarioDeLetras.Add(laLetra, elPeso);
            }

            return elDiccionarioDeLetras;
        }

        private static char ObtengaLaLetra(char[] elArregloDeLetras, int laPosicionDeLaLetra)
        {
            return elArregloDeLetras[laPosicionDeLaLetra];
        }

        private static int CalculeElPeso(int laPosicionDeLaLetra)
        {
            return laPosicionDeLaLetra + 10;
        }
    }
}

 