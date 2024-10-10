using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class Hilera
    {

        private int elTamaño;
        public Hilera(string laCuenta)
        {
            elTamaño = laCuenta.Length;
        }

        public int UltimaPosicion
        {
            get { return elTamaño - 1; }
        }
    }
}
 