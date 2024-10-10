using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CuentasIban.ValidacionIbanInternacional
{
    public class ResiduoAcumulado
    {

        private RequerimientoParaElResiduo elRequerimiento;
        public ResiduoAcumulado(string laCuentaIntermedia)
        {
            elRequerimiento = new RequerimientoParaElResiduo();
            elRequerimiento.CuentaSinLetras = ObtengaLaCuentaIntermediaSinLetras(laCuentaIntermedia);
        }

        private string ObtengaLaCuentaIntermediaSinLetras(string laCuentaIntermedia)
        {
            return new CuentaIntermediaSinLetras(laCuentaIntermedia).ComoHilera();
        }

        public string ComoHilera()
        {
            return CalculoDelResiduoAcumulado.Obtenga(elRequerimiento);
        }
    }
}
