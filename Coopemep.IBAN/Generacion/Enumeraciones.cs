using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopemep.IBAN.Generacion
{
    public class Enumeraciones
    {
        public enum MotivoRechazo
        {
            CuentaCorrecta = 0,
            FondosInsuficientes = 21,
            CuentaClienteCerrada = 23,
            CuentaClientenoExiste = 28,
            CuentaClienteBloqueada = 31,
            IdClienteDestinoNoCoincideConRegistradoEnLaEntidad = 32,
            CuentaClienteIncorrecta = 39,
            ProblemasDeComunicación = 76,
            ProblemasEnLaRespuestaDelDestino = 83,
            MonedaNoCorresponde = 91,
            EntidadDestinoNoDisponibleParaProcesarEnTiempoReal = 100,
            ElIdDeClienteDestinoNoCumpleConElFormatoEsperadoPorElSINPE = 1002,
            ElServicioDelSINPENoEstaDisponible = 1003,
            ElIdDeClienteOrigenNoCumpleConElFormatoEsperadoPorElSINPE = 1004,
            ElCampoTieneUnValorOFormatoInvalido = 1005,
            ProblemasDeComunicacionConElCoreBancario = 1007,
            ElValorParaElCampoNoPuedeSerNuloOInfringirSuLongitudMínimaOMaxima = 1009,
            LaEstructuraXMLDelTipoDeRegistroUtilizadoEsIncorrecta = 1032,
            ElValorDelCampoDebeSerUnBooleanoExpresadoCon1O0 = 1033,
            SeEstaIntentandoEnviarUnRegistroFueraDelHorarioPermitido = 1036,
            ProblemasDeProcesamiento = 1039,
            CanalNoCorresponde = 1042,
            LaCuentaClienteOrigenSeEncuentraInactivaBloqueadaCerradaEnElCoreBancario = 1054,
            ElMontoMaximoParaMovimientosEnElCoreBancarioParaLaCuentaClienteFueAlcanzado = 1055
        }

    }
}
