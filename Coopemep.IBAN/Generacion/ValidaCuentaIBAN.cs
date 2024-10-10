using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Coopemep.IBAN.Generacion
{

    public class ValidaCuentaIBAN
    {
        private readonly string cuentaIBAN;
        TFOExterno.IPELTFOExterno externo = new TFOExterno.IPELTFOExterno();
        TFOExterno.InformacionCuenta cuenta = new TFOExterno.InformacionCuenta();

        public ValidaCuentaIBAN(string cuentaIBAN, string identificacion)
        {
            this.cuentaIBAN = cuentaIBAN;
             cuenta = externo.ObtenerInformacionCuenta(cuentaIBAN, FormateaCedula(identificacion));        
            
           
        }

        public int CodigoRechazo
        {
            get { return cuenta.CodMotivoRechazo; }
            
        }

        string FormateaCedula(string cedula)
        {
            string cedulaFomateada = string.Empty;

            if (cedula.Length == 9)
                cedulaFomateada = $"0{cedula.Substring(0, 1)}-{cedula.Substring(1, 4)}-{cedula.Substring(5, 4)}";
            else if (cedula.Length == 10)
                cedulaFomateada = $"{cedula.Substring(0, 1)}-{cedula.Substring(1, 3)}-{cedula.Substring(4, 6)}";
            else
                cedulaFomateada = cedula;

            return cedulaFomateada;
        }


    }
}
