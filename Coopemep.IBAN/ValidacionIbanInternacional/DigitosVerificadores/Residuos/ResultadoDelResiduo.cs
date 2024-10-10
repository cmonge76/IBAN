using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ResultadoDelResiduo
    {
        public ResultadoDelResiduo(RequerimientoParaElResiduo elRequerimiento)
        {
            ResiduoAcumulado = elRequerimiento.CuentaSinLetras;
            CantidadDeIntervalos = elRequerimiento.CantidadDeIntervalos;
            Intervalo = 1;
        }

        public bool HayMasIntervalos()
        {
            return Intervalo <= CantidadDeIntervalos;
        }

        public string ObtengaLosDigitosDelIntervalo()
        {
            return ResiduoAcumulado.Substring(0, TamañodelIntervalo);
        }

        public void IncrementeElIntervalo()
        {
            Intervalo = Intervalo + 1;
        }

        public string ResiduoAcumulado { get; set; }
        public int TamañodelIntervalo
        {
            get
            {
                if (SeLlegoAlFinal())
                {
                    return Convert.ToInt32(TamañoDelResiduo);
                }
                else
                {
                    return 10;
                }
            }
        }
        public int CantidadDeIntervalos { get; set; }
        public int Intervalo { get; set; }
        public string TamañoDelResiduo
        {
            get { return ResiduoAcumulado.Length.ToString(); }
        }

        public double CantidadRestanteDeDigitos
        {
            get { return Convert.ToDouble(Convert.ToInt32(TamañoDelResiduo) - Convert.ToInt32(TamañodelIntervalo)); }
        }

        private bool SeLlegoAlFinal()
        {
            return Intervalo == CantidadDeIntervalos;
        }

    }
}

