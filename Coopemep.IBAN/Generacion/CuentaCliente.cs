using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;


namespace CuentasIban.Generacion
{
    public class CuentaCliente
    {

             

        private string laCuentaCliente;
        private int elTamaño;
        public CuentaCliente(string laCuentaCliente)
        {
            elTamaño = ObtengaElTamaño(laCuentaCliente);
            this.laCuentaCliente = laCuentaCliente;
        }

        private static int ObtengaElTamaño(string laCuentaCliente)
        {
            return laCuentaCliente.Length;
        }

        public string ConFormato()
        {
            if (NecesitaCompletarseConCero())
            {
                return AgregaUnCeroAlInicio();
            }
            else
            {
                return laCuentaCliente;
            }
        }

        private bool NecesitaCompletarseConCero()
        {
            return elTamaño < 18;
        }
        private string AgregaUnCeroAlInicio()
        {
            return "0" + laCuentaCliente;
        }
    }

}