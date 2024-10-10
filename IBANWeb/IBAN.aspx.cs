using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Coopemep.IBAN.Generacion;
using CuentasIban.Generacion;


public partial class IBAN : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConvertidor_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                lblMensaje.Text = "Debe ingresar la identificacion de la persona";
                divMensaje.Style["background-color"] = "bisque";
                return;
            }


            if (string.IsNullOrEmpty(txtCC.Text))
            {
                lblMensaje.Text = "Debe ingresar el numero de cuenta cliente";
                divMensaje.Style["background-color"] = "bisque";
                return;
            }

            if (txtCC.Text.Trim().Length != 17)
            {
                lblMensaje.Text = "Debe ingresar 17 digitos";
                divMensaje.Style["background-color"] = "bisque";
                return;
            }

            IbanNacional iban = new IbanNacional(txtCC.Text.Trim());
            txtIBAN.Text = iban.NumeroDeCuenta;


            ValidaCuentaIBAN cuenta = new ValidaCuentaIBAN(iban.NumeroDeCuenta, txtIdentificacion.Text.Trim());
          

            if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.CuentaCorrecta )
            {
                lblMensaje.Text = "Cuenta IBAN Válida";
                //lblMensaje.Attributes["class"] = "bg-success";
                divMensaje.Style["background-color"] = "aliceblue";
            }
            else if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.CuentaClienteBloqueada)
            {
                lblMensaje.Text = "Cuenta IBAN Destino bloqueada";
                divMensaje.Style["background-color"] = "bisque";
            }               
            else if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.CuentaClienteCerrada)
            {
                lblMensaje.Text = "Cuenta IBAN Destino Cerrada";
                divMensaje.Style["background-color"] = "bisque";
            }             
            else if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.CuentaClienteIncorrecta)
            {
                lblMensaje.Text = "Cuenta IBAN Destino Incorrecta";
                divMensaje.Style["background-color"] = "bisque";
            }                
            else if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.CuentaClientenoExiste)
            {
                lblMensaje.Text = "Cuenta IBAN Destino No Existe";
                divMensaje.Style["background-color"] = "bisque";
            }
                
            else if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.ProblemasDeComunicación)
            {
                lblMensaje.Text = "Problemas de comunicacion de la entidad destino";
                divMensaje.Style["background-color"] = "bisque";
            }                
            else if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.ProblemasDeComunicación)
            {
                lblMensaje.Text = "Problemas de comunicacion de la entidad destino";
                divMensaje.Style["background-color"] = "bisque";
            }                
            else if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.FondosInsuficientes)
            {
                lblMensaje.Text = "Fondos insuficientes en la cuenta destino";
                divMensaje.Style["background-color"] = "bisque";
            }              
            else if (cuenta.CodigoRechazo == (int)Enumeraciones.MotivoRechazo.IdClienteDestinoNoCoincideConRegistradoEnLaEntidad)
            {
                lblMensaje.Text = "El ID del cliente destino no coincide con el registrado en la entidad";
                divMensaje.Style["background-color"] = "bisque";
            }
            else
            {
                lblMensaje.Text = "Problemas en la respuesta de la entidad destino";
                divMensaje.Style["background-color"] = "bisque";
            }

        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se generó un error : " + ex.Message;
            divMensaje.Style["background-color"] = "bisque";
        }
    }

  

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtCC.Text = string.Empty;
        txtIBAN.Text = string.Empty;
        txtIdentificacion.Text = string.Empty; 
        lblMensaje.Text = string.Empty;
        divMensaje.Style["background-color"] = "none";
    }
}

